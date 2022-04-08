
namespace EmployeeManagementApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeSalaryLabel = new System.Windows.Forms.Label();
            this.homeViewLabel = new System.Windows.Forms.Label();
            this.homeEmpLabel = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.homeTitle = new System.Windows.Forms.Label();
            this.homeLogout = new System.Windows.Forms.Label();
            this.homeSignature = new System.Windows.Forms.Label();
            this.homeExit = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.homeSalary = new System.Windows.Forms.PictureBox();
            this.homeView = new System.Windows.Forms.PictureBox();
            this.homeEmployee = new System.Windows.Forms.PictureBox();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.White;
            this.homePanel.Controls.Add(this.homeSalary);
            this.homePanel.Controls.Add(this.homeView);
            this.homePanel.Controls.Add(this.homeEmployee);
            this.homePanel.Controls.Add(this.homeSalaryLabel);
            this.homePanel.Controls.Add(this.homeViewLabel);
            this.homePanel.Controls.Add(this.homeEmpLabel);
            this.homePanel.Location = new System.Drawing.Point(0, 143);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(852, 235);
            this.homePanel.TabIndex = 0;
            // 
            // homeSalaryLabel
            // 
            this.homeSalaryLabel.AutoSize = true;
            this.homeSalaryLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeSalaryLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.homeSalaryLabel.Location = new System.Drawing.Point(659, 173);
            this.homeSalaryLabel.Name = "homeSalaryLabel";
            this.homeSalaryLabel.Size = new System.Drawing.Size(54, 16);
            this.homeSalaryLabel.TabIndex = 14;
            this.homeSalaryLabel.Text = "Salary";
            this.homeSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeViewLabel
            // 
            this.homeViewLabel.AutoSize = true;
            this.homeViewLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeViewLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.homeViewLabel.Location = new System.Drawing.Point(405, 173);
            this.homeViewLabel.Name = "homeViewLabel";
            this.homeViewLabel.Size = new System.Drawing.Size(47, 16);
            this.homeViewLabel.TabIndex = 13;
            this.homeViewLabel.Text = "View";
            this.homeViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeEmpLabel
            // 
            this.homeEmpLabel.AutoSize = true;
            this.homeEmpLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeEmpLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.homeEmpLabel.Location = new System.Drawing.Point(134, 173);
            this.homeEmpLabel.Name = "homeEmpLabel";
            this.homeEmpLabel.Size = new System.Drawing.Size(80, 16);
            this.homeEmpLabel.TabIndex = 12;
            this.homeEmpLabel.Text = "Employee";
            this.homeEmpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTitle
            // 
            this.homeTitle.AutoSize = true;
            this.homeTitle.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTitle.ForeColor = System.Drawing.Color.White;
            this.homeTitle.Location = new System.Drawing.Point(69, 6);
            this.homeTitle.Name = "homeTitle";
            this.homeTitle.Size = new System.Drawing.Size(85, 34);
            this.homeTitle.TabIndex = 2;
            this.homeTitle.Text = "Home";
            // 
            // homeLogout
            // 
            this.homeLogout.AutoSize = true;
            this.homeLogout.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLogout.ForeColor = System.Drawing.Color.White;
            this.homeLogout.Location = new System.Drawing.Point(692, 12);
            this.homeLogout.Name = "homeLogout";
            this.homeLogout.Size = new System.Drawing.Size(80, 28);
            this.homeLogout.TabIndex = 14;
            this.homeLogout.Text = "Logout";
            // 
            // homeSignature
            // 
            this.homeSignature.AutoSize = true;
            this.homeSignature.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeSignature.ForeColor = System.Drawing.Color.White;
            this.homeSignature.Location = new System.Drawing.Point(734, 381);
            this.homeSignature.Name = "homeSignature";
            this.homeSignature.Size = new System.Drawing.Size(104, 16);
            this.homeSignature.TabIndex = 15;
            this.homeSignature.Text = "aidubxr 2022";
            this.homeSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeExit
            // 
            this.homeExit.Image = global::EmployeeManagementApp.Properties.Resources.shutdown;
            this.homeExit.Location = new System.Drawing.Point(778, 12);
            this.homeExit.Name = "homeExit";
            this.homeExit.Size = new System.Drawing.Size(60, 60);
            this.homeExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeExit.TabIndex = 17;
            this.homeExit.TabStop = false;
            this.homeExit.Click += new System.EventHandler(this.homeExit_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.Image = global::EmployeeManagementApp.Properties.Resources.home_page;
            this.homeIcon.Location = new System.Drawing.Point(3, 3);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(60, 60);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeIcon.TabIndex = 16;
            this.homeIcon.TabStop = false;
            // 
            // homeSalary
            // 
            this.homeSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeSalary.Image = global::EmployeeManagementApp.Properties.Resources.salary;
            this.homeSalary.Location = new System.Drawing.Point(617, 42);
            this.homeSalary.Name = "homeSalary";
            this.homeSalary.Size = new System.Drawing.Size(128, 128);
            this.homeSalary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeSalary.TabIndex = 17;
            this.homeSalary.TabStop = false;
            this.homeSalary.Click += new System.EventHandler(this.homeSalary_Click);
            // 
            // homeView
            // 
            this.homeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeView.Image = global::EmployeeManagementApp.Properties.Resources.view;
            this.homeView.Location = new System.Drawing.Point(367, 50);
            this.homeView.Name = "homeView";
            this.homeView.Size = new System.Drawing.Size(120, 120);
            this.homeView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeView.TabIndex = 16;
            this.homeView.TabStop = false;
            this.homeView.Click += new System.EventHandler(this.homeView_Click);
            // 
            // homeEmployee
            // 
            this.homeEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeEmployee.Image = ((System.Drawing.Image)(resources.GetObject("homeEmployee.Image")));
            this.homeEmployee.Location = new System.Drawing.Point(112, 42);
            this.homeEmployee.Name = "homeEmployee";
            this.homeEmployee.Size = new System.Drawing.Size(128, 128);
            this.homeEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homeEmployee.TabIndex = 15;
            this.homeEmployee.TabStop = false;
            this.homeEmployee.Click += new System.EventHandler(this.homeEmployee_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(850, 406);
            this.Controls.Add(this.homeExit);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.homeSignature);
            this.Controls.Add(this.homeLogout);
            this.Controls.Add(this.homeTitle);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label homeTitle;
        private System.Windows.Forms.Label homeLogout;
        private System.Windows.Forms.Label homeSalaryLabel;
        private System.Windows.Forms.Label homeViewLabel;
        private System.Windows.Forms.Label homeEmpLabel;
        private System.Windows.Forms.Label homeSignature;
        private System.Windows.Forms.PictureBox homeEmployee;
        private System.Windows.Forms.PictureBox homeSalary;
        private System.Windows.Forms.PictureBox homeView;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox homeExit;
    }
}