using System.Windows.Forms;

namespace clinic
{
    partial class appiontmentManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPetient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dataGridViewAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.search = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appiontmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appiontmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment Managerment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // comboBoxPetient
            // 
            this.comboBoxPetient.FormattingEnabled = true;
            this.comboBoxPetient.Location = new System.Drawing.Point(36, 155);
            this.comboBoxPetient.Name = "comboBoxPetient";
            this.comboBoxPetient.Size = new System.Drawing.Size(225, 32);
            this.comboBoxPetient.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Petient Name";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(35, 341);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(225, 32);
            this.comboBoxDoctor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Appiontment Date";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "dd/MM/yy hh:mm";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpAppointment.Location = new System.Drawing.Point(35, 678);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.ShowUpDown = true;
            this.dtpAppointment.Size = new System.Drawing.Size(226, 29);
            this.dtpAppointment.TabIndex = 11;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(36, 256);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(225, 32);
            this.comboBoxService.TabIndex = 12;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddBtn.Location = new System.Drawing.Point(72, 778);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(144, 46);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Green;
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateBtn.Location = new System.Drawing.Point(247, 778);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(144, 46);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(436, 778);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(144, 46);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(633, 778);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(144, 46);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(36, 526);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(225, 87);
            this.noteText.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Note";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(865, 778);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(144, 46);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.AllowUserToAddRows = false;
            this.dataGridViewAppointment.AllowUserToDeleteRows = false;
            this.dataGridViewAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAppointment.AutoGenerateColumns = false;
            this.dataGridViewAppointment.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAppointment.ColumnHeadersHeight = 26;
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentId,
            this.patientName,
            this.doctorName,
            this.serviceName,
            this.note,
            this.appointmentDate,
            this.PaymentMethod,
            this.AmountPaid,
            this.totalCost,
            this.patientId,
            this.doctorId,
            this.status,
            this.serviceId});
            this.dataGridViewAppointment.DataSource = this.appiontmentBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointment.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAppointment.Location = new System.Drawing.Point(586, 131);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.ReadOnly = true;
            this.dataGridViewAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAppointment.RowHeadersVisible = false;
            this.dataGridViewAppointment.RowTemplate.Height = 32;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(1013, 487);
            this.dataGridViewAppointment.TabIndex = 21;
            this.dataGridViewAppointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAppointment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAppointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAppointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAppointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAppointment.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridViewAppointment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAppointment.ThemeStyle.HeaderStyle.Height = 26;
            this.dataGridViewAppointment.ThemeStyle.ReadOnly = true;
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.Height = 32;
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAppointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1612, 80);
            this.guna2Panel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(540, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 37);
            this.label8.TabIndex = 23;
            this.label8.Text = "Manage Patients";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderRadius = 14;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(1149, 80);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search Patient";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(270, 43);
            this.guna2TextBox1.TabIndex = 23;
            // 
            // search
            // 
            this.search.Animated = true;
            this.search.BorderRadius = 14;
            this.search.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(1447, 80);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 43);
            this.search.TabIndex = 24;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Payment Method";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(316, 155);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(225, 32);
            this.comboBoxPaymentMethod.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Amount Paid";
            // 
            // textBoxAmountPaid
            // 
            this.textBoxAmountPaid.Location = new System.Drawing.Point(316, 259);
            this.textBoxAmountPaid.Name = "textBoxAmountPaid";
            this.textBoxAmountPaid.Size = new System.Drawing.Size(225, 29);
            this.textBoxAmountPaid.TabIndex = 28;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCost.Location = new System.Drawing.Point(316, 363);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(225, 22);
            this.textBoxTotalCost.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Paid";
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAppointment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSaveAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.Location = new System.Drawing.Point(292, 662);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(260, 45);
            this.btnSaveAppointment.TabIndex = 31;
            this.btnSaveAppointment.Text = "Save Appointment";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(36, 441);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(225, 32);
            this.comboBoxStatus.TabIndex = 32;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.HeaderText = "PaymentMethod";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            // 
            // AmountPaid
            // 
            this.AmountPaid.DataPropertyName = "AmountPaid";
            this.AmountPaid.HeaderText = "AmountPaid";
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            // 
            // totalCost
            // 
            this.totalCost.DataPropertyName = "TotalCost";
            this.totalCost.HeaderText = "Total ";
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            // 
            // appointmentId
            // 
            this.appointmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appointmentId.DataPropertyName = "AppointmentId";
            this.appointmentId.FillWeight = 99.8308F;
            this.appointmentId.HeaderText = "AppointmentId";
            this.appointmentId.Name = "appointmentId";
            this.appointmentId.ReadOnly = true;
            this.appointmentId.Width = 155;
            // 
            // patientName
            // 
            this.patientName.DataPropertyName = "PatientName";
            this.patientName.FillWeight = 99.8308F;
            this.patientName.HeaderText = "PatientName";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // doctorName
            // 
            this.doctorName.DataPropertyName = "DoctorName";
            this.doctorName.FillWeight = 99.8308F;
            this.doctorName.HeaderText = "DoctorName";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // serviceName
            // 
            this.serviceName.DataPropertyName = "ServiceName";
            this.serviceName.FillWeight = 99.8308F;
            this.serviceName.HeaderText = "ServiceName";
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            // 
            // note
            // 
            this.note.DataPropertyName = "Note";
            this.note.FillWeight = 99.8308F;
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // appointmentDate
            // 
            this.appointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appointmentDate.DataPropertyName = "AppointmentDate";
            this.appointmentDate.FillWeight = 101.5228F;
            this.appointmentDate.HeaderText = "AppointmentDate";
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.ReadOnly = true;
            this.appointmentDate.Width = 178;
            // 
            // patientId
            // 
            this.patientId.DataPropertyName = "PatientId";
            this.patientId.FillWeight = 99.8308F;
            this.patientId.HeaderText = "PatientId";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.FillWeight = 99.8308F;
            this.doctorId.HeaderText = "DoctorId";
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.FillWeight = 99.8308F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // serviceId
            // 
            this.serviceId.DataPropertyName = "ServiceId";
            this.serviceId.FillWeight = 99.8308F;
            this.serviceId.HeaderText = "ServiceId";
            this.serviceId.Name = "serviceId";
            this.serviceId.ReadOnly = true;
            // 
            // appiontmentBindingSource
            // 
            this.appiontmentBindingSource.DataSource = typeof(clinic.Model.Appiontment);
            // 
            // appiontmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1601, 886);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSaveAppointment);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAmountPaid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridViewAppointment);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPetient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "appiontmentManagement";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.appiontmentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appiontmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPetient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceIdDgv;
        private System.Windows.Forms.BindingSource appiontmentBindingSource;
        private System.Windows.Forms.Button ExitBtn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAppointment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button search;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Label label9;
        private ComboBox comboBoxPaymentMethod;
        private Label label10;
        private TextBox textBoxAmountPaid;
        private Label label11;
        public TextBox textBoxTotalCost;
        private Guna.UI2.WinForms.Guna2Button btnSaveAppointment;
        private ComboBox comboBoxStatus;
        private DataGridViewTextBoxColumn appointmentId;
        private DataGridViewTextBoxColumn patientName;
        private DataGridViewTextBoxColumn doctorName;
        private DataGridViewTextBoxColumn serviceName;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn appointmentDate;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn AmountPaid;
        private DataGridViewTextBoxColumn totalCost;
        private DataGridViewTextBoxColumn patientId;
        private DataGridViewTextBoxColumn doctorId;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn serviceId;
    }
}