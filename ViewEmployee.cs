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
    public partial class ViewEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PRODUCTION6;Initial Catalog=MyEmployeeDb;User ID=sa;Password=admin");

        private void fetchData()
        {
            con.Open();
            string query = "select * from Employee where EmpId='"+viewEmpIdTbox.Text+"';";
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

                detailId2.Visible = true;
                detailName2.Visible = true;
                detailAddress2.Visible = true;
                detailPosition2.Visible = true;
                detailDOB2.Visible = true;
                detailPhone2.Visible = true;
                detailEducation2.Visible = true;
                detailGender2.Visible = true;
            }
            con.Close();
        }

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void viewExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            detailId2.Visible = false;
            detailName2.Visible = false;
            detailAddress2.Visible = false;
            detailPosition2.Visible = false;
            detailDOB2.Visible = false;
            detailPhone2.Visible = false;
            detailEducation2.Visible = false;
            detailGender2.Visible = false;
        }

        private void detailRefreshBtn_Click(object sender, EventArgs e)
        {
            fetchData();
        }
    }
}
