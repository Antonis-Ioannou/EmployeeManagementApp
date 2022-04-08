using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginUserIdTbox.Text=="" || loginPasswordTbox.Text=="")
            {
                MessageBox.Show("Login or password missing!");
            }
            else if (loginUserIdTbox.Text=="Admin" || loginPasswordTbox.Text=="Admin123")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user name or password!");
            }
        }
    }
}
