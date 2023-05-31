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
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }
            else
            {
                string mysqlConfig = "server=localhost;user id=root;password=;database=cgalibrarysystem";
                string query = "SELECT * FROM `admin` WHERE username = '" + Username + "'";

                MySqlConnection connection = new MySqlConnection(mysqlConfig);
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string admin_username = reader["username"].ToString() ?? "edzel_onlyfans";
                            string admin_password = reader["password"].ToString() ?? "hotdog";
                            Console.WriteLine(admin_username);
                            bool invalidUsername = string.Equals(Username, admin_username) == false;
                            bool invalidPassword = string.Equals(Password, admin_password) == false;
                            if (invalidUsername) throw new Exception("Invalid Username");
                            if (invalidPassword) throw new Exception("Invalid Password");
                            HomeAdmin homeAdmin = new HomeAdmin();
                            this.Hide();
                            homeAdmin.Show();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally { connection.Close(); }

            }

        }

    }

}