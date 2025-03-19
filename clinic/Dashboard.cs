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
            LoadTotalPatient();
            LoadTotalDoctor();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
        }
        private void LoadTotalPatient()
        {
            try
            {
                List<Patients> TotalPateints = _dataAccess.GetPatients();
                totalPatientsText.Text = TotalPateints.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTotalDoctor()
        {
            try
            {
                List<Doctors> TotalDoctor = _dataAccess.GetDoctors();
                totalDoctorText.Text = TotalDoctor.Count.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ApplyRolePermissions()
        {
            if (LoginForm.LoggedInUserRole == "staff")
            {
                DoctorBtn.Enabled = false; 
                DoctorBtn.Visible = false;
                StaffBtn.Enabled = false;
                StaffBtn.Visible = false;
            }
            else if (LoginForm.LoggedInUserRole == "admin")
            {
               
                DoctorBtn.Enabled = true;
                StaffBtn.Enabled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffManagerment staff = new StaffManagerment();
            staff.Show();
            this.Hide();
            
        }
    }
}
