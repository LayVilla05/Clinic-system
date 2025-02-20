using clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace clinic
{
    
    public partial class Dashboard : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void LoadDashboardData()
        {
          
        }

        private void AppiontmentBtn_Click(object sender, EventArgs e)
        {
            appiontmentManagement ap = new appiontmentManagement();   
            ap.Show();
            this.Hide();
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            serviceManagerment ser = new serviceManagerment();
            ser.Show();
            this.Hide();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            petientsManagerment pet = new petientsManagerment();
            pet.Show();
            this.Hide();
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            doctorsManagerment doc = new doctorsManagerment();
            doc.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
