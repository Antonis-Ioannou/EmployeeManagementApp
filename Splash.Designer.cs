
namespace EmployeeManagementApp
{
    partial class Splash
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
            this.splashTitle = new System.Windows.Forms.Label();
            this.splashCredit = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // splashTitle
            // 
            this.splashTitle.AutoSize = true;
            this.splashTitle.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.splashTitle.Location = new System.Drawing.Point(103, 9);
            this.splashTitle.Name = "splashTitle";
            this.splashTitle.Size = new System.Drawing.Size(316, 28);
            this.splashTitle.TabIndex = 0;
            this.splashTitle.Text = "Employee Management System";
            // 
            // splashCredit
            // 
            this.splashCredit.AutoSize = true;
            this.splashCredit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashCredit.ForeColor = System.Drawing.Color.OrangeRed;
            this.splashCredit.Location = new System.Drawing.Point(188, 225);
            this.splashCredit.Name = "splashCredit";
            this.splashCredit.Size = new System.Drawing.Size(133, 17);
            this.splashCredit.TabIndex = 1;
            this.splashCredit.Text = "Developed by aidubxr";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(191, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splashCredit);
            this.Controls.Add(this.splashTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splashTitle;
        private System.Windows.Forms.Label splashCredit;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

