using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akbor_RenginOzgun_Hw2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == "admin" && passwordbox.Text == "1234")
            {
                this.Hide();
                Form booklist = new Select();
                booklist.Show();
            }
            else { MessageBox.Show("Login Failed!"); }
        }
    }
}
