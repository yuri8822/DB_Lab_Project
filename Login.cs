using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public partial class Login : Form
    {
        private Database db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public Login()
        {
            InitializeComponent();

            db = new Database();

            conn = new SqlConnection(db.ConnectionString());
        }

        private void TeacherLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * from Teachers WHERE Email = " + TeacherEmail, conn);
            reader = cmd.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }
    }
}
