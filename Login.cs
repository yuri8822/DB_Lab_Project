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

namespace DB_Lab_Project
{
    public partial class Login : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public Login()
        {
            InitializeComponent();

            conn = new SqlConnection(Database.getConnection());
        }

        private void TeacherLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * from USER_R WHERE Email = @Email AND Pass = @Pass AND UserType = 'Teacher'", conn);
            cmd.Parameters.AddWithValue("@Email", TeacherEmail.Text);
            cmd.Parameters.AddWithValue("@Pass", TeacherPassword.Text);
            reader = cmd.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                //MessageBox.Show(TeacherEmail.Text);
                Dashboard dashboard = new Dashboard();
                //DashboardClasses dashboardClasses = new DashboardClasses();
                //dashboardClasses.email = TeacherEmail.Text;
                dashboard.email = TeacherEmail.Text;
                //dashboard.SetDashboardClasses(dashboardClasses); // Pass the object to the Dashboard form
                dashboard.Show();
            }
            reader.Close();
            conn.Close();
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * from USER_R WHERE Email = @Email AND Pass = @Pass AND UserType = 'Student'", conn);
            cmd.Parameters.AddWithValue("@Email", StudentEmail.Text);
            cmd.Parameters.AddWithValue("@Pass", StudentPassword.Text);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                StudentDashboard stdDashboard = new StudentDashboard();
                stdDashboard.email = StudentEmail.Text;
                stdDashboard.Show();
            }
            reader.Close();
            conn.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
        }
    }
}
