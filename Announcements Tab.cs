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
        public Announcements_Tab()
        {
            InitializeComponent();
        }
        public Announcement announcement { 
            get 
            {
                return (Announcement)AnnouncementCB.SelectedItem;
            }
        }

        public String myConnection()
        {
            String conn = "Data Source=DESKTOP-L3PILNC\\SQLEXPRESS;Initial Catalog=DB_L_Project;Integrated Security=True";
            return conn;
        }

        private void Announcement_Tab_Load(object sender, EventArgs e)
        {
            List<Announcement> announcements = new List<Announcement>();
            //nnouncementCB.Items.Clear();
            SqlConnection conn = new SqlConnection(myConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Post", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                announcements.Add(new Announcement(reader["AnnouncementTitle"].ToString(), reader["AnnouncementDescription"].ToString()));
            }
            AnnouncementCB.DataSource = announcements;
            AnnouncementCB.ValueMember = "AnnouncementDescription";
            AnnouncementCB.DisplayMember = "AnnouncementTitle";
            conn.Close();
        }
    }
}
