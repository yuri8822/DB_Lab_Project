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
        public DashboardClasses()
        {
            InitializeComponent();
        }

        public TeacherDashboardClasses TeacherDashboardClasses
        {
            get
            {
                { return (TeacherDashboardClasses)ClassesCB.SelectedItem; }
            }
        }

        public String myConnection()
        {
            String con = "Data Source=DESKTOP-L3PILNC\\SQLEXPRESS;Initial Catalog=DB_L_Project;Integrated Security=True"; ;
            return con;
        }
        
        private void DashboardClasses_Load(object sender, EventArgs e)
        {
            List<TeacherDashboardClasses> teacherDashboardClasses = new List<TeacherDashboardClasses>();
            SqlConnection conn = new SqlConnection(myConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", conn);
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
