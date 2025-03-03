﻿using clinic.Model;
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
                isAvailable = chkAvailable.Checked,
                StartDate = TimeSpan.Parse(txtStartDate.Text),
                EndDate = TimeSpan.Parse(txtEndDate.Text)
            };

            try
            {
                _dataAccess.AddDoctor(doctor);
                MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDoctors();
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
                    isAvailable = chkAvailable.Checked
                };

                try
                {
                    _dataAccess.UpdateDoctor(doctor);
                    MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadDoctors();
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
                        ClearFields();
                        LoadDoctors();
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

        private void LoadDoctors()
        {
            try
            {
                List<Doctors> doctors = _dataAccess.GetDoctors();
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
                firstNameText.Text = selectedRow.Cells["firstNameDgv"].Value?.ToString();
                lastNameText.Text = selectedRow.Cells["lastNameDgv"].Value?.ToString();
                specializationText.Text = selectedRow.Cells["specializationDgv"].Value?.ToString() ?? "";
                phoneText.Text = selectedRow.Cells["phoneDgv"].Value?.ToString() ?? "";
                chkAvailable.Checked = Convert.ToBoolean(selectedRow.Cells["isAvailableDgv"].Value ?? false);
                txtStartDate.Text = selectedRow.Cells["StartDate"].Value?.ToString();
                txtEndDate.Text = selectedRow.Cells["EndDate"].Value?.ToString();


            }
        }
      

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
            chkAvailable.Checked = false;
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



        //private void saveBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int doctorId = Convert.ToInt32(txtDoctorId.Text);
        //        bool isAvailable = chkAvailable.Checked;
        //        string availableDay = cmbAvailableDay.SelectedItem?.ToString() ?? "";
        //        TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
        //        TimeSpan endTime = dtpEndTime.Value.TimeOfDay;



        //        MessageBox.Show("Doctor availability updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadDoctors(); // Refresh DataGridView
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void LoadDoctorsByTime()
        //{
        //    try
        //    {
        //        string today = DateTime.Now.DayOfWeek.ToString();
        //        TimeSpan currentTime = DateTime.Now.TimeOfDay;  

        //        var doctorsAtThisTime = _dataAccess.GetDoctorsByTime(today, currentTime);

        //        comboBoxDoctor.DataSource = doctorsAtThisTime;
        //        comboBoxDoctor.DisplayMember = "FirstName";
        //        comboBoxDoctor.ValueMember = "DoctorId";
        //        comboBoxDoctor.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading doctors by time: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }

}
