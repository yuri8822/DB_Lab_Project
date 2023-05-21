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
    public partial class CreateAssignment : Form
    {
        public CreateAssignment()
        {
            InitializeComponent();
        }

        public int classCode { get; set; }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string description = richTextBox1.Text;
            string dueDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int course = classCode;
            int marks = int.Parse(MarksTxtBox.Text);
            Random randomNumber = new Random();
            int assignmentID = randomNumber.Next(0, 1001);
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("INSERT INTO Assignment (ass_ID,ass_Title, ass_Desc, ass_Time, ass_Marks, ClassCode) VALUES (@assignmentID,@title, @description, @dueDate, @marks, @course)", conn);
            cmd.Parameters.AddWithValue("@assignmentID", assignmentID);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@dueDate", dueDate);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@course", course);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Assignment Posted");
            this.Close();
            
        }
    }
}
