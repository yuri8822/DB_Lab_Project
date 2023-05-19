using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Lab_Project
{
    public partial class DashboardClasses : UserControl
    {
        private Database db;

        public DashboardClasses()
        {
            InitializeComponent();
            db = new Database();
        }

        public TeacherDashboardClasses TeacherDashboardClasses
        {
            get
            {
                { return (TeacherDashboardClasses)ClassesCB.SelectedItem; }
            }
        }

        // READ THIS: I have removed the getConnection function and have instead changed the code to fit the new method of getting the string
        
        private void DashboardClasses_Load(object sender, EventArgs e)
        {
            List<TeacherDashboardClasses> teacherDashboardClasses = new List<TeacherDashboardClasses>();
            SqlConnection conn = new SqlConnection(db.getUmarString()); 
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                teacherDashboardClasses.Add(new TeacherDashboardClasses(reader["ClassName"].ToString(), reader["ClassCode"].ToString()));
            }
            ClassesCB.DataSource = teacherDashboardClasses;
            ClassesCB.ValueMember = "ClassCode";
            ClassesCB.DisplayMember = "ClassName";
            conn.Close();
        }
    }
}
