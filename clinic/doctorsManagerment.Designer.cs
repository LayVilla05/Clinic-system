﻿namespace clinic
{
    partial class doctorsManagerment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.specializationText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDgv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(835, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Managerment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(213, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstNameText.Location = new System.Drawing.Point(217, 212);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(263, 29);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lastNameText.Location = new System.Drawing.Point(527, 213);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(263, 29);
            this.lastNameText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(523, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // specializationText
            // 
            this.specializationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.specializationText.Location = new System.Drawing.Point(215, 312);
            this.specializationText.Margin = new System.Windows.Forms.Padding(5);
            this.specializationText.Name = "specializationText";
            this.specializationText.Size = new System.Drawing.Size(263, 29);
            this.specializationText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(211, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specialization";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.phoneText.Location = new System.Drawing.Point(527, 313);
            this.phoneText.Margin = new System.Windows.Forms.Padding(5);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(263, 29);
            this.phoneText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(523, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(213, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Available";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkAvailable.Location = new System.Drawing.Point(217, 423);
            this.chkAvailable.Margin = new System.Windows.Forms.Padding(5);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(123, 28);
            this.chkAvailable.TabIndex = 10;
            this.chkAvailable.Text = "Is Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AutoGenerateColumns = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorId,
            this.firstNameDgv,
            this.lastNameDgv,
            this.specializationDgv,
            this.phoneDgv,
            this.isAvailableDgv,
            this.StartDate,
            this.EndDate});
            this.dataGridViewDoctors.DataSource = this.doctorsBindingSource;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(831, 111);
            this.dataGridViewDoctors.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(742, 538);
            this.dataGridViewDoctors.TabIndex = 11;
            this.dataGridViewDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentClick);
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.addBtn.Location = new System.Drawing.Point(194, 825);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 69);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.updateBtn.Location = new System.Drawing.Point(321, 825);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 69);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.deleteBtn.Location = new System.Drawing.Point(478, 825);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 69);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.clearBtn.Location = new System.Drawing.Point(610, 825);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(102, 69);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ExitBtn.Location = new System.Drawing.Point(745, 825);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(102, 69);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(164, 917);
            this.guna2Panel1.TabIndex = 17;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.saveBtn.Location = new System.Drawing.Point(200, 655);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 69);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.HeaderText = "DoctorId";
            this.doctorId.Name = "doctorId";
            this.doctorId.Width = 85;
            // 
            // firstNameDgv
            // 
            this.firstNameDgv.DataPropertyName = "FirstName";
            this.firstNameDgv.HeaderText = "FirstName";
            this.firstNameDgv.Name = "firstNameDgv";
            this.firstNameDgv.Width = 120;
            // 
            // lastNameDgv
            // 
            this.lastNameDgv.DataPropertyName = "LastName";
            this.lastNameDgv.HeaderText = "LastName";
            this.lastNameDgv.Name = "lastNameDgv";
            this.lastNameDgv.Width = 120;
            // 
            // specializationDgv
            // 
            this.specializationDgv.DataPropertyName = "Specialization";
            this.specializationDgv.HeaderText = "Specialization";
            this.specializationDgv.Name = "specializationDgv";
            this.specializationDgv.Width = 150;
            // 
            // phoneDgv
            // 
            this.phoneDgv.DataPropertyName = "Phone";
            this.phoneDgv.HeaderText = "Phone";
            this.phoneDgv.Name = "phoneDgv";
            this.phoneDgv.Width = 150;
            // 
            // isAvailableDgv
            // 
            this.isAvailableDgv.DataPropertyName = "isAvailable";
            this.isAvailableDgv.HeaderText = "isAvailable";
            this.isAvailableDgv.Name = "isAvailableDgv";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataSource = typeof(clinic.Model.Doctors);
            // 
            // doctorsManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 917);
            this.ControlBox = false;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.specializationText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "doctorsManagerment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specializationText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvailableDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}