using clinic.Model;
using Dapper;
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

namespace clinic
{
    public partial class LoginForm : Form
    {
        private readonly string _connectionString = connection.Conn("clinic_db");
        public static string LoggedInUserRole = "";
        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }
        


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            passText.PasswordChar = '*';
            string username = userText.Text.Trim();
            string password = passText.Text.Trim(); // Use hashing for security
            string role = AuthenticateStaff(username, password);

            if (role != null )
            {
                LoggedInUserRole = role;
                MessageBox.Show($"Login Successful! Role: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                this.Hide();
                Dashboard das = new Dashboard(); // Open main dashboard
                das.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private string AuthenticateStaff(string name, string password)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "SELECT Role FROM staff WHERE Name = @Name AND Password = @Password";
                return  db.QuerySingleOrDefault<string>(query, new { Name = name, Password = password });
               
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

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = chkPass.Checked ? '\0' : '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passText.PasswordChar = '*';
        }
    }
}
