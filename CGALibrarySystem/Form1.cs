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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }
            else
            {
                if (!CheckIfUsernameExists(username))
                {
                    MessageBox.Show("Username does not exist!");

                }
                else if (!CheckIfPasswordExists(username, password))
                {
                    MessageBox.Show("Password invalid!");
                }
                else
                {
                    string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                    string query = "SELECT `StudentID`, `Name`, `Email`, `Username`, `Password`, `Course`, `Section`, `Status` FROM `students` WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";

                    MySqlConnection con = new MySqlConnection(connection);
                    MySqlDataReader dr;

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string status = dr["Status"].ToString();
                            if (status == "1")
                            {
                                this.Hide();
                                Home home = new Home();
                                home.Show();
                            }
                            else
                            {
                                MessageBox.Show("Account is Inactive!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong!");
                        }
                    }
                    con.Close();
                    
                }
            }

        }

        private bool CheckIfUsernameExists(string username)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Students WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private bool CheckIfPasswordExists(string username, string password)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Students WHERE Username = @Username AND Password = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminLogin AdminForm = new AdminLogin();
            AdminForm.Show();
        }
    }
}
