using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGALibrarySystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "INSERT INTO `students`(`StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status`) VALUES ('" + this.txtStudentID.Text + "','" + this.txtFullName.Text + "','" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.txtPassword.Text + "','" + this.txtCourse.Text + "','" + this.txtSection.Text + "', '1')";
            string query2 = "SELECT * FROM `students` WHERE StudentID = '" + this.txtStudentID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is empty!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is empty!");
            }
            else if (txtStudentID.Text == "")
            {
                MessageBox.Show("Student ID is empty!");
            }
            else if (txtFullName.Text == "")
            {
                MessageBox.Show("Full Name is empty!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is empty!");
            }
            else if (txtCourse.Text == "")
            {
                MessageBox.Show("Course is empty!");
            }
            else if (txtSection.Text == "")
            {
                MessageBox.Show("Section is empty!");
            }
            else
            {               
                DialogResult dialogResult = MessageBox.Show("Are the details you entered correct?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Submitted!");
                    con.Close();

                    da.SelectCommand = cmd2;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgStudentInfo.DataSource = dt;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtStudentID.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtCourse.Text = "";
            txtSection.Text = "";
        }
    }
}
