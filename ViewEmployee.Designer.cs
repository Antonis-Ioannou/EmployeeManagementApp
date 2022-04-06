﻿
namespace EmployeeManagementApp
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.viewformEmployee = new System.Windows.Forms.PictureBox();
            this.viewTitle = new System.Windows.Forms.Label();
            this.viewExitLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empHomeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.empAddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.detailGender = new System.Windows.Forms.TextBox();
            this.detailEducation = new System.Windows.Forms.TextBox();
            this.detailPhone = new System.Windows.Forms.TextBox();
            this.detailDOB = new System.Windows.Forms.TextBox();
            this.detailPosition = new System.Windows.Forms.TextBox();
            this.detailAddress = new System.Windows.Forms.TextBox();
            this.detailName = new System.Windows.Forms.TextBox();
            this.detailIdSearch = new System.Windows.Forms.TextBox();
            this.detailIdSearchTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.detailRefreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.detailId = new System.Windows.Forms.TextBox();
            this.detailId2 = new System.Windows.Forms.TextBox();
            this.detailPhone2 = new System.Windows.Forms.TextBox();
            this.detailPosition2 = new System.Windows.Forms.TextBox();
            this.detailAddress2 = new System.Windows.Forms.TextBox();
            this.detailGender2 = new System.Windows.Forms.TextBox();
            this.detailEducation2 = new System.Windows.Forms.TextBox();
            this.detailDOB2 = new System.Windows.Forms.TextBox();
            this.detailName2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewformEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewformEmployee
            // 
            this.viewformEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewformEmployee.Image = ((System.Drawing.Image)(resources.GetObject("viewformEmployee.Image")));
            this.viewformEmployee.Location = new System.Drawing.Point(-1, -1);
            this.viewformEmployee.Name = "viewformEmployee";
            this.viewformEmployee.Size = new System.Drawing.Size(128, 128);
            this.viewformEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewformEmployee.TabIndex = 18;
            this.viewformEmployee.TabStop = false;
            // 
            // viewTitle
            // 
            this.viewTitle.AutoSize = true;
            this.viewTitle.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTitle.ForeColor = System.Drawing.Color.White;
            this.viewTitle.Location = new System.Drawing.Point(143, 54);
            this.viewTitle.Name = "viewTitle";
            this.viewTitle.Size = new System.Drawing.Size(227, 34);
            this.viewTitle.TabIndex = 17;
            this.viewTitle.Text = "Employee Details";
            // 
            // viewExitLabel
            // 
            this.viewExitLabel.AutoSize = true;
            this.viewExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExitLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewExitLabel.ForeColor = System.Drawing.Color.White;
            this.viewExitLabel.Location = new System.Drawing.Point(760, 9);
            this.viewExitLabel.Name = "viewExitLabel";
            this.viewExitLabel.Size = new System.Drawing.Size(26, 23);
            this.viewExitLabel.TabIndex = 19;
            this.viewExitLabel.Text = "X";
            this.viewExitLabel.Click += new System.EventHandler(this.viewExitLabel_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(658, 674);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 19);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "aidubxr 2022";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.detailGender2);
            this.panel1.Controls.Add(this.detailEducation2);
            this.panel1.Controls.Add(this.detailDOB2);
            this.panel1.Controls.Add(this.detailName2);
            this.panel1.Controls.Add(this.detailId2);
            this.panel1.Controls.Add(this.detailPhone2);
            this.panel1.Controls.Add(this.detailPosition2);
            this.panel1.Controls.Add(this.detailAddress2);
            this.panel1.Controls.Add(this.detailId);
            this.panel1.Controls.Add(this.detailRefreshBtn);
            this.panel1.Controls.Add(this.empHomeBtn);
            this.panel1.Controls.Add(this.empAddBtn);
            this.panel1.Controls.Add(this.detailGender);
            this.panel1.Controls.Add(this.detailEducation);
            this.panel1.Controls.Add(this.detailPhone);
            this.panel1.Controls.Add(this.detailDOB);
            this.panel1.Controls.Add(this.detailPosition);
            this.panel1.Controls.Add(this.detailAddress);
            this.panel1.Controls.Add(this.detailName);
            this.panel1.Controls.Add(this.detailIdSearch);
            this.panel1.Controls.Add(this.detailIdSearchTbox);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 543);
            this.panel1.TabIndex = 20;
            // 
            // empHomeBtn
            // 
            this.empHomeBtn.ActiveBorderThickness = 1;
            this.empHomeBtn.ActiveCornerRadius = 20;
            this.empHomeBtn.ActiveFillColor = System.Drawing.Color.DarkCyan;
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
            this.empHomeBtn.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.empHomeBtn.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.empHomeBtn.Location = new System.Drawing.Point(625, 424);
            this.empHomeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empHomeBtn.Name = "empHomeBtn";
            this.empHomeBtn.Size = new System.Drawing.Size(136, 41);
            this.empHomeBtn.TabIndex = 53;
            this.empHomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empAddBtn
            // 
            this.empAddBtn.ActiveBorderThickness = 1;
            this.empAddBtn.ActiveCornerRadius = 20;
            this.empAddBtn.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.empAddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.empAddBtn.ActiveLineColor = System.Drawing.Color.White;
            this.empAddBtn.BackColor = System.Drawing.Color.White;
            this.empAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empAddBtn.BackgroundImage")));
            this.empAddBtn.ButtonText = "Print";
            this.empAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empAddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.empAddBtn.IdleBorderThickness = 1;
            this.empAddBtn.IdleCornerRadius = 20;
            this.empAddBtn.IdleFillColor = System.Drawing.Color.White;
            this.empAddBtn.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.empAddBtn.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.empAddBtn.Location = new System.Drawing.Point(222, 424);
            this.empAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.empAddBtn.Name = "empAddBtn";
            this.empAddBtn.Size = new System.Drawing.Size(136, 41);
            this.empAddBtn.TabIndex = 50;
            this.empAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailGender
            // 
            this.detailGender.BackColor = System.Drawing.Color.White;
            this.detailGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailGender.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGender.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailGender.Location = new System.Drawing.Point(439, 200);
            this.detailGender.Name = "detailGender";
            this.detailGender.ReadOnly = true;
            this.detailGender.Size = new System.Drawing.Size(161, 19);
            this.detailGender.TabIndex = 48;
            this.detailGender.Text = "Employee Gender";
            // 
            // detailEducation
            // 
            this.detailEducation.BackColor = System.Drawing.Color.White;
            this.detailEducation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailEducation.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailEducation.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailEducation.Location = new System.Drawing.Point(439, 365);
            this.detailEducation.Name = "detailEducation";
            this.detailEducation.ReadOnly = true;
            this.detailEducation.Size = new System.Drawing.Size(161, 19);
            this.detailEducation.TabIndex = 46;
            this.detailEducation.Text = "Employee Education";
            // 
            // detailPhone
            // 
            this.detailPhone.BackColor = System.Drawing.Color.White;
            this.detailPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailPhone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPhone.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailPhone.Location = new System.Drawing.Point(42, 365);
            this.detailPhone.Name = "detailPhone";
            this.detailPhone.ReadOnly = true;
            this.detailPhone.Size = new System.Drawing.Size(148, 19);
            this.detailPhone.TabIndex = 45;
            this.detailPhone.Text = "Employee Phone";
            // 
            // detailDOB
            // 
            this.detailDOB.BackColor = System.Drawing.Color.White;
            this.detailDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailDOB.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailDOB.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailDOB.Location = new System.Drawing.Point(439, 284);
            this.detailDOB.Name = "detailDOB";
            this.detailDOB.ReadOnly = true;
            this.detailDOB.Size = new System.Drawing.Size(161, 19);
            this.detailDOB.TabIndex = 44;
            this.detailDOB.Text = "Employee DOB";
            // 
            // detailPosition
            // 
            this.detailPosition.BackColor = System.Drawing.Color.White;
            this.detailPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailPosition.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPosition.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailPosition.Location = new System.Drawing.Point(42, 284);
            this.detailPosition.Name = "detailPosition";
            this.detailPosition.ReadOnly = true;
            this.detailPosition.Size = new System.Drawing.Size(148, 19);
            this.detailPosition.TabIndex = 41;
            this.detailPosition.Text = "Employee Position";
            // 
            // detailAddress
            // 
            this.detailAddress.BackColor = System.Drawing.Color.White;
            this.detailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailAddress.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailAddress.Location = new System.Drawing.Point(45, 200);
            this.detailAddress.Name = "detailAddress";
            this.detailAddress.ReadOnly = true;
            this.detailAddress.Size = new System.Drawing.Size(145, 19);
            this.detailAddress.TabIndex = 39;
            this.detailAddress.Text = "Employee Address";
            // 
            // detailName
            // 
            this.detailName.BackColor = System.Drawing.Color.White;
            this.detailName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailName.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailName.Location = new System.Drawing.Point(439, 118);
            this.detailName.Name = "detailName";
            this.detailName.ReadOnly = true;
            this.detailName.Size = new System.Drawing.Size(161, 19);
            this.detailName.TabIndex = 37;
            this.detailName.Text = "Employee Name";
            // 
            // detailIdSearch
            // 
            this.detailIdSearch.BackColor = System.Drawing.Color.White;
            this.detailIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailIdSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailIdSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailIdSearch.Location = new System.Drawing.Point(191, 29);
            this.detailIdSearch.Name = "detailIdSearch";
            this.detailIdSearch.ReadOnly = true;
            this.detailIdSearch.Size = new System.Drawing.Size(109, 19);
            this.detailIdSearch.TabIndex = 35;
            this.detailIdSearch.Text = "Employee Id";
            // 
            // detailIdSearchTbox
            // 
            this.detailIdSearchTbox.BorderColor = System.Drawing.Color.DarkCyan;
            this.detailIdSearchTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.detailIdSearchTbox.DefaultText = "";
            this.detailIdSearchTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.detailIdSearchTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.detailIdSearchTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailIdSearchTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailIdSearchTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailIdSearchTbox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailIdSearchTbox.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailIdSearchTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailIdSearchTbox.Location = new System.Drawing.Point(308, 22);
            this.detailIdSearchTbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.detailIdSearchTbox.Name = "detailIdSearchTbox";
            this.detailIdSearchTbox.PasswordChar = '\0';
            this.detailIdSearchTbox.PlaceholderText = "";
            this.detailIdSearchTbox.SelectedText = "";
            this.detailIdSearchTbox.Size = new System.Drawing.Size(211, 26);
            this.detailIdSearchTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.detailIdSearchTbox.TabIndex = 34;
            // 
            // detailRefreshBtn
            // 
            this.detailRefreshBtn.ActiveBorderThickness = 1;
            this.detailRefreshBtn.ActiveCornerRadius = 20;
            this.detailRefreshBtn.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.detailRefreshBtn.ActiveForecolor = System.Drawing.Color.White;
            this.detailRefreshBtn.ActiveLineColor = System.Drawing.Color.White;
            this.detailRefreshBtn.BackColor = System.Drawing.Color.White;
            this.detailRefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detailRefreshBtn.BackgroundImage")));
            this.detailRefreshBtn.ButtonText = "Refresh";
            this.detailRefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailRefreshBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.detailRefreshBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailRefreshBtn.IdleBorderThickness = 1;
            this.detailRefreshBtn.IdleCornerRadius = 20;
            this.detailRefreshBtn.IdleFillColor = System.Drawing.Color.White;
            this.detailRefreshBtn.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.detailRefreshBtn.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.detailRefreshBtn.Location = new System.Drawing.Point(538, 18);
            this.detailRefreshBtn.Margin = new System.Windows.Forms.Padding(5);
            this.detailRefreshBtn.Name = "detailRefreshBtn";
            this.detailRefreshBtn.Size = new System.Drawing.Size(123, 30);
            this.detailRefreshBtn.TabIndex = 54;
            this.detailRefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailId
            // 
            this.detailId.BackColor = System.Drawing.Color.White;
            this.detailId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailId.ForeColor = System.Drawing.Color.DarkCyan;
            this.detailId.Location = new System.Drawing.Point(45, 118);
            this.detailId.Name = "detailId";
            this.detailId.ReadOnly = true;
            this.detailId.Size = new System.Drawing.Size(145, 19);
            this.detailId.TabIndex = 55;
            this.detailId.Text = "Employee Id";
            // 
            // detailId2
            // 
            this.detailId2.BackColor = System.Drawing.Color.White;
            this.detailId2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailId2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailId2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailId2.Location = new System.Drawing.Point(225, 118);
            this.detailId2.Name = "detailId2";
            this.detailId2.ReadOnly = true;
            this.detailId2.Size = new System.Drawing.Size(145, 19);
            this.detailId2.TabIndex = 67;
            this.detailId2.Text = "Employee Id";
            // 
            // detailPhone2
            // 
            this.detailPhone2.BackColor = System.Drawing.Color.White;
            this.detailPhone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailPhone2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPhone2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailPhone2.Location = new System.Drawing.Point(222, 365);
            this.detailPhone2.Name = "detailPhone2";
            this.detailPhone2.ReadOnly = true;
            this.detailPhone2.Size = new System.Drawing.Size(148, 19);
            this.detailPhone2.TabIndex = 66;
            this.detailPhone2.Text = "Employee Phone";
            // 
            // detailPosition2
            // 
            this.detailPosition2.BackColor = System.Drawing.Color.White;
            this.detailPosition2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailPosition2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPosition2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailPosition2.Location = new System.Drawing.Point(222, 284);
            this.detailPosition2.Name = "detailPosition2";
            this.detailPosition2.ReadOnly = true;
            this.detailPosition2.Size = new System.Drawing.Size(148, 19);
            this.detailPosition2.TabIndex = 65;
            this.detailPosition2.Text = "Employee Position";
            // 
            // detailAddress2
            // 
            this.detailAddress2.BackColor = System.Drawing.Color.White;
            this.detailAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailAddress2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailAddress2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailAddress2.Location = new System.Drawing.Point(225, 200);
            this.detailAddress2.Name = "detailAddress2";
            this.detailAddress2.ReadOnly = true;
            this.detailAddress2.Size = new System.Drawing.Size(145, 19);
            this.detailAddress2.TabIndex = 64;
            this.detailAddress2.Text = "Employee Address";
            // 
            // detailGender2
            // 
            this.detailGender2.BackColor = System.Drawing.Color.White;
            this.detailGender2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailGender2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGender2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailGender2.Location = new System.Drawing.Point(625, 200);
            this.detailGender2.Name = "detailGender2";
            this.detailGender2.ReadOnly = true;
            this.detailGender2.Size = new System.Drawing.Size(161, 19);
            this.detailGender2.TabIndex = 71;
            this.detailGender2.Text = "Employee Gender";
            // 
            // detailEducation2
            // 
            this.detailEducation2.BackColor = System.Drawing.Color.White;
            this.detailEducation2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailEducation2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailEducation2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailEducation2.Location = new System.Drawing.Point(625, 365);
            this.detailEducation2.Name = "detailEducation2";
            this.detailEducation2.ReadOnly = true;
            this.detailEducation2.Size = new System.Drawing.Size(161, 19);
            this.detailEducation2.TabIndex = 70;
            this.detailEducation2.Text = "Employee Education";
            // 
            // detailDOB2
            // 
            this.detailDOB2.BackColor = System.Drawing.Color.White;
            this.detailDOB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailDOB2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailDOB2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailDOB2.Location = new System.Drawing.Point(625, 284);
            this.detailDOB2.Name = "detailDOB2";
            this.detailDOB2.ReadOnly = true;
            this.detailDOB2.Size = new System.Drawing.Size(161, 19);
            this.detailDOB2.TabIndex = 69;
            this.detailDOB2.Text = "Employee DOB";
            // 
            // detailName2
            // 
            this.detailName2.BackColor = System.Drawing.Color.White;
            this.detailName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailName2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailName2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.detailName2.Location = new System.Drawing.Point(625, 118);
            this.detailName2.Name = "detailName2";
            this.detailName2.ReadOnly = true;
            this.detailName2.Size = new System.Drawing.Size(161, 19);
            this.detailName2.TabIndex = 68;
            this.detailName2.Text = "Employee Name";
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(794, 701);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewExitLabel);
            this.Controls.Add(this.viewformEmployee);
            this.Controls.Add(this.viewTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.viewformEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viewformEmployee;
        private System.Windows.Forms.Label viewTitle;
        private System.Windows.Forms.Label viewExitLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 empHomeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 empAddBtn;
        private System.Windows.Forms.TextBox detailGender;
        private System.Windows.Forms.TextBox detailEducation;
        private System.Windows.Forms.TextBox detailPhone;
        private System.Windows.Forms.TextBox detailDOB;
        private System.Windows.Forms.TextBox detailPosition;
        private System.Windows.Forms.TextBox detailAddress;
        private System.Windows.Forms.TextBox detailName;
        private System.Windows.Forms.TextBox detailIdSearch;
        private Guna.UI2.WinForms.Guna2TextBox detailIdSearchTbox;
        private System.Windows.Forms.TextBox detailId;
        private Bunifu.Framework.UI.BunifuThinButton2 detailRefreshBtn;
        private System.Windows.Forms.TextBox detailGender2;
        private System.Windows.Forms.TextBox detailEducation2;
        private System.Windows.Forms.TextBox detailDOB2;
        private System.Windows.Forms.TextBox detailName2;
        private System.Windows.Forms.TextBox detailId2;
        private System.Windows.Forms.TextBox detailPhone2;
        private System.Windows.Forms.TextBox detailPosition2;
        private System.Windows.Forms.TextBox detailAddress2;
    }
}