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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string adminUser = txtUsername.Text;
            string adminPass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(adminUser) || string.IsNullOrWhiteSpace(adminPass))
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }
            else
            {
                if (!CheckIfAdminUserExists(adminUser))
                {
                    MessageBox.Show("Username does not exist!");

                }
                else if (!CheckIfAdminPassExists(adminUser, adminPass))
                {
                    MessageBox.Show("Password invalid!");
                }
                else
                {
                    string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                    string query = "SELECT `AdminID`, `Name`, `Email`, `Username`, `Password`, `AccountType`, `Status` FROM `admins` WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";

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
                                AdminHome hoAd = new AdminHome();
                                hoAd.Show();
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

        private bool CheckIfAdminUserExists(string adminUser)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", adminUser);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private bool CheckIfAdminPassExists(string adminUser, string adminPass)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Username", adminUser);
                        cmd.Parameters.AddWithValue("@Password", adminPass);

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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }

}