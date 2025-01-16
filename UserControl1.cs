using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (!DesignMode) // Ensure this runs only at runtime
            {
                if (Form1.f != null && Form1.f.tb != null)
                {
                    label1.Text = "Welcome, " + Form1.f.tb.Text;
                }
                else
                {
                    label1.Text = "Welcome!";
                }
            }
        }
    }
}
