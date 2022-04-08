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
    public partial class Salary : Form
    {
        int dailyBaseSalary;
        int total;
        SqlConnection con = new SqlConnection(@"Data Source=PRODUCTION6;Initial Catalog=MyEmployeeDb;User ID=sa;Password=admin");

        public Salary()
        {
            InitializeComponent();
        }

        private void empHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void fetchData()
        {
            if (salEmpIdTB.Text=="")
            {
                MessageBox.Show("Enter Employee ID!");
            }
            else
            {
                con.Open();
                string query = "select * from Employee where EmpId='" + salEmpIdTB.Text + "';";
                SqlCommand command = new SqlCommand(query, con);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach (DataRow dr in dataTable.Rows)
                {
                    salEmpNameTB.Text = dr["EmpName"].ToString();
                    salEmpPositionTB.Text = dr["EmpPosition"].ToString();
                }
                con.Close();
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            //salEmpNameTB.Enabled = false;
            //salEmpPositionTB.Enabled = false;
        }

        private void salFetchBtn_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void salViewBtn_Click(object sender, EventArgs e)
        {
            if (salEmpPositionTB.Text=="")
            {
                MessageBox.Show("Select an employee");
            }
            else if (salWorkedDaysTB.Text=="" || Convert.ToInt32(salWorkedDaysTB.Text)>28)
            {
                MessageBox.Show("Enter a number between 1 and 28");
            }
            else
            {
                total = (salEmpPositionTB.Text == "Manger" ? dailyBaseSalary = 250 : salEmpPositionTB.Text == "Senior Developer" ? dailyBaseSalary = 200 : salEmpPositionTB.Text == "Junior Developer" ? dailyBaseSalary = 160 : salEmpPositionTB.Text == "Accountant" ? dailyBaseSalary = 200 : dailyBaseSalary = 175) * Convert.ToInt32(salWorkedDaysTB.Text);
                salarySlip.Text = "Employee Id: "+salEmpIdTB.Text +"\n"+"Employee name: "+salEmpNameTB.Text+"\n"+ "Employee position: " + salEmpPositionTB.Text+"\n"+ "Days worked: " + salWorkedDaysTB.Text+"\n"+ "Daily base salary: " + dailyBaseSalary+"\n"+"Total: "+total;
            }
        }

        private void salPrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====Salary Summary=====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(160));
            e.Graphics.DrawString("Employee Id: "+salEmpIdTB.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 150));
            e.Graphics.DrawString("Employee Name: "+salEmpNameTB.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 200));
            e.Graphics.DrawString("Employee Position: "+salEmpPositionTB.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 250));
            e.Graphics.DrawString("Days worked: "+salWorkedDaysTB.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 300));
            e.Graphics.DrawString("Daily base salary: "+dailyBaseSalary, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 350));
            e.Graphics.DrawString("Total: "+total, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 400));
        }
    }
}