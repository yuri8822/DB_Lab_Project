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
    public partial class CreateAnnouncement : Form
    {
        private Database db;
        public CreateAnnouncement()
        {
            InitializeComponent();
            db = new Database();
        }

        public string ClassesCBText { get; set; }
        
        private void PostBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1001);
            string title = TitleTextBox.Text;
            string description = richTextBox1.Text;
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string course = ClassesCBText;
            SqlConnection conn = new SqlConnection(db.getARString());
            SqlCommand cmd = new SqlCommand("INSERT INTO Announcement (announce_ID, announce_Title, announce_Desc, announce_Time, ClassCode) VALUES (@randomNumber,@title, @description, @date, @course)", conn);
            cmd.Parameters.AddWithValue("@randomNumber", randomNumber);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@course", course);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Announcement Posted");
            this.Close();
        }
    }
}
