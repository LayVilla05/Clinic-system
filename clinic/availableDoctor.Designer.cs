namespace clinic
{
    partial class availableDoctor
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
            this.dayText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endTimeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.DvgAvailableDoctor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.availableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DvgAvailableDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAvailableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // dayText
            // 
            this.dayText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dayText.DefaultText = "";
            this.dayText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dayText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dayText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dayText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dayText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dayText.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dayText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dayText.Location = new System.Drawing.Point(326, 127);
            this.dayText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dayText.Name = "dayText";
            this.dayText.PasswordChar = '\0';
            this.dayText.PlaceholderText = "";
            this.dayText.SelectedText = "";
            this.dayText.Size = new System.Drawing.Size(171, 36);
            this.dayText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day";
            // 
            // startTimeText
            // 
            this.startTimeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startTimeText.DefaultText = "";
            this.startTimeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.startTimeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.startTimeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.startTimeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.startTimeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startTimeText.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.startTimeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.startTimeText.Location = new System.Drawing.Point(40, 221);
            this.startTimeText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.PasswordChar = '\0';
            this.startTimeText.PlaceholderText = "";
            this.startTimeText.SelectedText = "";
            this.startTimeText.Size = new System.Drawing.Size(178, 36);
            this.startTimeText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Time";
            // 
            // endTimeText
            // 
            this.endTimeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.endTimeText.DefaultText = "";
            this.endTimeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.endTimeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.endTimeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.endTimeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.endTimeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.endTimeText.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.endTimeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.endTimeText.Location = new System.Drawing.Point(326, 221);
            this.endTimeText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.PasswordChar = '\0';
            this.endTimeText.PlaceholderText = "";
            this.endTimeText.SelectedText = "";
            this.endTimeText.Size = new System.Drawing.Size(171, 36);
            this.endTimeText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Assign Date Time to Doctor";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.AutoRoundedCorners = true;
            this.comboBoxDoctor.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxDoctor.BorderRadius = 17;
            this.comboBoxDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxDoctor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.comboBoxDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxDoctor.ItemHeight = 30;
            this.comboBoxDoctor.Location = new System.Drawing.Point(40, 127);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(178, 36);
            this.comboBoxDoctor.TabIndex = 9;
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(20, 367);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(109, 57);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(179, 367);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(109, 57);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(346, 367);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(109, 57);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(526, 367);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(109, 57);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(526, 170);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(109, 37);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DvgAvailableDoctor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DvgAvailableDoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DvgAvailableDoctor.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DvgAvailableDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DvgAvailableDoctor.ColumnHeadersHeight = 26;
            this.DvgAvailableDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DvgAvailableDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availableId,
            this.doctorId,
            this.availableDay,
            this.startTime,
            this.endTime});
            this.DvgAvailableDoctor.DataSource = this.doctorAvailableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DvgAvailableDoctor.DefaultCellStyle = dataGridViewCellStyle3;
            this.DvgAvailableDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgAvailableDoctor.Location = new System.Drawing.Point(656, 55);
            this.DvgAvailableDoctor.Name = "DvgAvailableDoctor";
            this.DvgAvailableDoctor.RowHeadersVisible = false;
            this.DvgAvailableDoctor.Size = new System.Drawing.Size(515, 404);
            this.DvgAvailableDoctor.TabIndex = 15;
            this.DvgAvailableDoctor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgAvailableDoctor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DvgAvailableDoctor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DvgAvailableDoctor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DvgAvailableDoctor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DvgAvailableDoctor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DvgAvailableDoctor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DvgAvailableDoctor.ThemeStyle.HeaderStyle.Height = 26;
            this.DvgAvailableDoctor.ThemeStyle.ReadOnly = false;
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.Height = 22;
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgAvailableDoctor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DvgAvailableDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgAvailableDoctor_CellContentClick);
            // 
            // availableId
            // 
            this.availableId.DataPropertyName = "AvailableId";
            this.availableId.FillWeight = 85F;
            this.availableId.HeaderText = "Available Id";
            this.availableId.Name = "availableId";
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.FillWeight = 48.85786F;
            this.doctorId.HeaderText = "Doctor";
            this.doctorId.Name = "doctorId";
            // 
            // availableDay
            // 
            this.availableDay.DataPropertyName = "AvailableDay";
            this.availableDay.FillWeight = 48.85786F;
            this.availableDay.HeaderText = "Day";
            this.availableDay.Name = "availableDay";
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "StartTime";
            this.startTime.FillWeight = 48.85786F;
            this.startTime.HeaderText = "StartTime";
            this.startTime.Name = "startTime";
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "EndTime";
            this.endTime.FillWeight = 48.85786F;
            this.endTime.HeaderText = "EndTime";
            this.endTime.Name = "endTime";
            // 
            // doctorAvailableBindingSource
            // 
            this.doctorAvailableBindingSource.DataSource = typeof(clinic.Model.DoctorAvailable);
            // 
            // availableDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 487);
            this.Controls.Add(this.DvgAvailableDoctor);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endTimeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTimeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "availableDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "availableDoctor";
            this.Load += new System.EventHandler(this.availableDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgAvailableDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAvailableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox dayText;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox startTimeText;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox endTimeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxDoctor;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
        private Guna.UI2.WinForms.Guna2DataGridView DvgAvailableDoctor;
        private System.Windows.Forms.BindingSource doctorAvailableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
    }
}