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
    public partial class Announcements_Tab : UserControl
    {
        Database db = new Database();
        public Announcements_Tab()
        {
            InitializeComponent();
        }
        public Announcement announcement
        {
            get
            {
                return (Announcement)AnnouncementCB.SelectedItem;
            }
        }



        private void Announcement_Tab_Load(object sender, EventArgs e)
        {
            List<Announcement> announcements = new List<Announcement>();
            AnnouncementCB.Items.Clear();
            SqlConnection conn = new SqlConnection(db.getARString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Announcement", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                announcements.Add(new Announcement(reader["announce_Title"].ToString(), reader["announce_Desc"].ToString(), reader["announce_Time"].ToString()));
            }
            reader.Close();
            conn.Close();
            AnnouncementCB.DisplayMember = "Title";
            AnnouncementCB.DataSource = announcements;
            
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }    
}
