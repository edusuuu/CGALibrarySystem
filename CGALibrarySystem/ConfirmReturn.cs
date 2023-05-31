using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGALibrarySystem
{

    public partial class ConfirmReturn : Form
    {
        public string BorrowingID { get; set; }
        public string StudentID { get; set; }
        public string BookID { get; set; }
        public ConfirmReturn()
        {
            InitializeComponent();
        }

        private void ConfirmReturn_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `BorrowingID`, `StudentID`, `BookID`, `BorrowDate`, `ReturnDate`, `Fine` FROM `borrowings` WHERE BorrowingID = '" + BorrowingID + "'";
           
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            MySqlDataAdapter da = new MySqlDataAdapter();
            
            
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBorrowingInfo.DataSource = dt;

            string query2 = "SELECT `BookID`, `Title`, `available` FROM `books` WHERE BookID = '" + BookID + "'";
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

            string query3 = "SELECT `BorrowingID`, `StudentID`, `BookID`, `BorrowDate`, `ReturnDate`, `Fine` FROM `borrowings` WHERE BorrowingID = '" + BorrowingID + "'";
            MySqlCommand cmd3 = new MySqlCommand(query3, con);
            con.Open();
            using (dr = cmd3.ExecuteReader())
            {
                if (dr.Read())
                {
                    DateTime returnDate = Convert.ToDateTime(dr["ReturnDate"]);
                    DateTime currentDate = DateTime.Now;
                    viewBorrowDate.Text = dr["BorrowDate"].ToString();
                    viewReturnDate.Text = returnDate.ToString();

                    if (currentDate > returnDate)
                    {
                        int fineAmount = 100;
                        viewFine.Text = "P" + fineAmount.ToString();
                    }
                    else
                    {
                        viewFine.Text = "Returned";
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            con.Close();

            viewCurrentDate.Text = DateTime.Now.ToLongDateString();
            viewBorrowingID.Text = BorrowingID;
            viewStudentID.Text = StudentID;
            viewBookID.Text = BookID;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {    
            if(viewFine.Text == "P100")
            {
                MessageBox.Show("Please pay your fine!");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                string query = "UPDATE `books` SET `Available`='Yes' WHERE BookID = '" + BookID + "'";
                string query2 = "UPDATE `borrowings` SET `Fine`='" + viewFine.Text + "' WHERE BorrowingID = '" + BorrowingID + "'";

                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataReader dr;

                con.Open();
                dr = cmd.ExecuteReader();
                con.Close();

                con.Open();
                dr = cmd2.ExecuteReader();
                con.Close();

                MessageBox.Show("Successfully returned!");
                this.Hide();
            }  
        }
    }
}
