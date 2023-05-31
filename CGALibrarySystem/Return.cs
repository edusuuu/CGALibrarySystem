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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string borrowingID = txtBorrowingID.Text;
            string studentID = txtStudentID.Text;
            string bookID = txtBookID.Text;

            if (string.IsNullOrWhiteSpace(borrowingID))
            {
                MessageBox.Show("Borrowing ID does not exist!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Student ID does not exist!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(bookID))
            {
                MessageBox.Show("Book ID does not exist!");
                return;
            }
            else
            {
                if (!CheckIfBorrowingIDExists(borrowingID))
                {
                    MessageBox.Show("Borrowing ID does not exist!");

                }
                else if (!CheckIfStudentIDExists(borrowingID, studentID))
                {
                    MessageBox.Show("Student ID does not exist!");
                }
                else if (!CheckIfBookIDExists(borrowingID, bookID))
                {
                    MessageBox.Show("Book ID does not exist!");
                }
                else
                {
                    this.Hide();

                    Home home = new Home();
                    home.Close();

                    ConfirmReturn conRe = new ConfirmReturn();
                    conRe.BorrowingID = txtBorrowingID.Text;
                    conRe.StudentID = txtStudentID.Text;
                    conRe.BookID = txtBookID.Text;
                    conRe.Show();
                }
            }
        }

        private bool CheckIfBorrowingIDExists(string borrowingID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Borrowings WHERE BorrowingID = @BorrowingID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BorrowingID", borrowingID);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private bool CheckIfStudentIDExists(string borrowingID, string studentID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Borrowings WHERE BorrowingID = @BorrowingID AND StudentID = @StudentID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@BorrowingID", borrowingID);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        private bool CheckIfBookIDExists(string borrowingID, string bookID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Borrowings WHERE BorrowingID = @BorrowingID AND BookID = @BookID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@BorrowingID", borrowingID);
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
