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
    public partial class CreateMaterial : Form
    {
        public CreateMaterial()
        {
            InitializeComponent();
        }

        public String ClassesCBText { get; set; }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string desc = richTextBox1.Text;
            string course = ClassesCBText;
            Random randomNumber = new Random();
            int materialID = randomNumber.Next(0, 1001);
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("INSERT INTO Material (MT_ID ,MT_Title, MT_Desc, ClassCode) VALUES (@materialID ,@title, @description, @course)", conn);
            cmd.Parameters.AddWithValue("@materialID ", materialID);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", desc);
            cmd.Parameters.AddWithValue("@course", course);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Material Posted");
            this.Close();
            

        }
    }
}
