using clinic.Model;
using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace clinic
{
    public partial class appiontmentManagement : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;

        public appiontmentManagement()
        {
            InitializeComponent();
            dataGridViewAppointment.SelectionChanged += dataGridViewAppointment_SelectionChanged;
            BtnReport.Click += BtnReport_Click;
        }
      

        private void ClearFields()
        {
            comboBoxPetient.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            dtpAppointment.Value = DateTime.Now;
            comboBoxDoctor.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            noteText.Clear();
            textBoxTotalCost.Clear();
            textBoxAmountPaid.Clear();
            comboBoxPaymentMethod.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = 0;

        }
        private void LoadAppointment()
        {
            try
            {
                var appointments = _dataAccess.GetAppointments();
                dataGridViewAppointment.DataSource = null;
                dataGridViewAppointment.DataSource = appointments;
                dataGridViewAppointment.Columns["patientI"].Visible = false;
                dataGridViewAppointment.Columns["doctorI"].Visible = false;
                dataGridViewAppointment.Columns["serviceI"].Visible = false;
                dataGridViewAppointment.Columns["appointmentI"].Visible = false;
                dataGridViewAppointment.DataSource = appointments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void LoadIntoComboBox()
        {
            comboBoxPetient.DataSource = _dataAccess.GetPatients();
            comboBoxPetient.DisplayMember = "FirstName";
            comboBoxPetient.ValueMember = "patientId";

            comboBoxDoctor.DataSource = _dataAccess.GetDoctors();
            comboBoxDoctor.DisplayMember = "FirstName";
            comboBoxDoctor.ValueMember = "doctorId";

            comboBoxService.DataSource = _dataAccess.GetServices();
            comboBoxService.DisplayMember = "serviceName";
            comboBoxService.ValueMember = "serviceId";
        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxService.SelectedValue is int serviceId)
            {
                LoadAvailableDoctorsByService(serviceId, dtpAppointment.Value);
            }
        }

        private void LoadAvailableDoctorsByService(int serviceId, DateTime selectedDate)
        {
            try
            {
                List<Doctors> availableDoctors = _dataAccess.GetAvailableDoctors(serviceId, selectedDate);

                if (availableDoctors == null || availableDoctors.Count == 0)
                {
                    MessageBox.Show("No doctors available for the selected service and date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxDoctor.DataSource = null;
                    return;
                }

                comboBoxDoctor.DataSource = availableDoctors;
                comboBoxDoctor.DisplayMember = "FirstName";
                comboBoxDoctor.ValueMember = "DoctorId";
                comboBoxDoctor.SelectedIndex = availableDoctors.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewAppointment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointment.SelectedRows[0];
                comboBoxPetient.SelectedValue = selectedRow.Cells["patientI"].Value ?? -1;
                comboBoxDoctor.SelectedValue = selectedRow.Cells["doctorI"].Value ?? -1;
                comboBoxService.SelectedValue = selectedRow.Cells["serviceI"].Value ?? -1;
                comboBoxStatus.Text = selectedRow.Cells["statu"].Value?.ToString() ?? "";
                noteText.Text = selectedRow.Cells["not"].Value?.ToString() ?? "";
                dtpAppointment.Value = selectedRow.Cells["appointmentDat"].Value != null ? Convert.ToDateTime(selectedRow.Cells["appointmentDat"].Value) : DateTime.Now;
                textBoxTotalCost.Text = selectedRow.Cells["totalCos"].Value?.ToString() ?? "";
                textBoxAmountPaid.Text = selectedRow.Cells["amountPai"].Value?.ToString() ?? "";
                comboBoxPaymentMethod.SelectedValue = selectedRow.Cells["paymentMetho"].Value ?? -1;
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxPetient.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxDoctor.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxService.SelectedItem == null)
            {
                MessageBox.Show("Please select a service.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAmountPaid.Text))
            {
                MessageBox.Show("Please enter the amount paid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTotalCost.Text))
            {
                MessageBox.Show("Please enter the total cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBoxPetient.SelectedValue?.ToString(), out int patientId))
            {
                MessageBox.Show("Invalid patient selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBoxDoctor.SelectedValue?.ToString(), out int doctorId))
            {
                MessageBox.Show("Invalid doctor selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBoxService.SelectedValue?.ToString(), out int serviceId))
            {
                MessageBox.Show("Invalid service selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxAmountPaid.Text, out decimal amountPaid))
            {
                MessageBox.Show("Invalid amount paid. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxTotalCost.Text, out decimal totalCost))
            {
                MessageBox.Show("Invalid total cost. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (totalCost > amountPaid)
            {
                MessageBox.Show("Total cost cannot be greater than the amount paid. Please enter a valid amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime appointmentDate = dtpAppointment.Value;
            string status = comboBoxStatus.SelectedItem.ToString();
            string note = noteText.Text;
            string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

            try
            {
                _dataAccess.InsertAppointment(patientId, doctorId, serviceId, appointmentDate, status, note, totalCost, amountPaid, paymentMethod);
                MessageBox.Show("Appointment and Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointment();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                int AppointmentId = Convert.ToInt32(dataGridViewAppointment.SelectedRows[0].Cells["AppointmentId"].Value);
                if (!int.TryParse(comboBoxPetient.SelectedValue?.ToString(), out int patientId))
                {
                    MessageBox.Show("Invalid patient selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(comboBoxDoctor.SelectedValue?.ToString(), out int doctorId))
                {
                    MessageBox.Show("Invalid doctor selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(comboBoxService.SelectedValue?.ToString(), out int serviceId))
                {
                    MessageBox.Show("Invalid service selection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textBoxAmountPaid.Text, out decimal amountPaid))
                {
                    MessageBox.Show("Invalid amount paid. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textBoxTotalCost.Text, out decimal totalPaid))
                {
                    MessageBox.Show("Invalid total cost. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxPaymentMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (totalPaid > amountPaid)
                {
                    MessageBox.Show("Total cost cannot be greater than the amount paid. Please enter a valid amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime appointmentDate = dtpAppointment.Value;
                string status = comboBoxStatus.SelectedItem.ToString();
                string note = noteText.Text;
                string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

                var appointment = new Appointment
                {
                    AppointmentId = AppointmentId,
                    PatientId = patientId,
                    ServiceId = serviceId,
                    DoctorId = doctorId,
                    AppointmentDate = appointmentDate,
                    Status = status,
                    Note = note,
                    TotalCost = totalPaid,
                    AmountPaid = amountPaid,
                    PaymentMethod = paymentMethod
                };

                try
                {
                    _dataAccess.UpdateAppointment(appointment);
                    _dataAccess.UpdatePayment(appointment);
                    MessageBox.Show("Appointment and Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointment();
                    ClearFields();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointment.SelectedRows[0].Cells["AppointmentI"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this AppointmentId?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dataAccess.DeleteAppointment(appointmentId);
                        MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointment();
                        ClearFields();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Appointment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string patientName = searchPatient.Text;
            SearchAppointments(patientName);
        }

        private void SearchAppointments(string patientName)
        {

            try
            {
                List<Appointment> appointments = _dataAccess.SearchAppointmentsByPatientName(patientName);
                dataGridViewAppointment.DataSource = null;
                dataGridViewAppointment.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appiontmentManagement_Load(object sender, EventArgs e)
        {
            LoadIntoComboBox();
            LoadAppointment();
            dtpAppointment.Value = DateTime.Now;
            ClearFields();
        }

        private void comboBoxService_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxService.SelectedValue is int serviceId)
            {
                var service = _dataAccess.GetServiceById(serviceId);
                if (service != null)
                {
                    comboBoxDoctor.SelectedValue = service.DoctorId;
                    textBoxTotalCost.Text = service.Price.ToString("F2");
                    LoadAvailableDoctorsByService(serviceId, dtpAppointment.Value);
                }
            }
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var Appointment = new Appointment
            //    {

            //    }
            //    _dataAccess.AdddAppointment(appiontment);

            //}catch(Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void LoadReport(int appointmentId)
        {
            try
            {
                DataTable appointmentData = GetAppointmentData(appointmentId);
                if (appointmentData.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the selected appointment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ReportDocument reportDoc = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "CrystalReport.rpt");
                reportDoc.Load(reportPath);
                reportDoc.SetDataSource(appointmentData);
                AppointmentReport reportForm = new AppointmentReport();

                // Show the report form
                reportForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetAppointmentData(int appointmentId)
        {
            DataTable dt = new DataTable();
            string query = @"
       SELECT a.appointmentId, p.firstName + ' ' + p.lastName AS PatientName, 
               d.firstName + ' ' + d.lastName AS DoctorName,
               s.ServiceName,
               a.appointmentDate, py.AmountPaid, py.TotalCost, 
               (py.AmountPaid - py.TotalCost) AS Change
        FROM Appointments a
        INNER JOIN Patients p ON a.patientId = p.patientId
        INNER JOIN Services s ON a.serviceId = s.serviceId
        INNER JOIN Doctors d ON a.doctorId = d.doctorId
        LEFT JOIN Payments py ON a.appointmentId = py.appointmentId
        WHERE a.appointmentId = @appointmentId";

            using (SqlConnection conn = new SqlConnection(connection.Conn("clinic_db")))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@appointmentId", appointmentId);
                da.Fill(dt);
            }

            return dt;
        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointment.SelectedRows[0].Cells["appointmentI"].Value);
                LoadReport(appointmentId);
                AppointmentReport apreport = new AppointmentReport();
                apreport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an appointment to generate the report.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        

    }
}

