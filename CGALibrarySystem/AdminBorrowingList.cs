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
    public partial class AdminBorrowingList : Form
    {
        public string setFine { get; set; }
        public AdminBorrowingList()
        {
            InitializeComponent();
        }

        private void AdminBorrowingList_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `BorrowingID`, `StudentID`, `BookID`, `BorrowDate`, `ReturnDate`, `Fine`, `Status` FROM `borrowings` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBorrowingList.DataSource = dt;
        }

        private void dgBorrowingList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgBorrowingList.SelectedRows.Count > 0)
            {
                viewBorrowingID.Text = dgBorrowingList.SelectedRows[0].Cells[0].Value.ToString();
                txtBorrowingID.Text = dgBorrowingList.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentID.Text = dgBorrowingList.SelectedRows[0].Cells[1].Value.ToString();
                txtBookID.Text = dgBorrowingList.SelectedRows[0].Cells[2].Value.ToString();
                txtBorrowDate.Text = dgBorrowingList.SelectedRows[0].Cells[3].Value.ToString();
                txtReturnDate.Text = dgBorrowingList.SelectedRows[0].Cells[4].Value.ToString();
                viewFine.Text = dgBorrowingList.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `borrowings` SET `BorrowingID`='" + this.txtBorrowingID.Text + "',`StudentID`='" + this.txtStudentID.Text + "',`BookID`='" + this.txtBookID.Text + "',`BorrowDate`='" + this.txtBorrowDate.Text + "',`ReturnDate`='" + this.txtReturnDate.Text + "',`Fine`='" + this.viewFine.Text + "' WHERE BorrowingID = '" + this.viewBorrowingID.Text + "'";
            string query2 = "SELECT * FROM `borrowings` WHERE 1";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            if (txtBorrowingID.Text == "")
            {
                MessageBox.Show("Borrowing ID is empty!");
            }
            else if (txtStudentID.Text == "")
            {
                MessageBox.Show("Student ID is empty!");
            }
            else if (txtBookID.Text == "")
            {
                MessageBox.Show("Book ID is empty!");
            }
            else if (txtBorrowDate.Text == "")
            {
                MessageBox.Show("Borrow Date is empty!");
            }
            else if (txtReturnDate.Text == "")
            {
                MessageBox.Show("Return Date is empty!");
            }
            else if (viewFine.Text == "")
            {
                MessageBox.Show("Fine is empty!");
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
                    dgBorrowingList.DataSource = dt;

                    viewBorrowingID.Text = "";
                    txtBorrowingID.Text = "";
                    txtStudentID.Text = "";
                    txtBookID.Text = "";
                    txtBorrowDate.Text = "";
                    txtReturnDate.Text = "";
                    viewFine.Text = "";
                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void returnedBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `borrowings` SET `Status`='Returned' WHERE BorrowingID = '" + this.viewBorrowingID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This book is returned!");
            con.Close();
        }

        private void notReturnedBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `borrowings` SET `Status`='Not Returned' WHERE BorrowingID = '" + this.viewBorrowingID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("This book is not yet returned!");
            con.Close();
        }

        private void btnBackSlist_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            viewBorrowingID.Text = "";
            txtBorrowingID.Text = "";
            txtStudentID.Text = "";
            txtBookID.Text = "";
            viewFine.Text = "";
            txtBorrowDate.Text = "";
            txtReturnDate.Text = "";
        }

        private void setSuperAccRbtn_CheckedChanged(object sender, EventArgs e)
        {
            setFine = "P100";
            viewFine.Text = setFine;
        }

        private void setAdminAccRbtn_CheckedChanged(object sender, EventArgs e)
        {
            setFine = "None";
            viewFine.Text = setFine;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
