using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class AdminStudentList : Form
    {
        public AdminStudentList()
        {
            InitializeComponent();
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackSlist_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdminStudentList_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status` FROM `students` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgStudentList.DataSource = dt;
        }
        private void dgStudentList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgStudentList.SelectedRows.Count > 0)
            {
                viewStudentID.Text = dgStudentList.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentID.Text = dgStudentList.SelectedRows[0].Cells[0].Value.ToString();
                txtFullname.Text = dgStudentList.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dgStudentList.SelectedRows[0].Cells[2].Value.ToString();
                txtUsername.Text = dgStudentList.SelectedRows[0].Cells[3].Value.ToString();
                txtPassword.Text = dgStudentList.SelectedRows[0].Cells[4].Value.ToString();
                txtCourse.Text = dgStudentList.SelectedRows[0].Cells[5].Value.ToString();
                txtSection.Text = dgStudentList.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (viewStudentID.Text == "")
            {
                MessageBox.Show("Please select a Student id first!");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                string query = "UPDATE `students` SET `Status`='0' WHERE StudentID = '" + this.viewStudentID.Text + "'";

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;

                string query2 = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status` FROM `students` WHERE 1";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgStudentList.DataSource = dt;

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("This Account is now inactive!");
                con.Close();
            }        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `students` SET `StudentID`='" + this.txtStudentID.Text + "',`Name`='" + this.txtFullname.Text + "',`Email`='" + this.txtEmail.Text + "',`Username`='" + this.txtUsername.Text + "',`Password`='" + this.txtPassword.Text + "',`Course`='" + this.txtCourse.Text + "',`Section`='" + this.txtSection.Text + "' WHERE StudentID = '" + this.viewStudentID.Text + "'";
            string query2 = "SELECT * FROM `students` WHERE StudentID = '"+ txtStudentID.Text +"'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Student ID is empty!");
            }
            else if (txtFullname.Text == "")
            {
                MessageBox.Show("Full Name is empty!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is empty!");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username is empty!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is empty!");
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
                DialogResult dialogResult = MessageBox.Show("Would you like to update the information?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Updated!");
                    con.Close();

                    da.SelectCommand = cmd2;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgStudentList.DataSource = dt;

                    viewStudentID.Text = "";
                    txtFullname.Text = "";
                    txtEmail.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtCourse.Text = "";
                    txtSection.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status` FROM `students` WHERE 1";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            MessageBox.Show("Successfully Refreshed!");
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgStudentList.DataSource = dt;
        }

        private void setActiveBtn_Click(object sender, EventArgs e)
        {
            if (viewStudentID.Text == "")
            {
                MessageBox.Show("Please select a Student id first!");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                string query = "UPDATE `students` SET `Status`='1' WHERE StudentID = '" + this.txtStudentID.Text + "'";

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;

                string query2 = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status` FROM `students` WHERE 1";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgStudentList.DataSource = dt;

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("This Account is now active!");
                con.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCourse.Text = "";
            txtSection.Text = "";
        }
    }
}
