
namespace EmployeeManagementApp
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.empHomeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.empDeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.empEditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.empAddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpGenderCB = new System.Windows.Forms.ComboBox();
            this.empGender = new System.Windows.Forms.TextBox();
            this.EmpEduCB = new System.Windows.Forms.ComboBox();
            this.empEducation = new System.Windows.Forms.TextBox();
            this.empPhone = new System.Windows.Forms.TextBox();
            this.empDOB = new System.Windows.Forms.TextBox();
            this.EmpDobDateTime = new System.Windows.Forms.DateTimePicker();
            this.EmpPositionCB = new System.Windows.Forms.ComboBox();
            this.empPosition = new System.Windows.Forms.TextBox();
            this.EmpPhoneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.empAddress = new System.Windows.Forms.TextBox();
            this.EmpAddressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.empId = new System.Windows.Forms.TextBox();
            this.EmpIdTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.homeTitle = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpView);
            this.panel1.Controls.Add(this.empHomeBtn);
            this.panel1.Controls.Add(this.empDeleteBtn);
            this.panel1.Controls.Add(this.empEditBtn);
            this.panel1.Controls.Add(this.empAddBtn);
            this.panel1.Controls.Add(this.EmpGenderCB);
            this.panel1.Controls.Add(this.empGender);
            this.panel1.Controls.Add(this.EmpEduCB);
            this.panel1.Controls.Add(this.empEducation);
            this.panel1.Controls.Add(this.empPhone);
            this.panel1.Controls.Add(this.empDOB);
            this.panel1.Controls.Add(this.EmpDobDateTime);
            this.panel1.Controls.Add(this.EmpPositionCB);
            this.panel1.Controls.Add(this.empPosition);
            this.panel1.Controls.Add(this.EmpPhoneTB);
            this.panel1.Controls.Add(this.empAddress);
            this.panel1.Controls.Add(this.EmpAddressTB);
            this.panel1.Controls.Add(this.empName);
            this.panel1.Controls.Add(this.EmpNameTB);
            this.panel1.Controls.Add(this.empId);
            this.panel1.Controls.Add(this.EmpIdTB);
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 544);
            this.panel1.TabIndex = 0;
            // 
            // EmpView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.EmpView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmpView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpView.BackgroundColor = System.Drawing.Color.White;
            this.EmpView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.EmpView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpView.DefaultCellStyle = dataGridViewCellStyle6;
            this.EmpView.EnableHeadersVisualStyles = false;
            this.EmpView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpView.Location = new System.Drawing.Point(679, 43);
            this.EmpView.Name = "EmpView";
            this.EmpView.ReadOnly = true;
            this.EmpView.RowHeadersVisible = false;
            this.EmpView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpView.Size = new System.Drawing.Size(698, 446);
            this.EmpView.TabIndex = 34;
            this.EmpView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.EmpView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpView.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpView.ThemeStyle.ReadOnly = true;
            this.EmpView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpView.ThemeStyle.RowsStyle.Height = 22;
            this.EmpView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.EmpView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpView_CellContentClick);
            // 
            // empHomeBtn
            // 
            this.empHomeBtn.ActiveBorderThickness = 1;
            this.empHomeBtn.ActiveCornerRadius = 20;
            this.empHomeBtn.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.empHomeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.empHomeBtn.ActiveLineColor = System.Drawing.Color.White;
            this.empHomeBtn.BackColor = System.Drawing.Color.White;
            this.empHomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empHomeBtn.BackgroundImage")));
            this.empHomeBtn.ButtonText = "Home";
            this.empHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empHomeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empHomeBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.empHomeBtn.IdleBorderThickness = 1;
            this.empHomeBtn.IdleCornerRadius = 20;
            this.empHomeBtn.IdleFillColor = System.Drawing.Color.White;
            this.empHomeBtn.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.empHomeBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.empHomeBtn.Location = new System.Drawing.Point(201, 498);
            this.empHomeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empHomeBtn.Name = "empHomeBtn";
            this.empHomeBtn.Size = new System.Drawing.Size(136, 41);
            this.empHomeBtn.TabIndex = 33;
            this.empHomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empDeleteBtn
            // 
            this.empDeleteBtn.ActiveBorderThickness = 1;
            this.empDeleteBtn.ActiveCornerRadius = 20;
            this.empDeleteBtn.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.empDeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.empDeleteBtn.ActiveLineColor = System.Drawing.Color.White;
            this.empDeleteBtn.BackColor = System.Drawing.Color.White;
            this.empDeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empDeleteBtn.BackgroundImage")));
            this.empDeleteBtn.ButtonText = "Delete";
            this.empDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDeleteBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.empDeleteBtn.IdleBorderThickness = 1;
            this.empDeleteBtn.IdleCornerRadius = 20;
            this.empDeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.empDeleteBtn.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.empDeleteBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.empDeleteBtn.Location = new System.Drawing.Point(357, 448);
            this.empDeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empDeleteBtn.Name = "empDeleteBtn";
            this.empDeleteBtn.Size = new System.Drawing.Size(136, 41);
            this.empDeleteBtn.TabIndex = 32;
            this.empDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empDeleteBtn.Click += new System.EventHandler(this.empDeleteBtn_Click);
            // 
            // empEditBtn
            // 
            this.empEditBtn.ActiveBorderThickness = 1;
            this.empEditBtn.ActiveCornerRadius = 20;
            this.empEditBtn.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.empEditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.empEditBtn.ActiveLineColor = System.Drawing.Color.White;
            this.empEditBtn.BackColor = System.Drawing.Color.White;
            this.empEditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empEditBtn.BackgroundImage")));
            this.empEditBtn.ButtonText = "Edit";
            this.empEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empEditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.empEditBtn.IdleBorderThickness = 1;
            this.empEditBtn.IdleCornerRadius = 20;
            this.empEditBtn.IdleFillColor = System.Drawing.Color.White;
            this.empEditBtn.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.empEditBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.empEditBtn.Location = new System.Drawing.Point(201, 448);
            this.empEditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empEditBtn.Name = "empEditBtn";
            this.empEditBtn.Size = new System.Drawing.Size(136, 41);
            this.empEditBtn.TabIndex = 31;
            this.empEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empEditBtn.Click += new System.EventHandler(this.empEditBtn_Click);
            // 
            // empAddBtn
            // 
            this.empAddBtn.ActiveBorderThickness = 1;
            this.empAddBtn.ActiveCornerRadius = 20;
            this.empAddBtn.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.empAddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.empAddBtn.ActiveLineColor = System.Drawing.Color.White;
            this.empAddBtn.BackColor = System.Drawing.Color.White;
            this.empAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empAddBtn.BackgroundImage")));
            this.empAddBtn.ButtonText = "Add";
            this.empAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empAddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.empAddBtn.IdleBorderThickness = 1;
            this.empAddBtn.IdleCornerRadius = 20;
            this.empAddBtn.IdleFillColor = System.Drawing.Color.White;
            this.empAddBtn.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.empAddBtn.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.empAddBtn.Location = new System.Drawing.Point(44, 448);
            this.empAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empAddBtn.Name = "empAddBtn";
            this.empAddBtn.Size = new System.Drawing.Size(136, 41);
            this.empAddBtn.TabIndex = 30;
            this.empAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empAddBtn.Click += new System.EventHandler(this.empAddBtn_Click);
            // 
            // EmpGenderCB
            // 
            this.EmpGenderCB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGenderCB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpGenderCB.FormattingEnabled = true;
            this.EmpGenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.EmpGenderCB.Location = new System.Drawing.Point(357, 193);
            this.EmpGenderCB.Name = "EmpGenderCB";
            this.EmpGenderCB.Size = new System.Drawing.Size(235, 28);
            this.EmpGenderCB.TabIndex = 29;
            // 
            // empGender
            // 
            this.empGender.BackColor = System.Drawing.Color.White;
            this.empGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empGender.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGender.ForeColor = System.Drawing.Color.OrangeRed;
            this.empGender.Location = new System.Drawing.Point(357, 155);
            this.empGender.Name = "empGender";
            this.empGender.ReadOnly = true;
            this.empGender.Size = new System.Drawing.Size(154, 22);
            this.empGender.TabIndex = 28;
            this.empGender.Text = "Employee Gender";
            // 
            // EmpEduCB
            // 
            this.EmpEduCB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEduCB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpEduCB.FormattingEnabled = true;
            this.EmpEduCB.Items.AddRange(new object[] {
            "Bachelor",
            "Masters",
            "PhD",
            "PostDoc",
            "Highscool Degree",
            "College Degree"});
            this.EmpEduCB.Location = new System.Drawing.Point(357, 381);
            this.EmpEduCB.Name = "EmpEduCB";
            this.EmpEduCB.Size = new System.Drawing.Size(235, 28);
            this.EmpEduCB.TabIndex = 27;
            // 
            // empEducation
            // 
            this.empEducation.BackColor = System.Drawing.Color.White;
            this.empEducation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empEducation.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEducation.ForeColor = System.Drawing.Color.OrangeRed;
            this.empEducation.Location = new System.Drawing.Point(357, 353);
            this.empEducation.Name = "empEducation";
            this.empEducation.ReadOnly = true;
            this.empEducation.Size = new System.Drawing.Size(235, 22);
            this.empEducation.TabIndex = 26;
            this.empEducation.Text = "Employee Education";
            // 
            // empPhone
            // 
            this.empPhone.BackColor = System.Drawing.Color.White;
            this.empPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empPhone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone.ForeColor = System.Drawing.Color.OrangeRed;
            this.empPhone.Location = new System.Drawing.Point(44, 343);
            this.empPhone.Name = "empPhone";
            this.empPhone.ReadOnly = true;
            this.empPhone.Size = new System.Drawing.Size(200, 22);
            this.empPhone.TabIndex = 25;
            this.empPhone.Text = "Employee Phone";
            // 
            // empDOB
            // 
            this.empDOB.BackColor = System.Drawing.Color.White;
            this.empDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empDOB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDOB.ForeColor = System.Drawing.Color.OrangeRed;
            this.empDOB.Location = new System.Drawing.Point(357, 256);
            this.empDOB.Name = "empDOB";
            this.empDOB.ReadOnly = true;
            this.empDOB.Size = new System.Drawing.Size(200, 22);
            this.empDOB.TabIndex = 24;
            this.empDOB.Text = "Employee Name";
            // 
            // EmpDobDateTime
            // 
            this.EmpDobDateTime.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDobDateTime.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDobDateTime.Location = new System.Drawing.Point(357, 287);
            this.EmpDobDateTime.Name = "EmpDobDateTime";
            this.EmpDobDateTime.Size = new System.Drawing.Size(316, 29);
            this.EmpDobDateTime.TabIndex = 23;
            // 
            // EmpPositionCB
            // 
            this.EmpPositionCB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPositionCB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPositionCB.FormattingEnabled = true;
            this.EmpPositionCB.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "Junior Developer",
            "Accountant",
            "Receptionist"});
            this.EmpPositionCB.Location = new System.Drawing.Point(44, 287);
            this.EmpPositionCB.Name = "EmpPositionCB";
            this.EmpPositionCB.Size = new System.Drawing.Size(181, 28);
            this.EmpPositionCB.TabIndex = 22;
            // 
            // empPosition
            // 
            this.empPosition.BackColor = System.Drawing.Color.White;
            this.empPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empPosition.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPosition.ForeColor = System.Drawing.Color.OrangeRed;
            this.empPosition.Location = new System.Drawing.Point(44, 256);
            this.empPosition.Name = "empPosition";
            this.empPosition.ReadOnly = true;
            this.empPosition.Size = new System.Drawing.Size(200, 22);
            this.empPosition.TabIndex = 21;
            this.empPosition.Text = "Employee Position";
            // 
            // EmpPhoneTB
            // 
            this.EmpPhoneTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmpPhoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhoneTB.DefaultText = "";
            this.EmpPhoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpPhoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpPhoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhoneTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhoneTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPhoneTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhoneTB.Location = new System.Drawing.Point(44, 372);
            this.EmpPhoneTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpPhoneTB.Name = "EmpPhoneTB";
            this.EmpPhoneTB.PasswordChar = '\0';
            this.EmpPhoneTB.PlaceholderText = "";
            this.EmpPhoneTB.SelectedText = "";
            this.EmpPhoneTB.Size = new System.Drawing.Size(293, 37);
            this.EmpPhoneTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmpPhoneTB.TabIndex = 20;
            // 
            // empAddress
            // 
            this.empAddress.BackColor = System.Drawing.Color.White;
            this.empAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empAddress.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddress.ForeColor = System.Drawing.Color.OrangeRed;
            this.empAddress.Location = new System.Drawing.Point(47, 155);
            this.empAddress.Name = "empAddress";
            this.empAddress.ReadOnly = true;
            this.empAddress.Size = new System.Drawing.Size(178, 22);
            this.empAddress.TabIndex = 19;
            this.empAddress.Text = "Employee Address";
            // 
            // EmpAddressTB
            // 
            this.EmpAddressTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmpAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddressTB.DefaultText = "";
            this.EmpAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddressTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAddressTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpAddressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddressTB.Location = new System.Drawing.Point(47, 184);
            this.EmpAddressTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpAddressTB.Name = "EmpAddressTB";
            this.EmpAddressTB.PasswordChar = '\0';
            this.EmpAddressTB.PlaceholderText = "";
            this.EmpAddressTB.SelectedText = "";
            this.EmpAddressTB.Size = new System.Drawing.Size(290, 37);
            this.EmpAddressTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmpAddressTB.TabIndex = 18;
            // 
            // empName
            // 
            this.empName.BackColor = System.Drawing.Color.White;
            this.empName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.OrangeRed;
            this.empName.Location = new System.Drawing.Point(357, 43);
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Size = new System.Drawing.Size(200, 22);
            this.empName.TabIndex = 17;
            this.empName.Text = "Employee Name";
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmpNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTB.DefaultText = "";
            this.EmpNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTB.Location = new System.Drawing.Point(357, 72);
            this.EmpNameTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.PasswordChar = '\0';
            this.EmpNameTB.PlaceholderText = "";
            this.EmpNameTB.SelectedText = "";
            this.EmpNameTB.Size = new System.Drawing.Size(252, 37);
            this.EmpNameTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmpNameTB.TabIndex = 16;
            // 
            // empId
            // 
            this.empId.BackColor = System.Drawing.Color.White;
            this.empId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empId.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.ForeColor = System.Drawing.Color.OrangeRed;
            this.empId.Location = new System.Drawing.Point(47, 43);
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Size = new System.Drawing.Size(200, 22);
            this.empId.TabIndex = 15;
            this.empId.Text = "Employee Id";
            // 
            // EmpIdTB
            // 
            this.EmpIdTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmpIdTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIdTB.DefaultText = "";
            this.EmpIdTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpIdTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpIdTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpIdTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpIdTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdTB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpIdTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdTB.Location = new System.Drawing.Point(47, 72);
            this.EmpIdTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.PasswordChar = '\0';
            this.EmpIdTB.PlaceholderText = "";
            this.EmpIdTB.SelectedText = "";
            this.EmpIdTB.Size = new System.Drawing.Size(290, 37);
            this.EmpIdTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmpIdTB.TabIndex = 14;
            // 
            // homeTitle
            // 
            this.homeTitle.AutoSize = true;
            this.homeTitle.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.ForeColor = System.Drawing.Color.White;
            this.homeTitle.Location = new System.Drawing.Point(12, 27);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(235, 34);
            this.homeTitle.TabIndex = 3;
            this.homeTitle.Text = "Manage Employee";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OrangeRed;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(1249, 662);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 19);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "aidubxr 2022";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1351, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(26, 23);
            this.exitLabel.TabIndex = 14;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1389, 693);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.homeTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeTitle;
        private Guna.UI2.WinForms.Guna2TextBox EmpIdTB;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.TextBox empName;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTB;
        private System.Windows.Forms.TextBox empPosition;
        private Guna.UI2.WinForms.Guna2TextBox EmpPhoneTB;
        private System.Windows.Forms.TextBox empAddress;
        private Guna.UI2.WinForms.Guna2TextBox EmpAddressTB;
        private System.Windows.Forms.ComboBox EmpPositionCB;
        private System.Windows.Forms.TextBox empDOB;
        private System.Windows.Forms.DateTimePicker EmpDobDateTime;
        private System.Windows.Forms.TextBox empPhone;
        private System.Windows.Forms.ComboBox EmpEduCB;
        private System.Windows.Forms.TextBox empEducation;
        private System.Windows.Forms.ComboBox EmpGenderCB;
        private System.Windows.Forms.TextBox empGender;
        private Bunifu.Framework.UI.BunifuThinButton2 empAddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 empHomeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 empDeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 empEditBtn;
        private Guna.UI2.WinForms.Guna2DataGridView EmpView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label exitLabel;
    }
}