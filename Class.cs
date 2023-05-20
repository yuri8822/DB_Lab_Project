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
    public partial class TeacherClass : Form
    {
        public TeacherClass()
        {
            InitializeComponent();
        }

        private void TeacherClass_Load(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }
    }
}
