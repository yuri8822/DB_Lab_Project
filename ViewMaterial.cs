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
    public partial class ViewMaterial : Form
    {
        public ViewMaterial()
        {
            InitializeComponent();
        }
        
        public string MaterialCBText { get; set; }

        private void MaterialLoad(object sender, EventArgs e)
        {
            string selectedText = MaterialCBText;
            MaterialLabel.Text = selectedText;
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
    }
}
