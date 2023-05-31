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
    public partial class Edit : Form
    {
        public string updateSuccess { get; set; }
        public Edit()
        {
            InitializeComponent();
        }

        private void txtSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section` FROM `students` WHERE StudentID = '" + this.txtSearchID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            int studentID;

            if (int.TryParse(txtSearchID.Text, out studentID))
            {
                if (CheckIfStudentExists(studentID))
                {
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgStudentInfo.DataSource = dt;
                    MessageBox.Show("Successfully Searched!");
                }
                else
                {
                    MessageBox.Show("Student ID does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query2 = "SELECT * FROM `students` WHERE StudentID = '" + this.txtDeleteID.Text + "'";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgStudentInfo.DataSource = dt;

            int studentID;

            if (int.TryParse(txtDeleteID.Text, out studentID))
            {
                if (CheckIfStudentExists(studentID))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this student's information?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Confirm confirm = new Confirm();
                        confirm.conf = "delete";
                        confirm.deleteID = txtDeleteID.Text;
                        confirm.Show();                     
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Student ID does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCourse.Text = "";
            txtSection.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=librarysystemdb";
            string query = "UPDATE `students` SET `Name`='" + this.txtFullname.Text + "',`Email`='" + this.txtEmail.Text + "',`Username`='" + this.txtUsername.Text + "',`Password`='" + this.txtPassword.Text + "',`Course`='" + this.txtCourse.Text + "',`Section`='" + this.txtSection.Text + "' WHERE StudentID = '" + this.txtSearchID.Text + "'";
            string query2 = "SELECT * FROM `students` WHERE StudentID = '" + this.txtSearchID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            if (txtFullname.Text == "")
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
                    Confirm confirm = new Confirm();
                    confirm.conf = "update";
                    confirm.updateID = txtSearchID.Text;
                    confirm.fullname = txtFullname.Text;
                    confirm.email = txtEmail.Text;
                    confirm.usernameUp = txtUsername.Text;
                    confirm.passwordUp = txtPassword.Text;
                    confirm.course = txtCourse.Text;
                    confirm.section = txtSection.Text;
                    confirm.Show();

                    da.SelectCommand = cmd2;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgStudentInfo.DataSource = dt;

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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private bool CheckIfStudentExists(int studentID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void dgStudentInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgStudentInfo.SelectedRows.Count > 0)
            {
                txtFullname.Text = dgStudentInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dgStudentInfo.SelectedRows[0].Cells[2].Value.ToString();
                txtUsername.Text = dgStudentInfo.SelectedRows[0].Cells[3].Value.ToString();
                txtPassword.Text = dgStudentInfo.SelectedRows[0].Cells[4].Value.ToString();
                txtCourse.Text = dgStudentInfo.SelectedRows[0].Cells[5].Value.ToString();
                txtSection.Text = dgStudentInfo.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}
