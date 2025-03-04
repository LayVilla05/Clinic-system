using clinic.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class StaffManagerment : Form
    {
        private readonly DataAccess _dataAccess = new DataAccess();
       
        public StaffManagerment()
        {
            InitializeComponent();
            DgvStaff.SelectionChanged += DgvStaff_SelectionChanged;
            LoadStaff();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var staff = new Staff
            {
                Name = NameTexts.Text,
                Password = PassText.Text,
                Role = RoleCombo.Text,
                Image = ProfilePictureBox.Tag?.ToString()
            };

            try
            {
                _dataAccess.AddStaff(staff);
                MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProfilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    ProfilePictureBox.Tag = openFileDialog.FileName; 
                }
            }
        }
        private void LoadStaffImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                ProfilePictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                ProfilePictureBox.Image = null; 
            }
        }

        private void DgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvStaff.SelectedRows.Count > 0)
            {
                var selectedRow = DgvStaff.SelectedRows[0];
                NameTexts.Text = selectedRow.Cells["Name"].Value?.ToString() ?? "";
                PassText.Text = selectedRow.Cells["Password"].Value?.ToString() ?? "";
                RoleCombo.Text = selectedRow.Cells["Role"].Value?.ToString() ?? "";

                string imagePath = selectedRow.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    ProfilePictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    ProfilePictureBox.Image = Properties.Resources.defaultImage;
                }
            }
        }

        private void LoadStaff()
        {
            try
            {
                var staffList = _dataAccess.GetStaff();
                DgvStaff.DataSource = null;
                DgvStaff.DataSource = staffList;

                if (DgvStaff.Columns.Contains("Image"))
                {
                    DgvStaff.Columns["Image"].Visible = false;
                    DgvStaff.Columns["Id"].Visible = false;
                }

                if (!DgvStaff.Columns.Contains("Profile"))
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                    {
                        Name = "Profile",
                        HeaderText = "Profile",
                        ImageLayout = DataGridViewImageCellLayout.Zoom
                    };
                    DgvStaff.Columns.Add(imageColumn);
                }
                foreach (DataGridViewRow row in DgvStaff.Rows)
                {
                    string imagePath = row.Cells["Image"].Value?.ToString();
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        row.Cells["Profile"].Value = Image.FromFile(imagePath);
                    }
                    else
                    {
                        row.Cells["Profile"].Value = Properties.Resources.defaultImage; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Dashboard das = new Dashboard();
            das.Show();
            this.Hide();
        }

        

        private void StaffManagerment_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
