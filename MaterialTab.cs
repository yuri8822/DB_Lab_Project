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
        public MaterialTab()
        {
            InitializeComponent();
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
            SqlConnection conn = new SqlConnection(Database.getConnection());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Material", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               // material.Add(new Material(Convert.ToInt32(reader["MT_ID"]),reader["MT_Title"].ToString(), reader["MT_Desc"].ToString(), reader["MT_Time"].ToString()));
            }
            MaterialCB.DisplayMember = "MT_Title";
            MaterialCB.DataSource = material;
            conn.Close();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewMaterial material = new ViewMaterial();
            material.MaterialCBText = MaterialCB.Text;
            material.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateMaterial update = new UpdateMaterial();
            update.MaterialCBText = MaterialCB.Text;
            update.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Database.getConnection());
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Material WHERE MT_Title = @title", conn);
            cmd.Parameters.AddWithValue("@title", MaterialCB.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Material Deleted Successfully");
            MaterialLoad(sender, e);
        }
    }
}
