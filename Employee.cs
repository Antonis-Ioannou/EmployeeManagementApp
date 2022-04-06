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
                con.Open();
                try
                {
                    string query = "insert into Employee values('"+EmpIdTB.Text+"','"+EmpNameTB.Text+"','"+EmpAddressTB.Text+"','"+EmpPositionCB.SelectedItem.ToString()+"','"+EmpDob.Value.Date+"','"+EmpPhoneTB.Text+"','"+EmpEduCB.SelectedItem.ToString()+"','"+EmpGenderCB.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                con.Close();
                populate();
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Employee";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            EmpView.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void empDeleteBtn_Click(object sender, EventArgs e)
        {
            if (EmpIdTB.Text == "")
            {
                MessageBox.Show("Enter the Employee Id");
            }
            else
            {
                con.Open();
                try
                {
                    string query = "delete from Employee where EmpId='" + EmpIdTB.Text + "';";
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                populate();
            }
        }
    }
}
