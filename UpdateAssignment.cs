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
    public partial class UpdateAssignment : Form
    {
        public UpdateAssignment()
        {
            InitializeComponent();
        }

        public string AssignmentCBText { get; set; }
        
        private void UpdateAssignment_Load(object sender, EventArgs e)
        {
            string selectedText = AssignmentCBText;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("Select * FROM Assignment WHERE ass_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@selectedText", selectedText);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String title = reader["ass_Title"].ToString();
                String description = reader["ass_Desc"].ToString();
                String time = reader["ass_Time"].ToString();
                String Marks = reader["ass_Marks"].ToString();
                TitleTextBox.Text = title;
                richTextBox1.Text = description;
                DateTime dt;
                if(DateTime.TryParse(time, out dt))
                {
                    dateTimePicker1.Value = dt;
                }
                MarksTxtBox.Text = Marks;
 
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string desc = richTextBox1.Text;
            int marks = int.Parse(MarksTxtBox.Text);
            DateTime dt = dateTimePicker1.Value;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("UPDATE Assignment SET ass_Title = @title, ass_Desc = @desc, ass_Time = @dt, ass_Marks = @marks WHERE ass_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@selectedText", AssignmentCBText);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Assignment Updated Successfully");
            this.Close();
        }
    }
}
