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
    public partial class AdminBookList : Form
    {
        public AdminBookList()
        {
            InitializeComponent();
        }

        private void AdminBookList_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `BookID`, `Title`, `Available` FROM `books` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBookList.DataSource = dt;
        }

        private void dgBookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgBookList.SelectedRows.Count > 0)
            {
<<<<<<< HEAD
                viewBookID.Text = dgBookList.SelectedRows[0].Cells[0].Value.ToString();
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
                txtBookID.Text = dgBookList.SelectedRows[0].Cells[0].Value.ToString();
                txtTitle.Text = dgBookList.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please select a book id first!");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
<<<<<<< HEAD
                string query = "UPDATE `books` SET `Available`='Yes' WHERE BookID = '" + this.viewBookID.Text + "'";
=======
                string query = "UPDATE `books` SET `Available`='Yes' WHERE BookID = '" + this.txtBookID.Text + "'";
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;

                string query2 = "SELECT `BookID`, `Title`, `Available` FROM `books` WHERE 1";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgBookList.DataSource = dt;

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("This book is now available!");
                con.Close();
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please select a book id first!");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
<<<<<<< HEAD
                string query = "UPDATE `books` SET `Available`='No' WHERE BookID = '" + this.viewBookID.Text + "'";
=======
                string query = "UPDATE `books` SET `Available`='No' WHERE BookID = '" + this.txtBookID.Text + "'";
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;

                string query2 = "SELECT `BookID`, `Title`, `Available` FROM `books` WHERE 1";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgBookList.DataSource = dt;

                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("This book is now unavailable!");
                con.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
<<<<<<< HEAD
            string query = "UPDATE `books` SET `BookID`='" + this.txtBookID.Text + "',`Title`='" + this.txtTitle.Text + "' WHERE BookID = '" + this.viewBookID.Text + "'";
=======
            string query = "UPDATE `books` SET `BookID`='" + this.txtBookID.Text + "',`Title`='" + this.txtTitle.Text + "' WHERE BookID = '" + this.txtBookID.Text + "'";
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            string query2 = "SELECT * FROM `students` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Book ID is empty!");
            }
            else if (txtTitle.Text == "")
            {
                MessageBox.Show("Title is empty!");
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
                    dgBookList.DataSource = dt;

<<<<<<< HEAD
                    viewBookID.Text = "";
=======
                    txtBookID.Text = "";
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
                    txtTitle.Text = "";
                    

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void btnBackSlist_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            viewBookID.Text = "";
            txtBookID.Text = "";
            txtTitle.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
=======
            txtBookID.Text = "";
            txtTitle.Text = "";
        }
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
    }
}
