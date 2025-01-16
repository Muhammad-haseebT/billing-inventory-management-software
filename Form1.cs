using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool isPasswordVisible = false;
        public TextBox tb;
        public static Form1 f;
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            f = this;
            tb = textBox1;
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => Application.Exit();
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
                    string query = "select * from accounts where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Login Successful");
                        tb = textBox1;
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                        form3.FormClosed += (s, args) => Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
       


    }
}
