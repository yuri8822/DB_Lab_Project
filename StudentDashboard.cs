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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        public string email { get; set; }

        private void ClassBtn_Click(object sender, EventArgs e)
        {
            string studentEmail = email;
            string classCode = ClassCodeTextBox.Text;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd0 = new SqlCommand("SELECT UserID FROM USER_R WHERE Email = @studentEmail", conn);
            cmd0.Parameters.AddWithValue("@studentEmail", studentEmail);
            SqlDataReader reader = cmd0.ExecuteReader();
            int userID = 0;
            if (reader.Read())
            {
                userID = Convert.ToInt32(reader["UserID"]);
            }
            reader.Close();
            MessageBox.Show(userID.ToString());
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO STUDENT_CLASS (UserID, ClassCode) VALUES (@userID, @ClassCode)", conn);
            cmd2.Parameters.AddWithValue("@ClassCode", classCode);
            cmd2.Parameters.AddWithValue("@userID", userID);
            MessageBox.Show("Class joined successfully");
            conn.Close();
            //JoinClass joinClass = new JoinClass();
            //joinClass.Show();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            string studentEmail = email;
            int userID = 0;
            List<DashboardClasses> dashboardClasses = new List<DashboardClasses>();
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM USER_R WHERE Email = @studentEmail", conn);
            cmd.Parameters.AddWithValue("@studentEmail", studentEmail);
            SqlDataReader reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                userID = Convert.ToInt32(reader1["UserID"]);
            }
            reader1.Close();
            conn.Close();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT c.ClassCode, c.ClassName FROM CLASS c JOIN STUDENT_CLASS sc ON c.ClassCode = sc.ClassCode JOIN USER_R u ON sc.UserID = u.UserID WHERE u.UserID = @userID;", conn);
            cmd1.Parameters.AddWithValue("@userID", userID);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                dashboardClasses.Add(new DashboardClasses(reader["ClassName"].ToString(), reader["ClassCode"].ToString()));
            }
            ClassesCB.DataSource = dashboardClasses;
            ClassesCB.ValueMember = "ClassCode";
            ClassesCB.DisplayMember = "ClassName";

            conn.Close();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string className = ClassesCB.Text;
            int classroomCode = 0;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("SELECT ClassCode FROM Class WHERE ClassName = @className", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@className", className);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                classroomCode = Convert.ToInt32(reader["ClassCode"]);
            }
            reader.Close();
            conn.Close();
            StudentClass studentClass = new StudentClass();
            studentClass.className = ClassesCB.Text;
            studentClass.classCode = classroomCode;
            studentClass.Show();
        }
    }
}
