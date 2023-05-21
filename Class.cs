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
    public partial class TeacherClass : Form
    {
        public TeacherClass()
        {
            InitializeComponent();
        }

        public int classCode { get; set; }
        public string className { get; set; }
        
        private void TeacherClass_Load(object sender, EventArgs e)
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.classroomCode = classCode;
            create.ShowDialog();
        }

        private void ViewAnnounceBtn_Click(object sender, EventArgs e)
        {
            ViewAnnouncement view = new ViewAnnouncement();
            view.AnnouncementCBText = AnnouncementCB.Text;
            view.Show();
        }

        private void UpdateAnnounceBtn_Click(object sender, EventArgs e)
        {
            UpdateAnnouncement update = new UpdateAnnouncement();
            update.AnnouncementCBText = AnnouncementCB.Text;
            update.Show();
        }

        private void DeleteAnnounceBtn_Click(object sender, EventArgs e)
        {
            int announcementID = 0;
            int classroomCode = classCode;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT ass_ID FROM Assignment WHERE ClassCode = @classroomCode", conn);
            cmd1.Parameters.AddWithValue("@classroomCode", classroomCode);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                announcementID = Convert.ToInt32(reader["ass_ID"]);
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Announcement WHERE CLassCode = @classroomCode AND announce_ID = @announcementID", conn);
            cmd.Parameters.AddWithValue("@classroomCode", classroomCode);
            cmd.Parameters.AddWithValue("@announcementID", announcementID);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Announcement Deleted");
            

        }

        private void ViewAssignBtn_Click(object sender, EventArgs e)
        {
            ViewAssignment view = new ViewAssignment();
            view.AssignmentCBText = AssignmentCB.Text;
            view.Show();
        }

        private void UpdateAssignBtn_Click(object sender, EventArgs e)
        {
            UpdateAssignment assignment = new UpdateAssignment();
            assignment.AssignmentCBText = AssignmentCB.Text;
            assignment.Show();
        }

        private void DeleteAssignBtn_Click(object sender, EventArgs e)
        {
            int assignmentID = 0;
            int classroomCode = classCode;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT ass_ID FROM Assignment WHERE ClassCode = @classroomCode", conn);
            cmd1.Parameters.AddWithValue("@classroomCode", classroomCode);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                assignmentID = Convert.ToInt32(reader["ass_ID"]);
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Assignment WHERE ClassCode = @classroomCode AND ass_ID = @assignmentID", conn);
            cmd.Parameters.AddWithValue("@classroomCode", classCode);
            cmd.Parameters.AddWithValue("@assignmentID", assignmentID);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Assignment Deleted");
        }

        private void ViewMatBtn_Click(object sender, EventArgs e)
        {
            ViewMaterial view = new ViewMaterial();
            view.MaterialCBText = MaterialCB.Text;
            view.Show();
        }

        private void UpdateMatBtn_Click(object sender, EventArgs e)
        {
            UpdateMaterial material = new UpdateMaterial();
            material.MaterialCBText = MaterialCB.Text;
            material.Show();
        }

        private void DeleteMatBtn_Click(object sender, EventArgs e)
        {
            int materialID = 0;
            int classroomCode = classCode;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT MT_ID FROM Material WHERE ClassCode = @classroomCode", conn);
            cmd1.Parameters.AddWithValue("@classroomCode", classroomCode);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                materialID = Convert.ToInt32(reader["MT_ID"]);
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Material WHERE ClassCode = @classroomCode AND MT_ID = @materialID", conn);
            cmd.Parameters.AddWithValue("@classroomCode", classCode);
            cmd.Parameters.AddWithValue("@materialID", materialID);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Assignment Deleted");
        }
    }
}
