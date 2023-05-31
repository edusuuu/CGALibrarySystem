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
    public partial class Confirm : Form
    {
        public string conf { get; set; }
        public string deleteID {  get; set; }
        public string updateID { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string usernameUp { get; set; }
        public string passwordUp { get; set; }
        public string course { get; set; }
        public string section { get; set; }
        public Confirm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connection = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "UPDATE `students` SET `Status`='0' WHERE StudentID = '" + deleteID + "'";
            string query2 = "UPDATE `students` SET `Name`='" + fullname + "',`Email`='" + email + "',`Username`='" + usernameUp + "',`Password`='" + passwordUp + "',`Course`='" + course + "',`Section`='" + section + "' WHERE StudentID = '" + updateID + "'";

            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataReader dr;

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
                else if (!CheckIfPasswordExists(password))
                {
                    MessageBox.Show("Password does not exist!");
                }
                else
                {
                    switch (conf)
                    {
                        case "delete":
                            con.Open();
                            dr = cmd.ExecuteReader();
                            con.Close();

                            this.Hide();
                            MessageBox.Show("Account successfully deleted!");
                            break;

                        case "update":
                            con.Open();
                            dr = cmd2.ExecuteReader();
                            con.Close();

                            Edit edit = new Edit();
                            edit.updateSuccess = "success";

                            this.Hide();
                            MessageBox.Show("Successfully Updated!");
                            break;
                    }
                    
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
        private bool CheckIfPasswordExists(string Password)
        {
            string connectionString = "server=localhost;user id=root;password=;database=cgalibrarysystem";
            string query = "SELECT COUNT(*) FROM Students WHERE Password = @Password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Password", Password);

                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion of account is cancelled!");
            this.Hide();
        }
    }
}
