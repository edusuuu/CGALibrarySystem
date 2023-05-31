using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGALibrarySystem
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query2 = "SELECT * FROM `books` WHERE 1";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBookInfo.DataSource = dt;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query2 = " SELECT `BookID`, `Title`, `Available` FROM `books` WHERE title = '" + this.txtNameBook.Text + "'";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBookInfo.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT `BookID`, `Title`, `available` FROM `books` WHERE BookID = '" + txtBookID.Text + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataReader dr;
 
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            using (dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    string available = dr["Available"].ToString();

                    if (available == "Yes")
                    {
                        int bookID;
                        int studentID;

                        if (int.TryParse(txtBookID.Text, out bookID) && int.TryParse(txtStudentID.Text, out studentID))
                        {
                            if (CheckIfStudentExists(studentID) && CheckIfBookExists(bookID))
                            {
                                this.Hide();
                                ConfirmBorrow conBor = new ConfirmBorrow();
                                conBor.trnsfrStudentID = txtStudentID.Text;
                                conBor.trnsfrBookID = txtBookID.Text;
                                conBor.Show();
                            }
                            else
                            {
                                MessageBox.Show("Student ID or Book ID does not exist!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Student ID or Book ID!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This book is not available!");
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            con.Close();     
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
        private bool CheckIfBookExists(int bookID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void dgStudentInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgBookInfo.SelectedRows.Count > 0)
            {
                txtBookID.Text = dgBookInfo.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
