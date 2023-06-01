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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CGALibrarySystem
{
    public partial class SuperAccountLogIn : Form
    {
        public string modifyAcc { get; set; }
        public SuperAccountLogIn()
        {
            InitializeComponent();
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
                    string query = "SELECT `AdminID`, `Name`, `Email`, `Username`, `Password`, `AccountType`, `Status` FROM `admins` WHERE Username = @username AND Password = @password";

                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                            using (MySqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    string accountType = dr["AccountType"].ToString();
                                    if (accountType == "SuperAcc")
                                    {
                                        string status = dr["Status"].ToString();
                                        if (status == "1")
                                        {
                                            this.Hide();
                                            switch (modifyAcc)
                                            {
                                                case "edit":
                                                    this.Hide();
                                                    SuperModify superModify = new SuperModify();
                                                    superModify.Show();
                                                    break;

                                                case "create":
                                                    this.Hide();
                                                    SuperCreate superCreate = new SuperCreate();
                                                    superCreate.Show();
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Account is Inactive!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account is not a super account!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password!");
                                }
                            }
                        }
                    }
                }
            }
        }
        private bool CheckIfUsernameExists(string username)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM admins WHERE Username = @Username";

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
            string query = "SELECT COUNT(*) FROM admins WHERE Username = @Username AND Password = @Password";

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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome adHo = new AdminHome();
            adHo.Show();
        }
    }
}
