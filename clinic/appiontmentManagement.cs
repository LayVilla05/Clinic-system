using clinic.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace clinic
{
    public partial class appiontmentManagement : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public appiontmentManagement()
        {
            InitializeComponent();
            LoadIntoComboBox();
            LoadAppointment();
            dataGridViewAppointment.SelectionChanged += dataGridViewAppointment_SelectionChanged;
        }


        private void ClearFields()
        {
            comboBoxPetient.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            dtpAppointment.Value = DateTime.Now;
            comboBoxDoctor.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            noteText.Clear();

        }
        private void LoadAppointment()
        {
            try
            {
                var appointments = _dataAccess.GetAppiontments();
                dataGridViewAppointment.DataSource = null;
                dataGridViewAppointment.DataSource = appointments;
                dataGridViewAppointment.Columns["patientId"].Visible = false;
                dataGridViewAppointment.Columns["doctorId"].Visible = false;
                dataGridViewAppointment.Columns["serviceId"].Visible = false;
                dataGridViewAppointment.Columns["appointmentId"].Visible = false;
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

            comboBoxPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Insurance" });
            comboBoxPaymentMethod.SelectedIndex = 0;

            comboBoxStatus.Items.AddRange(new object[] { "Checked In", "Completed", "Canceled", "Paid" });
            comboBoxStatus.SelectedIndex = 0;

        }
        //private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxService.SelectedValue is int serviceId)
        //    {
        //        LoadAvailableDoctorsByService(serviceId, dtpAppointment.Value);
        //    }

        //}

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
            if(dataGridViewAppointment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointment.SelectedRows[0];
                comboBoxPetient.SelectedValue = selectedRow.Cells["patientId"].Value ?? -1;
                comboBoxDoctor.SelectedValue = selectedRow.Cells["doctorId"].Value ?? -1;
                comboBoxService.SelectedValue = selectedRow.Cells["serviceId"].Value ?? -1;
                comboBoxStatus.Text = selectedRow.Cells["status"].Value?.ToString() ?? "";
                noteText.Text = selectedRow.Cells["note"].Value?.ToString() ?? "";
                dtpAppointment.Value = selectedRow.Cells["appointmentDate"].Value != null ? Convert.ToDateTime(selectedRow.Cells["appointmentDate"].Value) : DateTime.Now;
                textBoxTotalCost.Text = selectedRow.Cells["totalCost"].Value?.ToString() ?? "";
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Check if any required fields are null or empty
           

            // Debugging: Check if the values are correctly parsed
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


            DateTime appointmentDate = dtpAppointment.Value;
            string status = comboBoxStatus.SelectedItem.ToString();
            string note = noteText.Text;
            string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

            try
            {
                _dataAccess.InsertAppointment(patientId, doctorId, serviceId, appointmentDate, status, note, totalPaid, amountPaid, paymentMethod);
                // Process Payment
                int appointmentId = Convert.ToInt32(dataGridViewAppointment.SelectedRows[0].Cells["AppointmentId"].Value);
                _dataAccess.InsertPayment(appointmentId,amountPaid, totalPaid, paymentMethod);
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
                var appointment = new Appiontment
                {
                    AppointmentId = AppointmentId,
                    PatientId = Convert.ToInt32(comboBoxPetient.SelectedValue),
                    ServiceId = Convert.ToInt32(comboBoxService.SelectedValue),
                    DoctorId = Convert.ToInt32(comboBoxDoctor.SelectedValue),
                    AppointmentDate = dtpAppointment.Value,
                    Status = comboBoxService.Text,
                    Note = noteText.Text,

                };

                try
                {
                    _dataAccess.UpdateAppointment(appointment);
                    MessageBox.Show("Appiontment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadAppointment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a appointment to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointment.SelectedRows[0].Cells["AppointmentId"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this AppointmentId?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dataAccess.DeleteAppointment(appointmentId);
                        MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadAppointment();
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
           
        
                SearchAppointments(search.Text);

        }

        private void SearchAppointments(string searchText)
        {
            //using (SqlConnection conn = new SqlConnection(Connection.Conn("YourDB")))
            //{
            //    string query = "SELECT * FROM Appointments WHERE PatientName LIKE @search OR DoctorName LIKE @search";
            //    var data = conn.Query<DataModel>(query, new { search = "%" + searchText + "%" }).ToList();
            //    dgvAppointments.DataSource = data;
            //}
        }

        private void appiontmentManagement_Load(object sender, EventArgs e)
        {
            LoadIntoComboBox();
            dtpAppointment.Value = DateTime.Now;
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
    }
}
