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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ecommerce
{
    public partial class EditUser : Form
    {
        private int userID;
        public EditUser()
        {
            InitializeComponent();

        }

        // Parameterized constructor that takes UserID as an argument
        public EditUser(int userID) : this()
        {
            // Store the UserID for later use
            this.userID = userID;

            // Load the user information
            LoadUserData();
        }
        private void LoadUserData()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Load user information into textboxes
                        txtUserName.Text = reader.GetString(1);   // FullName
                        txtUserEmail.Text = reader.GetString(2);  // Email
                        txtUserPhoneNumber.Text = reader.GetString(3);  // PhoneNumber
                        txtUserStatus.Text = reader.GetInt32(5).ToString();  // UserStatus
                        txtUserAccountStatus.Text = reader.GetInt32(6).ToString();  // AccountStatus
                    }
                }
            }
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserAccountStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserUFsubmit_Click(object sender, EventArgs e)
        {
            // Get the updated information from the textboxes
            string updatedFullName = txtUserName.Text;
            string updatedEmail = txtUserEmail.Text;
            string updatedPhoneNumber = txtUserPhoneNumber.Text;
            int updatedUserStatus = int.Parse(txtUserStatus.Text);
            int updatedAccountStatus = int.Parse(txtUserAccountStatus.Text);

            // Update the user information in the database
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "UPDATE Users SET FullName=@FullName, Email=@Email, PhoneNumber=@PhoneNumber, UserStatus=@UserStatus, AccountStatus=@AccountStatus WHERE UserID=@UserID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FullName", updatedFullName);
                    cmd.Parameters.AddWithValue("@Email", updatedEmail);
                    cmd.Parameters.AddWithValue("@PhoneNumber", updatedPhoneNumber);
                    cmd.Parameters.AddWithValue("@UserStatus", updatedUserStatus);
                    cmd.Parameters.AddWithValue("@AccountStatus", updatedAccountStatus);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user information.");
                    }
                }
            }
        }
    }
}
