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
    public partial class ConfirmBorrow : Form
    {
        public string trnsfrStudentID { get; set; }
        public string trnsfrBookID { get; set; }
        public ConfirmBorrow()
        {
            InitializeComponent();
        }

        private void ConfirmBorrow_Load(object sender, EventArgs e)
        {  
            viewBorrowDate.Text = DateTime.Now.ToLongDateString();

            DateTime currentDate = DateTime.Now.Date;
            DateTime newDate = currentDate.AddDays(14);

            viewReturnDate.Text = newDate.ToLongDateString();

            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "INSERT INTO `borrowings`(`BorrowingID`, `StudentID`, `BookID`) VALUES ('[value-1]','" + trnsfrStudentID + "','" + trnsfrBookID + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataReader dr;

            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            con.Close();          

            string query2 = "SELECT `BookID`, `Title`, `available` FROM `books` WHERE BookID = '" + trnsfrBookID + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            con.Open();
            using (dr = cmd2.ExecuteReader())
            {
                if (dr.Read())
                {
                    viewNameBook.Text = dr["Title"].ToString();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            con.Close();

            viewStudentID.Text = trnsfrStudentID;
            viewBookID.Text = trnsfrBookID;

            string query3 = "SELECT MAX(BorrowingID) AS maxBorrowingID FROM borrowings";
            MySqlCommand cmd3 = new MySqlCommand(query3, con);
            con.Open();
            using (dr = cmd3.ExecuteReader())
            {
                if (dr.Read())
                {
                    viewBorrowingID.Text = dr["maxBorrowingID"].ToString();
                }
                else
                {
                    MessageBox.Show("Please Fill up the Borrow and Return Date!");
                }
            }
            con.Close();

            string query4 = "SELECT `BorrowingID`, `StudentID`, `BookID`, `BorrowDate`, `ReturnDate`, `Fine` FROM `borrowings` WHERE BorrowingID = '" + viewBorrowingID.Text + "'";
            MySqlCommand cmd4 = new MySqlCommand(query4, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd4;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBorrowingInfo.DataSource = dt;
        }

        private void viewBookID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string fine = "Pending";
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `borrowings` SET `BorrowDate`=@BorrowDate, `ReturnDate`=@ReturnDate , `Fine`=@Fine WHERE BorrowingID=@BorrowingID";
            string query2 = "UPDATE `books` SET `Available`=@Available WHERE BookID=@BookID";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd2 = new MySqlCommand(query2, con);

                cmd.Parameters.AddWithValue("@BorrowDate", viewBorrowDate.Text);
                cmd.Parameters.AddWithValue("@ReturnDate", viewReturnDate.Text);
                cmd.Parameters.AddWithValue("@BorrowingID", viewBorrowingID.Text);
                cmd.Parameters.AddWithValue("@Fine", fine);

                cmd2.Parameters.AddWithValue("@Available", txtAvailable.Text);
                cmd2.Parameters.AddWithValue("@BookID", viewBookID.Text);

                DialogResult dialogResult = MessageBox.Show("Do you really want to borrow this book?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    string query5 = "SELECT `BorrowingID`, `StudentID`, `BookID`, `BorrowDate`, `ReturnDate`, `Fine` FROM `borrowings` WHERE BorrowingID = '" + viewBorrowingID.Text + "'";
                    MySqlCommand cmd5 = new MySqlCommand(query5, con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd5;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgBorrowingInfo.DataSource = dt;

                    MessageBox.Show("Do not forget your IDs!");

                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel borrowing this book?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                string query = "DELETE FROM `borrowings` WHERE BorrowingID = '" + viewBorrowingID.Text + "'";

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                con.Close();

                this.Hide();
                Borrow borrow = new Borrow();
                borrow.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dgBorrowingInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
