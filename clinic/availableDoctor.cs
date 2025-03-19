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
    public partial class availableDoctor : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess() ;
        public availableDoctor()
        {
            InitializeComponent();
        }
        private void availableDoctor_Load(object sender, EventArgs e)
        {
            LoadDoctorsIntoComboBox();
            LoadAvailable();
            DvgAvailableDoctor.SelectionChanged += DvgAvailableDoctor_SelectionChanged;
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

        private void LoadAvailable()
        {
            try
            {
                var availableDoctors = _dataAccess.GetAvailableDoctors();
                DvgAvailableDoctor.DataSource = availableDoctors;
                DvgAvailableDoctor.Columns["AvailableId"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            dayText.Text = "";
            startTimeText.Text = "";
            endTimeText.Text = "";
            comboBoxDoctor.Text = "";

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var doctorAvailabel = new DoctorAvailable
            {
                DoctorId = Convert.ToInt32(comboBoxDoctor.SelectedValue),
                AvailableDay = dayText.Text,
                StartTime = TimeSpan.Parse(startTimeText.Text),
                EndTime = TimeSpan.Parse(endTimeText.Text)
            };
            try
            {
                _dataAccess.AddAvailable(doctorAvailabel);
                MessageBox.Show("added success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAvailable();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (DvgAvailableDoctor.SelectedRows.Count > 0)
            {
                int AvailableDoctorId = Convert.ToInt32(DvgAvailableDoctor.SelectedRows[0].Cells["availableId"].Value);
                var doctorAvailable = new DoctorAvailable 
                {
                    AvailableId = AvailableDoctorId,
                    AvailableDay = dayText.Text,
                    DoctorId = Convert.ToInt32(comboBoxDoctor.SelectedValue),
                    StartTime = TimeSpan.Parse(startTimeText.Text),
                    EndTime = TimeSpan.Parse(endTimeText.Text)
                };

                try
                {
                    _dataAccess.UpdateAvailable(doctorAvailable);
                    MessageBox.Show(" updated Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadAvailable();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DvgAvailableDoctor.SelectedRows.Count > 0)
            {
                int availableId = Convert.ToInt32(DvgAvailableDoctor.SelectedRows[0].Cells["availableId"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this Id?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {

                    try
                    {
                        _dataAccess.DeleteAvailable(availableId);
                        MessageBox.Show(" Deleted Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                LoadAvailable();
            }
            else
            {
                MessageBox.Show("Please select  to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DvgAvailableDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DvgAvailableDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if (DvgAvailableDoctor.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DvgAvailableDoctor.SelectedRows[0];

                comboBoxDoctor.SelectedValue = Convert.ToInt32(row.Cells["DoctorId"].Value);
                dayText.Text = row.Cells["AvailableDay"].Value.ToString();
                startTimeText.Text = TimeSpan.Parse(row.Cells["StartTime"].Value.ToString()).ToString(@"hh\:mm");
                endTimeText.Text = TimeSpan.Parse(row.Cells["EndTime"].Value.ToString()).ToString(@"hh\:mm");
            }
        }
    }
}
