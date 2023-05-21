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
    public partial class UpdateMaterial : Form
    {
        public UpdateMaterial()
        {
            InitializeComponent();
        }

        public string MaterialCBText { get; set; }

        private void UpdateMaterial_Load(object sender, EventArgs e)
        {
            string selectedText = MaterialCBText;
            TitleTextBox.Text = selectedText;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("Select * FROM Material WHERE MT_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@selectedText", selectedText);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String description = reader["MT_Desc"].ToString();
                richTextBox1.Text = description;
            }
            conn.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string description = richTextBox1.Text;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("UPDATE Material SET MT_Title = @title, MT_Desc = @description WHERE MT_Title = @selectedText", conn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@selectedText", MaterialCBText);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Material Updated");
            this.Close();
            
        }
    }
}
