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
            CreateAssignment assignment = new CreateAssignment();
            assignment.ClassesCBText = ClassesCB.Text;
        }

        public TeacherDashboardClasses TeacherDashboardClasses
        {
            get
            {
                { return (TeacherDashboardClasses)ClassesCB.SelectedItem; }
            }
        }
        
        private void DashboardClasses_Load(object sender, EventArgs e)
        {
            List<TeacherDashboardClasses> teacherDashboardClasses = new List<TeacherDashboardClasses>();
            SqlConnection conn = new SqlConnection(Database.getConnection()); 
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CLASS", conn);
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
