using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Lab_Project
{
    public partial class UpdateAnnouncement : Form
    {
        private Database db;
        public UpdateAnnouncement()
        {
            InitializeComponent();
            db = new Database();
                
        }

        public string AnnouncementCBText { get; set; }

        private void UpdateAnnouncement_Load(object sender, EventArgs e)
        {
            string selectedText = AnnouncementCBText;
            TitleTextBox.Text = selectedText;
            SqlConnection conn = new SqlConnection(db.getARString());
            SqlCommand cmd = new SqlCommand("Select * FROM Announcement WHERE announce_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@selectedText", selectedText);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String description = reader["announce_Desc"].ToString();
                richTextBox1.Text = description;
            }
            conn.Close();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            String title = TitleTextBox.Text;
            String description = richTextBox1.Text;
            SqlConnection conn = new SqlConnection(db.getARString());
            SqlCommand cmd = new SqlCommand("UPDATE Announcement SET announce_Title = @title, announce_Desc = @description WHERE announce_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@selectedText", AnnouncementCBText);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Announcement Updated");
            this.Close();
        }
    }
}
