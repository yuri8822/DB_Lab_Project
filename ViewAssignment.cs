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
    public partial class ViewAssignment : Form
    {
        public ViewAssignment()
        {
            InitializeComponent();
        }
        
        public string AssignmentCBText { get; set; }

        private void ViewAssignment_Load(object sender, EventArgs e)
        {
            string title = AssignmentCBText;
            ViewAssignmentLabel.Text = title;
            string dt = "";
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Assignment WHERE ass_Title = @title", conn);
            cmd.Parameters.AddWithValue("@title", AssignmentCBText);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string description = reader["ass_Desc"].ToString();
                string marks = reader["ass_Marks"].ToString();
                richTextBox1.Text = description;
                Marks.Text = marks + " points";
                dt = reader["ass_Time"].ToString();
            }
            SetDeadline.Text = "Deadline: " + dt;
            conn.Close();
        }
    }
}
