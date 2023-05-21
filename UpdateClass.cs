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
    public partial class UpdateClass : Form
    {
        public UpdateClass()
        {
            InitializeComponent();
        }

        public int classCode { get; set; }
        public string className { get; set; }

        private void UpdateClass_Load(object sender, EventArgs e)
        {
            CName.Text = className;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string name = CName.Text;
            int code = classCode;
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CLASS SET ClassName = @name WHERE ClassCode = @code", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Class Updated Successfully");
            this.Close();

        }
    }
}
