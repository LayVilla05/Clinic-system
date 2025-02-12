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
            this.DoctorBtn = new System.Windows.Forms.Button();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.AppiontmentBtn = new System.Windows.Forms.Button();
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.appiontmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelSidebar.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lblPatients.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appiontmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorBtn
            // 
            this.DoctorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.DoctorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DoctorBtn.ForeColor = System.Drawing.Color.White;
            this.DoctorBtn.Location = new System.Drawing.Point(0, 150);
            this.DoctorBtn.Name = "DoctorBtn";
            this.DoctorBtn.Size = new System.Drawing.Size(200, 50);
            this.DoctorBtn.TabIndex = 0;
            this.DoctorBtn.Text = "👨‍⚕️ Doctor";
            this.DoctorBtn.UseVisualStyleBackColor = false;
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PatientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PatientBtn.ForeColor = System.Drawing.Color.White;
            this.PatientBtn.Location = new System.Drawing.Point(0, 100);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(200, 50);
            this.PatientBtn.TabIndex = 1;
            this.PatientBtn.Text = "Patients";
            this.PatientBtn.UseVisualStyleBackColor = false;
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ServiceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ServiceBtn.ForeColor = System.Drawing.Color.White;
            this.ServiceBtn.Location = new System.Drawing.Point(0, 50);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(200, 50);
            this.ServiceBtn.TabIndex = 2;
            this.ServiceBtn.Text = "Services";
            this.ServiceBtn.UseVisualStyleBackColor = false;
            // 
            // AppiontmentBtn
            // 
            this.AppiontmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AppiontmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppiontmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AppiontmentBtn.ForeColor = System.Drawing.Color.White;
            this.AppiontmentBtn.Location = new System.Drawing.Point(0, 0);
            this.AppiontmentBtn.Name = "AppiontmentBtn";
            this.AppiontmentBtn.Size = new System.Drawing.Size(200, 50);
            this.AppiontmentBtn.TabIndex = 3;
            this.AppiontmentBtn.Text = " 📅 Appointment";
            this.AppiontmentBtn.UseVisualStyleBackColor = false;
            this.AppiontmentBtn.Click += new System.EventHandler(this.AppiontmentBtn_Click);
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelSidebar.Controls.Add(this.DoctorBtn);
            this.PanelSidebar.Controls.Add(this.PatientBtn);
            this.PanelSidebar.Controls.Add(this.ServiceBtn);
            this.PanelSidebar.Controls.Add(this.AppiontmentBtn);
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(200, 731);
            this.PanelSidebar.TabIndex = 4;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.PanelHeader.Controls.Add(this.groupBox1);
            this.PanelHeader.Controls.Add(this.lblPatients);
            this.PanelHeader.Controls.Add(this.groupBox2);
            this.PanelHeader.Controls.Add(this.groupBox3);
            this.PanelHeader.Controls.Add(this.lblTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.ForeColor = System.Drawing.Color.White;
            this.PanelHeader.Location = new System.Drawing.Point(200, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1021, 60);
            this.PanelHeader.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(426, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Appointment";
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblPatients.Controls.Add(this.label2);
            this.lblPatients.Controls.Add(this.label1);
            this.lblPatients.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPatients.Location = new System.Drawing.Point(598, 0);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(121, 60);
            this.lblPatients.TabIndex = 0;
            this.lblPatients.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Patient";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(719, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 60);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Active Doctor";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(849, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "300";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monthly Revenue ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Dashboard";
            // 
            // appiontmentBindingSource
            // 
            this.appiontmentBindingSource.DataSource = typeof(clinic.Model.Appiontment);
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(clinic.Model.Payment);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1221, 731);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelSidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = " Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelSidebar.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblPatients.ResumeLayout(false);
            this.lblPatients.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appiontmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoctorBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button ServiceBtn;
        private System.Windows.Forms.Button AppiontmentBtn;
        private System.Windows.Forms.Panel PanelSidebar;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox lblPatients;
        private System.Windows.Forms.BindingSource appiontmentBindingSource;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}