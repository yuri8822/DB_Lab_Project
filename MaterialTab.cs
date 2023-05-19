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
    public partial class MaterialTab : UserControl
    {
        private Database db;
        public MaterialTab()
        {
            InitializeComponent();
            db = new Database();
        }

        public Material Material
        {
            get
            {
                { return (Material)MaterialCB.SelectedItem; }
            }
        }

        private void MaterialLoad(object sender, EventArgs e)
        {
            List<Material> material = new List<Material>();
            SqlConnection conn = new SqlConnection(db.getARString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Material", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                material.Add(new Material(Convert.ToInt32(reader["MT_ID"]),reader["MT_Title"].ToString(), reader["MT_Desc"].ToString(), reader["MT_Time"].ToString()));
            }
            MaterialCB.DisplayMember = "MT_Title";
            MaterialCB.DataSource = material;
            conn.Close();
        }
    }
}
