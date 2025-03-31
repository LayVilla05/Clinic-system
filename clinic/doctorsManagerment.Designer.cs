namespace clinic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.specializationText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BtnAsign = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(554, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(58, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.firstNameText.Location = new System.Drawing.Point(62, 187);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(263, 29);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lastNameText.Location = new System.Drawing.Point(52, 296);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(263, 29);
            this.lastNameText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(48, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // specializationText
            // 
            this.specializationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.specializationText.Location = new System.Drawing.Point(52, 401);
            this.specializationText.Margin = new System.Windows.Forms.Padding(5);
            this.specializationText.Name = "specializationText";
            this.specializationText.Size = new System.Drawing.Size(263, 29);
            this.specializationText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(48, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specialization";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.phoneText.Location = new System.Drawing.Point(52, 516);
            this.phoneText.Margin = new System.Windows.Forms.Padding(5);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(263, 29);
            this.phoneText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(48, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Location = new System.Drawing.Point(10, 701);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 69);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Location = new System.Drawing.Point(137, 701);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 69);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(283, 701);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 69);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearBtn.Location = new System.Drawing.Point(213, 580);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(102, 38);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Black;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitBtn.Location = new System.Drawing.Point(445, 701);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(102, 69);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BtnAsign
            // 
            this.BtnAsign.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAsign.Location = new System.Drawing.Point(983, 110);
            this.BtnAsign.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAsign.Name = "BtnAsign";
            this.BtnAsign.Size = new System.Drawing.Size(205, 52);
            this.BtnAsign.TabIndex = 24;
            this.BtnAsign.Text = "Asign Time to Dcotor";
            this.BtnAsign.UseVisualStyleBackColor = false;
            this.BtnAsign.Click += new System.EventHandler(this.BtnAsign_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1452, 89);
            this.guna2Panel1.TabIndex = 25;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDoctors.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDoctors.ColumnHeadersHeight = 22;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorId,
            this.firstName,
            this.lastName,
            this.specialization,
            this.phone,
            this.startTime,
            this.endTime});
            this.dataGridViewDoctors.DataSource = this.doctorsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDoctors.Location = new System.Drawing.Point(388, 187);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersVisible = false;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(813, 431);
            this.dataGridViewDoctors.TabIndex = 26;
            this.dataGridViewDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDoctors.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridViewDoctors.ThemeStyle.ReadOnly = true;
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentClick_1);
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.HeaderText = "DoctorId";
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "FirstName";
            this.firstName.HeaderText = "FirstName";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "LastName";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // specialization
            // 
            this.specialization.DataPropertyName = "Specialization";
            this.specialization.HeaderText = "Specialization";
            this.specialization.Name = "specialization";
            this.specialization.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "StartTime";
            this.startTime.HeaderText = "StartTime";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "EndTime";
            this.endTime.HeaderText = "EndTime";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataSource = typeof(clinic.Model.Doctors);
            // 
            // doctorsManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 851);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BtnAsign);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.specializationText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "doctorsManagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.doctorsManagerment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BtnAsign;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDgv;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
    }
}