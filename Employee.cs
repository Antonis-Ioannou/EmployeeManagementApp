using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PRODUCTION6;Initial Catalog=MyEmployeeDb;User ID=sa;Password=admin");

        public Employee()
        {
            InitializeComponent();
        }

        private void empAddBtn_Click(object sender, EventArgs e)
        {
            if (EmpIdTB.Text == "" || EmpNameTB.Text == "" || EmpPhoneTB.Text == "" || EmpAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Employee values("+EmpIdTB.Text+",'"+EmpNameTB.Text+"','"+EmpAddressTB.Text+"','"+EmpPositionCB.SelectedItem.ToString()+"','"+EmpDob.Value.Date+"','"+EmpPhoneTB.Text+"','"+EmpEduCB.SelectedItem.ToString()+"','"+EmpGenderCB.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
