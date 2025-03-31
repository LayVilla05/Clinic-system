namespace clinic
{
    partial class serviceManagerment
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
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewService = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.serviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(53, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Name";
            // 
            // serviceNameText
            // 
            this.serviceNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.serviceNameText.Location = new System.Drawing.Point(57, 231);
            this.serviceNameText.Name = "serviceNameText";
            this.serviceNameText.Size = new System.Drawing.Size(279, 29);
            this.serviceNameText.TabIndex = 2;
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.descriptionText.Location = new System.Drawing.Point(57, 305);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(279, 77);
            this.descriptionText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(53, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.priceText.Location = new System.Drawing.Point(57, 429);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(279, 29);
            this.priceText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(53, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(53, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Asign to doctor";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(57, 536);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(279, 32);
            this.comboBoxDoctor.TabIndex = 8;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AddBtn
            // 
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(57, 677);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(171, 46);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewService.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewService.ColumnHeadersHeight = 37;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceId,
            this.serviceName,
            this.description,
            this.price,
            this.doctorId});
            this.dataGridViewService.DataSource = this.servicesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewService.Location = new System.Drawing.Point(493, 154);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowTemplate.Height = 23;
            this.dataGridViewService.Size = new System.Drawing.Size(619, 389);
            this.dataGridViewService.TabIndex = 16;
            this.dataGridViewService.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewService.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewService.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewService.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewService.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewService.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewService.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewService.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewService.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewService.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewService.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewService.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewService.ThemeStyle.HeaderStyle.Height = 37;
            this.dataGridViewService.ThemeStyle.ReadOnly = true;
            this.dataGridViewService.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewService.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewService.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewService.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewService.ThemeStyle.RowsStyle.Height = 23;
            this.dataGridViewService.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewService.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(463, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Manage Service ";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(434, 677);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(171, 46);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(715, 677);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(171, 46);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // ClearBtn
            // 
            this.ClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(360, 536);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(101, 32);
            this.ClearBtn.TabIndex = 20;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.Black;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1048, 677);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(103, 46);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Location = new System.Drawing.Point(-8, -5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1172, 93);
            this.guna2Panel1.TabIndex = 22;
            // 
            // serviceId
            // 
            this.serviceId.DataPropertyName = "ServiceId";
            this.serviceId.HeaderText = "ServiceId";
            this.serviceId.Name = "serviceId";
            this.serviceId.ReadOnly = true;
            // 
            // serviceName
            // 
            this.serviceName.DataPropertyName = "ServiceName";
            this.serviceName.HeaderText = "ServiceName";
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "DoctorId";
            this.doctorId.HeaderText = "DoctorId";
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(clinic.Model.Services);
            // 
            // serviceManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 767);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceNameText);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "serviceManagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceManagerment";
            this.Load += new System.EventHandler(this.serviceManagerment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceNameText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewService;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
    }
}