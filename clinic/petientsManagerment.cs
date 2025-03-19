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
    public partial class petientsManagerment : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public petientsManagerment()
        {
            InitializeComponent();
            LoadPatients();
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;
            ClearFields();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadPatients();
            ClearFields();
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;

        }
        private void LoadPatients()
        {

            try
            {
                List<Patients> patients = _dataAccess.GetPatients();
                dataGridViewPatients.DataSource = null;
                dataGridViewPatients.DataSource = patients;
                dataGridViewPatients.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void DataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPatients.SelectedRows[0];
                firstNameText.Text = selectedRow.Cells["firstNameDgv"].Value?.ToString();
                lastNameText.Text = selectedRow.Cells["lastNameDgv"].Value?.ToString();
                ageText.Text = selectedRow.Cells["ageDgv"].Value != null ? selectedRow.Cells["ageDgv"].Value.ToString() : "";
                cmbGender.SelectedItem = selectedRow.Cells["genderDgv"].Value?.ToString();
                phoneText.Text = selectedRow.Cells["phoneDgv"].Value?.ToString();
                addressText.Text = selectedRow.Cells["addressDgv"].Value?.ToString();
            }
        }
        private void ClearFields()
        {
            firstNameText.Clear();
            lastNameText.Clear();
            ageText.Clear();
            cmbGender.SelectedIndex = -1;
            phoneText.Clear();
            addressText.Clear();
            searchText.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var patient = new Patients
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = int.Parse(ageText.Text),
                Gender = cmbGender.SelectedItem.ToString(),
                Phone = phoneText.Text,
                Address = addressText.Text
            };

            try
            {
                _dataAccess.AddPatient(patient);
                MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["patientIdDgv"].Value);
                var patient = new Patients
                {
                    PatientId = patientId,
                    FirstName = firstNameText.Text,
                    LastName = lastNameText.Text,
                    Age = int.Parse(ageText.Text),
                    Gender = cmbGender.SelectedItem.ToString(),
                    Phone = phoneText.Text,
                    Address = addressText.Text
                };

                try
                {
                    _dataAccess.UpdatePatient(patient);
                    MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPatients();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Please select a patient to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["patientIdDgv"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dataAccess.DeletePatient(patientId);
                        MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatients();
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
                MessageBox.Show("Please select a patient to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LoadPatients();
            ClearFields();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dashboard das = new Dashboard();
            das.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SearchPatients(searchText.Text);
        }
        private void SearchPatients(string searchQuery)
        {
            try
            {
                string query = @"
            SELECT
                patientID,
                firstName,
                lastName,
                gender,
                age,
                phone,
                address
            FROM
                patients
            WHERE
                firstName LIKE @searchQuery OR
                lastName LIKE @searchQuery OR
                CAST(patientID AS VARCHAR) LIKE @searchQuery;";

                var parameters = new Dictionary<string, object>
        {
            { "@searchQuery", "%" + searchQuery + "%" } // Add wildcards
        };

                DataTable dataTable = _dataAccess.GetDataTable(query, parameters);
                dataGridViewPatients.DataSource = dataTable;
                dataGridViewPatients.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
