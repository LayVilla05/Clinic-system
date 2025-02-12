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

namespace clinic
{
    public partial class appiontmentManagement : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public appiontmentManagement()
        {
            InitializeComponent();
            LoadPetientIntoComboBox();
            LoadServiceIntoComboBox();
            LoadDoctorsIntoComboBox();
            LoadAppointment();
            dataGridViewAppointment.SelectionChanged += dataGridViewAppointment_SelectionChanged;
        }


        private void ClearFields()
        {
            comboBoxPetient.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
            dtpAppointment.Value = DateTime.Now;
            comboBoxDoctor.SelectedIndex = -1;
            statusText.Clear();
            noteText.Clear();

        }
        private void LoadAppointment()
        {
            try
            {
                var appointments = _dataAccess.GetAppiontments();
                dataGridViewAppointment.DataSource = null;
                dataGridViewAppointment.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appiontments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDoctorsIntoComboBox()
        {
            try
            {
                List<Doctors> doctors = _dataAccess.GetDoctors();
                comboBoxDoctor.DataSource = doctors;
                comboBoxDoctor.DisplayMember = "FirstName"; 
                //comboBoxDoctor.ValueMember = "DoctorName";
                comboBoxDoctor.Refresh();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPetientIntoComboBox()
        {
            try
            {
                List<Patients> patients = _dataAccess.GetPatients();
                comboBoxPetient.DataSource = patients;
                comboBoxPetient.DisplayMember = "FirstName";
                //comboBoxPetient.ValueMember = "PatientName";
                comboBoxPetient.Refresh();
              
            } catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadServiceIntoComboBox()
        {
            //try
            //{
            //    List<Services> services = _dataAccess.GetServices();
            //    comboBoxService.DataSource = services;
            //    comboBoxService.DisplayMember = "ServiceName";
            //    comboBoxService.ValueMember = "ServiceId";
            //    comboBoxService.SelectedIndex = -1;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            var services = _dataAccess.GetServices();
            comboBoxService.DataSource = services;
            comboBoxService.DisplayMember = "ServiceName";
            comboBoxService.ValueMember = "ServiceName";
            comboBoxService.Refresh();
        }
        private void dataGridViewAppointment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointment.SelectedRows[0];
                comboBoxPetient.SelectedItem = selectedRow.Cells["patientId"].Value?.ToString() ?? "";
                comboBoxDoctor.SelectedItem = selectedRow.Cells["doctorId"].Value?.ToString() ?? "";
                comboBoxService.SelectedItem = selectedRow.Cells["serviceId"].Value?.ToString() ?? "";
                statusText.Text = selectedRow.Cells["status"].Value?.ToString() ?? "";
                noteText.Text = selectedRow.Cells["note"].Value?.ToString() ?? "";
                dtpAppointment.Value = selectedRow.Cells["appointmentDate"].Value != null ? Convert.ToDateTime(selectedRow.Cells["appointmentDate"].Value) : DateTime.Now;

                if (selectedRow.Cells["patientId"].Value != null)
                {
                    comboBoxPetient.SelectedValue = selectedRow.Cells["patientId"].Value;
                }
                else
                {
                    comboBoxDoctor.SelectedIndex = -1;
                }
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxPetient.SelectedValue == null)
            {
                MessageBox.Show("Please select a Petient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var appiontment = new Appiontment
            {
                ServiceId = comboBoxService.SelectedIndex,
                PatientId = comboBoxPetient.SelectedIndex,
                DoctorId = comboBoxDoctor.TabIndex,
                AppointmentDate = dtpAppointment.Value,
                Status = statusText.Text,
                Note = noteText.Text,

            };

            try
            {
                _dataAccess.AdddAppointment(appiontment);
                MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadAppointment();
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
                    ServiceId = comboBoxService.SelectedIndex,
                    PatientId = comboBoxPetient.SelectedIndex,
                    DoctorId = comboBoxDoctor.TabIndex,
                    AppointmentDate = dtpAppointment.Value,
                    Status = statusText.Text,
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

       

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxService.SelectedValue is int serviceId)
            {
                var service = _dataAccess.GetServiceById(serviceId);
                if (service != null)
                {
                    comboBoxDoctor.SelectedValue = service.DoctorId;
                }
            }
        }

       
    }
}
