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
    public partial class AssignmentsTab : UserControl
    {
        Database db = new Database();
        public AssignmentsTab()
        {
            InitializeComponent();
        }

        public Assignment assignment
        {
            get
            {
                return(Assignment)AssignmentCB.SelectedItem;
            }
        }

        private void AssignmentLoad(object sender, EventArgs e)
        {
            
            List<Assignment> assignments = new List<Assignment>();
            AssignmentCB.Items.Clear();
            SqlConnection conn = new SqlConnection(db.getUmarString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Assignment", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                assignments.Add(new Assignment(Convert.ToInt32(reader["ass_ID"]),reader["ass_Title"].ToString(), reader["ass_Desc"].ToString(), reader["ass_Time"].ToString(), Convert.ToInt32(reader["ass_Marks"])));
            }
            reader.Close();
            AssignmentCB.DisplayMember = "ass_Title";
            AssignmentCB.ValueMember = "ass_ID";
            AssignmentCB.DataSource = assignments;
            conn.Close();
        }
    }
}
