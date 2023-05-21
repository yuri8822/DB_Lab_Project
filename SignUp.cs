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
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SignUp()
        {
            InitializeComponent();

            conn = new SqlConnection(Database.getConnection());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int random = randomNumber.Next(0, 9999);
            conn.Open();
            cmd = new SqlCommand("INSERT INTO USER_R (UserID, Name, Email, UserType, Pass) VALUES (@random, @Name, @Email, @UserType, @Password)", conn);
            cmd.Parameters.AddWithValue("@Name", FName.Text + " " + LName.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTxt.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
            cmd.Parameters.AddWithValue("@random", random);
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
