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
using MetroFramework.Forms;


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
            LoadTotalRevenue();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart.Series.Clear();
            Series series = new Series("Data")
            {
                ChartType = SeriesChartType.Column
            };
            series.Points.AddXY("Category 1", 10);
            series.Points.AddXY("Category 2", 20);
            series.Points.AddXY("Category 3", 30);
            chart.Series.Add(series);


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
                List<DoctorAvailable> Doctor = _dataAccess.GetDoctorAvailable();
                totalDoctorText.Text = Doctor.Count.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTotalRevenue()
        {
            string sql = "SELECT SUM(totalCost) FROM Payments";
            try
            {
                DataTable dt = _dataAccess.GetDataTable(sql);
                totalRevenueText.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                BtnDoctor.Enabled = false; 
                BtnDoctor.Visible = false;
                BtnStaff.Enabled = false;
                BtnStaff.Visible = false;
            }
            else if (LoginForm.LoggedInUserRole == "admin")
            {
               
                BtnDoctor.Enabled = true;
                BtnStaff.Enabled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            appiontmentManagement ap = new appiontmentManagement();
            ap.Show();
            this.Hide();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            doctorsManagerment doc = new doctorsManagerment();
            doc.Show();
            this.Hide();
        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            petientsManagerment pet = new petientsManagerment();
            pet.Show();
            this.Hide();
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            serviceManagerment ser = new serviceManagerment();
            ser.Show();
            this.Hide();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            StaffManagerment staff = new StaffManagerment();
            staff.Show();
            this.Hide();
        }
    }
}
