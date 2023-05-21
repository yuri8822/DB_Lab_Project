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
    public partial class StudentClass : Form
    {
        public StudentClass()
        {
            InitializeComponent();
        }

        public int classCode { get; set; }
        public string className { get; set; }

        private void StudentClass_Load(object sender, EventArgs e)
        {
            ClassLabel.Text = className;
            int classroomCode = classCode;
            //MessageBox.Show(classroomCode.ToString());
            List<Announcement> announcements = new List<Announcement>();
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Announcement WHERE ClassCode = @classroomCode", conn);
            cmd.Parameters.AddWithValue("@classroomCode", classroomCode);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                announcements.Add(new Announcement(reader["announce_Title"].ToString(), reader["announce_Desc"].ToString(), reader["announce_Time"].ToString()));
            }
            reader.Close();
            conn.Close();
            AnnouncementCB.DisplayMember = "Title";
            AnnouncementCB.DataSource = announcements;

            List<Assignment> assignments = new List<Assignment>();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Assignment WHERE ClassCode = @classroomCode", conn);
            cmd2.Parameters.AddWithValue("@classroomCode", classroomCode);
            reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                assignments.Add(new Assignment(reader["ass_Title"].ToString(), reader["ass_Desc"].ToString()));
            }
            reader.Close();
            conn.Close();
            AssignmentCB.DisplayMember = "Title";
            AssignmentCB.DataSource = assignments;

            List<Material> materials = new List<Material>();
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Material WHERE ClassCode = @classroomCode", conn);
            cmd3.Parameters.AddWithValue("@classroomCode", classroomCode);
            reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                materials.Add(new Material(reader["MT_Title"].ToString(), reader["MT_Desc"].ToString()));
            }
            reader.Close();
            conn.Close();
            MaterialCB.DisplayMember = "Title";
            MaterialCB.DataSource = materials;
        }

        private void ViewAnnounceBtn_Click(object sender, EventArgs e)
        {
            ViewAnnouncement view = new ViewAnnouncement();
            view.AnnouncementCBText = AnnouncementCB.Text;
            view.Show();
        }

        private void ViewAssignBtn_Click(object sender, EventArgs e)
        {
            ViewAssignment view = new ViewAssignment();
            view.AssignmentCBText = AssignmentCB.Text;
            view.Show();
        }

        private void ViewMatBtn_Click(object sender, EventArgs e)
        {
            ViewMaterial view = new ViewMaterial();
            view.MaterialCBText = MaterialCB.Text;
            view.Show();
        }
    }
}
