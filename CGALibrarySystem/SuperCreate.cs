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
    public partial class SuperCreate : Form
    {
        public string setAccountType { get; set; }
        
        public SuperCreate()
        {
            InitializeComponent();
        }

        private void SuperCreate_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT * FROM `admins` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgAdminList.DataSource = dt;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            viewAccountType.Text = "";
        }

        private void setSuperAccRbtn_CheckedChanged(object sender, EventArgs e)
        {
            setAccountType = "SuperAcc";
            viewAccountType.Text = setAccountType;
        }

        private void setAdminAccRbtn_CheckedChanged(object sender, EventArgs e)
        {
            setAccountType = "AdminAcc";
            viewAccountType.Text = setAccountType;
        }

        private void btnBackSlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adHome = new AdminHome();
            adHome.Show();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "INSERT INTO `admins`(`AdminID`, `Name`, `Email`, `Username`, `Password`, `AccountType`, `Status`) VALUES ('[value-1]','" + this.txtFullname.Text + "','" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.txtPassword.Text + "','" + this.viewAccountType.Text + "','1')";
            string query2 = "SELECT * FROM `admins` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            if (txtFullname.Text == "")
            {
                MessageBox.Show("Fullname is empty!");
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
            else if (viewAccountType.Text == "")
            {
                MessageBox.Show("Account Type is empty!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are the details you entered correct?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Created!");
                    con.Close();

                    da.SelectCommand = cmd2;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgAdminList.DataSource = dt;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
