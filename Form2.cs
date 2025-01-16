using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        bool isPasswordVisible = false;
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close operation
            }
            else
            {
                Application.Exit(); // Terminate the application
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                else
                {
                    string c = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=AP_Project;Data Source=DESKTOP-4SF52E2";
                    SqlConnection con = new SqlConnection(c);
                    con.Open();
                    string q = "insert into accounts values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    MessageBox.Show("register successfully");
                    Form1 form1 = new Form1();
                    form1.Show();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exists");

                throw;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                textBox2.PasswordChar = '*';
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                isPasswordVisible = false;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                isPasswordVisible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus  ();
        }
    }
}
