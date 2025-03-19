using clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class doctorsManagerment : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public doctorsManagerment()
        {
            InitializeComponent();
            LoadDoctors();
            LoadDoctorsAvailable();
            dataGridViewDoctors.SelectionChanged += DataGridViewDoctors_SelectionChanged;
        }

       
        private void addBtn_Click(object sender, EventArgs e)
        {
            var doctor = new Doctors
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Specialization = specializationText.Text,
                Phone = phoneText.Text,
            };

            try
            {
                _dataAccess.AddDoctor(doctor);
                MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dataGridViewDoctors.SelectedRows[0].Cells["DoctorId"].Value);
                var doctor = new Doctors
                {
                    DoctorId = doctorId,
                    FirstName = firstNameText.Text,
                    LastName = lastNameText.Text,
                    Specialization = specializationText.Text,
                    Phone = phoneText.Text,
             
                };

                try
                {
                    _dataAccess.UpdateDoctor(doctor);
                    MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDoctors();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dataGridViewDoctors.SelectedRows[0].Cells["DoctorId"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dataAccess.DeleteDoctor(doctorId);
                        MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoctors();
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
                MessageBox.Show("Please select a doctor to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void LoadDoctorsAvailable()
        {
            try
            {
                string query = @"
                    SELECT d.doctorID, d.firstName, d.lastName, d.specialization, d.phone, 
                           da.startTime, da.endTime
                    FROM doctors d
                    LEFT JOIN doctor_availability da ON d.doctorID = da.doctorID";
                List<DoctorAvailable> doctorAvailables = _dataAccess.GetDoctorsWithAvailability(query);
                dataGridViewDoctors.DataSource = null;
                dataGridViewDoctors.DataSource = doctorAvailables;
                dataGridViewDoctors.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                List<Doctors> doctors = _dataAccess.GetDoctors();
                foreach (var doc in doctors)
                {
                    Console.WriteLine($"Doctor: {doc.FirstName} {doc.LastName} - StartTime: {doc.StartTime}, EndTime: {doc.EndTime}");
                }

                dataGridViewDoctors.DataSource = doctors;
                dataGridViewDoctors.DataSource = null;
                dataGridViewDoctors.DataSource = doctors;
                dataGridViewDoctors.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {                
                var selectedRow = dataGridViewDoctors.SelectedRows[0];
                firstNameText.Text = selectedRow.Cells["firstName"].Value?.ToString();
                lastNameText.Text = selectedRow.Cells["lastName"].Value?.ToString();
                specializationText.Text = selectedRow.Cells["specialization"].Value?.ToString() ?? "";
                phoneText.Text = selectedRow.Cells["phone"].Value?.ToString() ?? "";
            }
        }
        //private void ManageDoctor_Load(object sender, EventArgs e)
        //{
        //    dataGridViewDoctors.AutoGenerateColumns = false;
        //    dataGridViewDoctors.Columns.Clear();

        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "DoctorId", DataPropertyName = "doctorID", HeaderText = "ID" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "FirstName", DataPropertyName = "firstName", HeaderText = "First Name" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "LastName", DataPropertyName = "lastName", HeaderText = "Last Name" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "Specialization", DataPropertyName = "specialization", HeaderText = "Specialization" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "Phone", DataPropertyName = "phone", HeaderText = "Phone" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "StartTime", DataPropertyName = "StartTime", HeaderText = "Start Time" });
        //    dataGridViewDoctors.Columns.Add(new DataGridViewTextBoxColumn { Name = "EndTime", DataPropertyName = "EndTime", HeaderText = "End Time" });

        //    LoadDoctors();
        
        //}


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            firstNameText.Clear();
            lastNameText.Clear();
            specializationText.Clear();
            phoneText.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Dashboard das = new Dashboard();
            das.Show();
            this.Hide();

        }

        private void dataGridViewDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAsign_Click(object sender, EventArgs e)
        {
            availableDoctor ad = new availableDoctor();
            ad.ShowDialog();
        }
    }

}
