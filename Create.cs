using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Project
{
    public partial class Create : Form
    {
        public int classroomCode { get; set; }

        
            
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            Code.Text = "Class Code: " + classroomCode.ToString();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                CreateAssignment assignmentPortal = new CreateAssignment();
                assignmentPortal.classCode = Convert.ToInt32(classroomCode);
               // MessageBox.Show(classroomCode.ToString());
                assignmentPortal.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CreateMaterial material = new CreateMaterial();
                material.classCode = Convert.ToInt32(classroomCode);
                material.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CreateAnnouncement announce = new CreateAnnouncement();
                announce.classCode = Convert.ToInt32(classroomCode);
                announce.ShowDialog();
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error. No Item Selected!");
            }
        }

        
    }
}
