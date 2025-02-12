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
    public partial class serviceManagerment : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        public serviceManagerment()
        {
            InitializeComponent();
            LoadDoctorsIntoComboBox();
            LoadServices();
            dataGridViewService.SelectionChanged += DataGridViewServices_SelectionChanged;
        }

        private void LoadDoctorsIntoComboBox()
        {
            try
            {
                List<Doctors> doctors = _dataAccess.GetDoctors();
                comboBoxDoctor.DataSource = doctors;
                comboBoxDoctor.DisplayMember = "FirstName"; 
                comboBoxDoctor.ValueMember = "DoctorId"; 
                comboBoxDoctor.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadServices()
        {
            try
            {
                List<Services> services = _dataAccess.GetServices();
                dataGridViewService.DataSource = null;
                dataGridViewService.DataSource = services;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void ClearFields()
        {
            serviceNameText.Clear();
            descriptionText.Clear();
            priceText.Clear();
            comboBoxDoctor.SelectedIndex = -1;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var service = new Services
            {
                ServiceName = serviceNameText.Text,
                Description = descriptionText.Text,
                Price = Convert.ToDecimal(priceText.Text),
                DoctorId = Convert.ToInt32(comboBoxDoctor.SelectedValue) 
            };

            try
            {
                _dataAccess.AddService(service);
                MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataGridViewServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewService.SelectedRows[0];
                serviceNameText.Text = selectedRow.Cells["serviceNameDgv"].Value?.ToString() ?? "";
                descriptionText.Text = selectedRow.Cells["descriptionDgv"].Value?.ToString() ?? "";
                priceText.Text = selectedRow.Cells["priceDgv"].Value?.ToString() ?? "";

                if (selectedRow.Cells["doctorIdDgv"].Value != null)
                {
                    comboBoxDoctor.SelectedValue = Convert.ToInt32(selectedRow.Cells["doctorIdDgv"].Value);
                }
                else
                {
                    comboBoxDoctor.SelectedIndex = -1;
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
            {
                int serviceId = Convert.ToInt32(dataGridViewService.SelectedRows[0].Cells["serviceIdDgv"].Value);

                var service = new Services
                {
                    ServiceId = serviceId,
                    ServiceName = serviceNameText.Text,
                    Description = descriptionText.Text,
                    Price = Convert.ToDecimal(priceText.Text),
                    DoctorId = Convert.ToInt32(comboBoxDoctor.SelectedValue)
                };

                try
                {
                    _dataAccess.UpdateService(service);
                    MessageBox.Show("Service updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a service to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
            {
                int serviceId = Convert.ToInt32(dataGridViewService.SelectedRows[0].Cells["serviceIdDgv"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _dataAccess.DeleteService(serviceId);
                        MessageBox.Show("Service deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadServices();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a service to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
