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
            con.Open();
            string query = "select * from Employee where EmpId='" + viewEmpIdTbox.Text + "';";
            SqlCommand command = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                detailId2.Text = dr["EmpId"].ToString();
                detailName2.Text = dr["EmpName"].ToString();
                detailAddress2.Text = dr["EmpAddress"].ToString();
                detailPosition2.Text = dr["EmpPosition"].ToString();
                detailDOB2.Text = dr["EmpDOB"].ToString();
                detailPhone2.Text = dr["EmpPhone"].ToString();
                detailEducation2.Text = dr["EmpEdu"].ToString();
                detailGender2.Text = dr["EmpGender"].ToString();
            }
            con.Close();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            
        }
    }
}
