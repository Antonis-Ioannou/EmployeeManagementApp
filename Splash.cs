﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class Splash : Form
    {
        int startPoint = 0;

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            MyProgress.Value = startPoint;
            if (MyProgress.Value==100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
