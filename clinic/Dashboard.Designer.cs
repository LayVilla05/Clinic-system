using System.Windows.Forms.DataVisualization.Charting;

namespace clinic
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.totalRevenueText = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalDoctorText = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPatientsText = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.BtnServices = new Guna.UI2.WinForms.Guna2Button();
            this.BtnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.AutoSize = true;
            this.PanelSidebar.BackColor = System.Drawing.Color.DarkGreen;
            this.PanelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(4, 767);
            this.PanelSidebar.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 24;
            this.guna2Elipse1.TargetControl = this.guna2Panel2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.totalRevenueText);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.totalDoctorText);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.totalPatientsText);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(193, 142);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1073, 391);
            this.guna2Panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(866, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Revenue";
            // 
            // totalRevenueText
            // 
            this.totalRevenueText.AutoSize = true;
            this.totalRevenueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.totalRevenueText.Location = new System.Drawing.Point(866, 172);
            this.totalRevenueText.Name = "totalRevenueText";
            this.totalRevenueText.Size = new System.Drawing.Size(35, 37);
            this.totalRevenueText.TabIndex = 7;
            this.totalRevenueText.Text = "9";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BorderRadius = 14;
            this.guna2PictureBox3.Image = global::clinic.Properties.Resources.interest_18233805;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(760, 150);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(87, 89);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(484, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Doctor";
            // 
            // totalDoctorText
            // 
            this.totalDoctorText.AutoSize = true;
            this.totalDoctorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.totalDoctorText.Location = new System.Drawing.Point(484, 172);
            this.totalDoctorText.Name = "totalDoctorText";
            this.totalDoctorText.Size = new System.Drawing.Size(35, 37);
            this.totalDoctorText.TabIndex = 4;
            this.totalDoctorText.Text = "9";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 14;
            this.guna2PictureBox2.Image = global::clinic.Properties.Resources.doctor_8997069;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(378, 150);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(87, 89);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(141, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients";
            // 
            // totalPatientsText
            // 
            this.totalPatientsText.AutoSize = true;
            this.totalPatientsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.totalPatientsText.Location = new System.Drawing.Point(141, 172);
            this.totalPatientsText.Name = "totalPatientsText";
            this.totalPatientsText.Size = new System.Drawing.Size(35, 37);
            this.totalPatientsText.TabIndex = 1;
            this.totalPatientsText.Text = "9";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 14;
            this.guna2PictureBox1.Image = global::clinic.Properties.Resources.man_14678295;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(35, 150);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 89);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 100);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 23);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(0, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 23);
            this.metroTile2.TabIndex = 0;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(0, 0);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(75, 23);
            this.metroTile3.TabIndex = 0;
            this.metroTile3.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(300, 300);
            this.chart.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Location = new System.Drawing.Point(21, 683);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10);
            this.logoutBtn.Size = new System.Drawing.Size(163, 50);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::clinic.Properties.Resources.logo_2078018_640;
            this.guna2CirclePictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(27, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(145, 136);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.logoutBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2Panel1.Size = new System.Drawing.Size(187, 785);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel3.Location = new System.Drawing.Point(178, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1088, 104);
            this.guna2Panel3.TabIndex = 8;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(430, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 40);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Dashboard";
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.Animated = true;
            this.BtnAppointment.BorderRadius = 12;
            this.BtnAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAppointment.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnAppointment.Location = new System.Drawing.Point(193, 591);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(196, 56);
            this.BtnAppointment.TabIndex = 9;
            this.BtnAppointment.Text = "Appointment";
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.Animated = true;
            this.BtnDoctor.BorderRadius = 12;
            this.BtnDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDoctor.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnDoctor.ForeColor = System.Drawing.Color.White;
            this.BtnDoctor.Location = new System.Drawing.Point(837, 591);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(194, 56);
            this.BtnDoctor.TabIndex = 10;
            this.BtnDoctor.Text = "Doctor";
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnPatients
            // 
            this.BtnPatients.Animated = true;
            this.BtnPatients.BorderRadius = 12;
            this.BtnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPatients.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnPatients.ForeColor = System.Drawing.Color.White;
            this.BtnPatients.Location = new System.Drawing.Point(409, 591);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(183, 56);
            this.BtnPatients.TabIndex = 11;
            this.BtnPatients.Text = "Patients";
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // BtnServices
            // 
            this.BtnServices.Animated = true;
            this.BtnServices.BorderRadius = 12;
            this.BtnServices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnServices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnServices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnServices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnServices.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnServices.ForeColor = System.Drawing.Color.White;
            this.BtnServices.Location = new System.Drawing.Point(623, 591);
            this.BtnServices.Name = "BtnServices";
            this.BtnServices.Size = new System.Drawing.Size(171, 56);
            this.BtnServices.TabIndex = 12;
            this.BtnServices.Text = "Services";
            this.BtnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // BtnStaff
            // 
            this.BtnStaff.Animated = true;
            this.BtnStaff.BackColor = System.Drawing.Color.Transparent;
            this.BtnStaff.BorderRadius = 12;
            this.BtnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStaff.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.BtnStaff.ForeColor = System.Drawing.Color.White;
            this.BtnStaff.Location = new System.Drawing.Point(1080, 591);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(163, 58);
            this.BtnStaff.TabIndex = 13;
            this.BtnStaff.Text = "Staff";
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1246, 767);
            this.Controls.Add(this.BtnStaff);
            this.Controls.Add(this.BtnServices);
            this.Controls.Add(this.BtnPatients);
            this.Controls.Add(this.BtnDoctor);
            this.Controls.Add(this.BtnAppointment);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PanelSidebar);
            this.Controls.Add(this.guna2Panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelSidebar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPatientsText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalRevenueText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalDoctorText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button logoutBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnAppointment;
        private Guna.UI2.WinForms.Guna2Button BtnDoctor;
        private Guna.UI2.WinForms.Guna2Button BtnPatients;
        private Guna.UI2.WinForms.Guna2Button BtnServices;
        private Guna.UI2.WinForms.Guna2Button BtnStaff;
    }
}