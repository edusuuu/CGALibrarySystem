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
    public partial class SuperModify : Form
    {
        public SuperModify()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtAdminID.Text = "";
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void SuperModify_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT * FROM `admins` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgAdminInfo.DataSource = dt;
        }

        private void dgAdminInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgAdminInfo.SelectedRows.Count > 0)
            {
                txtAdminID.Text = dgAdminInfo.SelectedRows[0].Cells[0].Value.ToString();
                txtFullname.Text = dgAdminInfo.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dgAdminInfo.SelectedRows[0].Cells[2].Value.ToString();
                txtUsername.Text = dgAdminInfo.SelectedRows[0].Cells[3].Value.ToString();
                txtPassword.Text = dgAdminInfo.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `admins` SET `AdminID`='" + this.txtAdminID.Text + "',`Name`='" + this.txtFullname.Text + "',`Email`='" + this.txtEmail.Text + "',`Username`='" + this.txtUsername.Text + "',`Password`='" + this.txtPassword.Text + "' WHERE AdminID = '" + this.txtAdminID.Text + "'";
            string query2 = "SELECT * FROM `admins` WHERE AdminID = '"+ txtAdminID.Text +"'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (txtAdminID.Text == "")
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
                    dgAdminInfo.DataSource = dt;

                    txtFullname.Text = "";
                    txtEmail.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `AdminID`, `Name`, `Email`, `Username`, `Password`, `AccountType`, `Status` FROM `admins` WHERE 1";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully Refreshed!");
            con.Close();
        }

        private void setInactiveBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `admins` SET `Status`='0' WHERE AdminID = '" + this.txtAdminID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This Account is now inactive!");
            con.Close();
        }

        private void setSuperBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `admins` SET `AccountType`='SuperAcc' WHERE AdminID = '" + this.txtAdminID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This Account is now a Super Account!");
            con.Close();
        }

        private void setAdminBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `admins` SET `AccountType`='AdminAcc' WHERE AdminID = '" + this.txtAdminID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This Account is now an Admin Account!");
            con.Close();
        }

        private void btnBackSlist_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void setActiveBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `admins` SET `Status`='1' WHERE AdminID = '" + this.txtAdminID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This Account is now active!");
            con.Close();
        }
    }
}
