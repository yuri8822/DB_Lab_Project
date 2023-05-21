using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private DashboardClasses dashboardClasses; // Add a field to store the object


        public string email { get; set; }
    
        private void ClassBtn_Click(object sender, EventArgs e)
        {
            string teacherEmail = email;
            string className = ClassNameTextBox.Text;
            string classCode = ClassCodeTextBox.Text;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd0 = new SqlCommand("SELECT UserID FROM USER_R WHERE Email = @teacherEmail", conn);
            cmd0.Parameters.AddWithValue("@teacherEmail", teacherEmail);
            SqlDataReader reader = cmd0.ExecuteReader();
            int userID = 0;
            if (reader.Read())
            {
                userID = Convert.ToInt32(reader["UserID"]);         
                
            }
            reader.Close();
            MessageBox.Show(userID.ToString());
            SqlCommand cmd1 = new SqlCommand("INSERT INTO CLASS (ClassName, ClassCode, ManagedBy) VALUES (@ClassName, @ClassCode, @userID)", conn);
            cmd1.Parameters.AddWithValue("@ClassName", className);
            cmd1.Parameters.AddWithValue("@ClassCode", classCode);
            cmd1.Parameters.AddWithValue("@userID", userID);
            cmd1.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO TEACHER_CLASS (UserID, ClassCode) VALUES (@userID, @ClassCode)", conn);
            cmd2.Parameters.AddWithValue("@ClassCode", classCode);
            cmd2.Parameters.AddWithValue("@userID", userID);
            MessageBox.Show("Class created successfully");
            conn.Close();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string teacherEmail = email;
            List<DashboardClasses> dashboardClasses = new List<DashboardClasses>();
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT c.ClassCode, c.ClassName FROM CLASS c JOIN USER_R u ON c.ManagedBy = u.UserID WHERE u.Email = @teacherEmail", conn);
            cmd.Parameters.AddWithValue("@teacherEmail", teacherEmail);
            SqlDataReader reader = cmd.ExecuteReader();
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
            TeacherClass teacherClass = new TeacherClass();
            teacherClass.className = ClassesCB.Text;
            teacherClass.classCode = classroomCode;
            teacherClass.Show();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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
            UpdateClass updateClass = new UpdateClass();
            updateClass.classCode = classroomCode;
            updateClass.className = ClassesCB.Text;
            updateClass.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string className = ClassesCB.Text;
            int classroomCode = 0;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ClassCode FROM Class WHERE ClassName = @className", conn);
            cmd.Parameters.AddWithValue("@className", className);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                classroomCode = Convert.ToInt32(reader["ClassCode"]);
            }
            reader.Close();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM TEACHER_CLASS WHERE ClassCode = @classroomCode", conn);
            cmd2.Parameters.AddWithValue("@classroomCode", classroomCode);
            SqlCommand cmd3 = new SqlCommand("DELETE FROM CLASS WHERE ClassCode = @classroomCode", conn);
            cmd3.Parameters.AddWithValue("@classroomCode", classroomCode);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Class Deleted Successfully");

        }
    }
}
