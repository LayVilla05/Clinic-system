using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (userText.Text == "admin" && passText.Text =="password" )
            {
                Dashboard das = new Dashboard();
                das.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please put the user name and password" );
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            userText.Text = "";
            passText.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
