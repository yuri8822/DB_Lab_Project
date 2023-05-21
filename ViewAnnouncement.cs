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
    public partial class ViewAnnouncement : Form
    {
        public ViewAnnouncement()
        {
            InitializeComponent();
        }

        public string AnnouncementCBText { get; set; }

        private void ViewAnnouncement_Load(object sender, EventArgs e)
        {
            
            string selectedText = AnnouncementCBText;
            Announcement.Text = selectedText;
            SqlConnection conn = new SqlConnection(Database.getConnection());
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
    }
}
