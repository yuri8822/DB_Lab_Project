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
    public partial class SignUp : Form
    {
        private Database db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SignUp()
        {
            InitializeComponent();
            db = new Database();

            conn = new SqlConnection(db.getUmarString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO USER_R (Name, Email, UserType, Pass) VALUES (@Name, @Email, @UserType, @Password)", conn);
            cmd.Parameters.AddWithValue("@Name", FName.Text + " " + LName.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTxt.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
            if (Student.Checked == true)
            {
                cmd.Parameters.AddWithValue("@UserType", "Student");
            }
            else if (Teacher.Checked == true)
            {
                cmd.Parameters.AddWithValue("@UserType", "Teacher");
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account Created Successfully");
            Login login = new Login();
            login.Show();            

            conn.Close();
        }
    }
}
