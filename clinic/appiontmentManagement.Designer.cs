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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
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
            this.searchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.search = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            this.appointmentI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMetho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(14, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // comboBoxPetient
            // 
            this.comboBoxPetient.FormattingEnabled = true;
            this.comboBoxPetient.Location = new System.Drawing.Point(18, 190);
            this.comboBoxPetient.Name = "comboBoxPetient";
            this.comboBoxPetient.Size = new System.Drawing.Size(225, 32);
            this.comboBoxPetient.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Petient Name";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(17, 376);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(225, 32);
            this.comboBoxDoctor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 664);
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
            this.dtpAppointment.Location = new System.Drawing.Point(17, 713);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.ShowUpDown = true;
            this.dtpAppointment.Size = new System.Drawing.Size(226, 29);
            this.dtpAppointment.TabIndex = 11;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(18, 291);
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
            this.ClearBtn.Location = new System.Drawing.Point(328, 696);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(144, 46);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(18, 561);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(225, 87);
            this.noteText.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Note";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(611, 778);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(144, 46);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.AllowUserToAddRows = false;
            this.dataGridViewAppointment.AllowUserToDeleteRows = false;
            this.dataGridViewAppointment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointment.AutoGenerateColumns = false;
            this.dataGridViewAppointment.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAppointment.ColumnHeadersHeight = 26;
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentI,
            this.patientI,
            this.doctorI,
            this.serviceI,
            this.patientNam,
            this.doctorNam,
            this.serviceNam,
            this.statu,
            this.not,
            this.appointmentDat,
            this.totalCos,
            this.amountPai,
            this.paymentMetho});
            this.dataGridViewAppointment.DataSource = this.appointmentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAppointment.Location = new System.Drawing.Point(564, 153);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.ReadOnly = true;
            this.dataGridViewAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAppointment.RowHeadersVisible = false;
            this.dataGridViewAppointment.RowTemplate.Height = 32;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(1013, 578);
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
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(604, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 37);
            this.label8.TabIndex = 23;
            this.label8.Text = "Manage Appoinment";
            // 
            // searchPatient
            // 
            this.searchPatient.Animated = true;
            this.searchPatient.BorderRadius = 14;
            this.searchPatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPatient.DefaultText = "";
            this.searchPatient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPatient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchPatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPatient.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.searchPatient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchPatient.Location = new System.Drawing.Point(30, 82);
            this.searchPatient.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.PasswordChar = '\0';
            this.searchPatient.PlaceholderText = "Search Patient";
            this.searchPatient.SelectedText = "";
            this.searchPatient.Size = new System.Drawing.Size(270, 43);
            this.searchPatient.TabIndex = 23;
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
            this.search.Location = new System.Drawing.Point(328, 82);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 43);
            this.search.TabIndex = 24;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Payment Method";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit card",
            "Bank"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(298, 190);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(225, 32);
            this.comboBoxPaymentMethod.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Amount Paid";
            // 
            // textBoxAmountPaid
            // 
            this.textBoxAmountPaid.Location = new System.Drawing.Point(298, 294);
            this.textBoxAmountPaid.Name = "textBoxAmountPaid";
            this.textBoxAmountPaid.Size = new System.Drawing.Size(225, 29);
            this.textBoxAmountPaid.TabIndex = 28;
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCost.Location = new System.Drawing.Point(298, 398);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(225, 22);
            this.textBoxTotalCost.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Paid";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Check In",
            "Pedding",
            "Paid"});
            this.comboBoxStatus.Location = new System.Drawing.Point(18, 476);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(225, 32);
            this.comboBoxStatus.TabIndex = 32;
            // 
            // BtnReport
            // 
            this.BtnReport.Animated = true;
            this.BtnReport.BorderRadius = 14;
            this.BtnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReport.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(1345, 94);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(110, 43);
            this.BtnReport.TabIndex = 33;
            this.BtnReport.Text = "Export";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // appointmentI
            // 
            this.appointmentI.DataPropertyName = "AppointmentId";
            this.appointmentI.HeaderText = "AppointmentId";
            this.appointmentI.Name = "appointmentI";
            this.appointmentI.ReadOnly = true;
            // 
            // patientI
            // 
            this.patientI.DataPropertyName = "PatientId";
            this.patientI.HeaderText = "PatientId";
            this.patientI.Name = "patientI";
            this.patientI.ReadOnly = true;
            // 
            // doctorI
            // 
            this.doctorI.DataPropertyName = "DoctorId";
            this.doctorI.HeaderText = "DoctorId";
            this.doctorI.Name = "doctorI";
            this.doctorI.ReadOnly = true;
            // 
            // serviceI
            // 
            this.serviceI.DataPropertyName = "ServiceId";
            this.serviceI.HeaderText = "ServiceId";
            this.serviceI.Name = "serviceI";
            this.serviceI.ReadOnly = true;
            // 
            // patientNam
            // 
            this.patientNam.DataPropertyName = "PatientName";
            this.patientNam.HeaderText = "PatientName";
            this.patientNam.Name = "patientNam";
            this.patientNam.ReadOnly = true;
            // 
            // doctorNam
            // 
            this.doctorNam.DataPropertyName = "DoctorName";
            this.doctorNam.HeaderText = "DoctorName";
            this.doctorNam.Name = "doctorNam";
            this.doctorNam.ReadOnly = true;
            // 
            // serviceNam
            // 
            this.serviceNam.DataPropertyName = "ServiceName";
            this.serviceNam.HeaderText = "ServiceName";
            this.serviceNam.Name = "serviceNam";
            this.serviceNam.ReadOnly = true;
            // 
            // statu
            // 
            this.statu.DataPropertyName = "Status";
            this.statu.HeaderText = "Status";
            this.statu.Name = "statu";
            this.statu.ReadOnly = true;
            // 
            // not
            // 
            this.not.DataPropertyName = "Note";
            this.not.HeaderText = "Note";
            this.not.Name = "not";
            this.not.ReadOnly = true;
            // 
            // appointmentDat
            // 
            this.appointmentDat.DataPropertyName = "AppointmentDate";
            this.appointmentDat.HeaderText = "AppointmentDate";
            this.appointmentDat.Name = "appointmentDat";
            this.appointmentDat.ReadOnly = true;
            // 
            // totalCos
            // 
            this.totalCos.DataPropertyName = "TotalCost";
            this.totalCos.HeaderText = "TotalCost";
            this.totalCos.Name = "totalCos";
            this.totalCos.ReadOnly = true;
            // 
            // amountPai
            // 
            this.amountPai.DataPropertyName = "AmountPaid";
            this.amountPai.HeaderText = "AmountPaid";
            this.amountPai.Name = "amountPai";
            this.amountPai.ReadOnly = true;
            // 
            // paymentMetho
            // 
            this.paymentMetho.DataPropertyName = "PaymentMethod";
            this.paymentMetho.HeaderText = "PaymentMethod";
            this.paymentMetho.Name = "paymentMetho";
            this.paymentMetho.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(clinic.Model.Appointment);
            // 
            // appiontmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1601, 886);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAmountPaid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchPatient);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.appiontmentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
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
        private System.Windows.Forms.Button ExitBtn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAppointment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox searchPatient;
        private Guna.UI2.WinForms.Guna2Button search;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Label label9;
        private ComboBox comboBoxPaymentMethod;
        private Label label10;
        private TextBox textBoxAmountPaid;
        private Label label11;
        public TextBox textBoxTotalCost;
        private ComboBox comboBoxStatus;
        private DataGridViewTextBoxColumn appointmentId;
        private DataGridViewTextBoxColumn patientId;
        private DataGridViewTextBoxColumn doctorId;
        private DataGridViewTextBoxColumn serviceId;
        private DataGridViewTextBoxColumn patientName;
        private DataGridViewTextBoxColumn doctorName;
        private DataGridViewTextBoxColumn serviceName;
        private DataGridViewTextBoxColumn appointmentDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn paymentMethod;
        private DataGridViewTextBoxColumn amountPaid;
        private DataGridViewTextBoxColumn totalCost;
        private BindingSource appointmentBindingSource;
        private DataGridViewTextBoxColumn appointmentI;
        private DataGridViewTextBoxColumn patientI;
        private DataGridViewTextBoxColumn doctorI;
        private DataGridViewTextBoxColumn serviceI;
        private DataGridViewTextBoxColumn patientNam;
        private DataGridViewTextBoxColumn doctorNam;
        private DataGridViewTextBoxColumn serviceNam;
        private DataGridViewTextBoxColumn statu;
        private DataGridViewTextBoxColumn not;
        private DataGridViewTextBoxColumn appointmentDat;
        private DataGridViewTextBoxColumn totalCos;
        private DataGridViewTextBoxColumn amountPai;
        private DataGridViewTextBoxColumn paymentMetho;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
    }
}