using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl2 : UserControl
    {
        private string connectionString = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=AP_Project;Data Source=DESKTOP-4SF52E2";
        private SqlConnection con;

        public UserControl2()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                // Populate DataGridView
                dataGridView1.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadAllData();
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT * FROM product WHERE name LIKE @SearchText";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
