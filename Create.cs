using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                CreateAssignment assignmentPortal = new CreateAssignment();
                assignmentPortal.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CreateMaterial material = new CreateMaterial();
                material.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CreateAnnouncement announce = new CreateAnnouncement();
                announce.ShowDialog();
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error. No Item Selected!");
            }
        }
    }
}
