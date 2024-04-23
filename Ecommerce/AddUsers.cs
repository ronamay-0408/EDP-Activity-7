using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void txtaddFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddaccount_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrWhiteSpace(txtaddFN.Text) ||
                string.IsNullOrWhiteSpace(txtaddEmail.Text) ||
                string.IsNullOrWhiteSpace(txtaddPhone.Text) ||
                string.IsNullOrWhiteSpace(txtaddpass.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any textbox is empty
            }

            string fullName = txtaddFN.Text;
            string email = txtaddEmail.Text;
            string phoneNumber = txtaddPhone.Text;
            string password = EncryptPassword(txtaddpass.Text); // Encrypt the password

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string pwd = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={pwd}";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(constring))
                {
                    connection.Open();

                    // Insert user information into Users table
                    string query = "INSERT INTO Users (FullName, Email, PhoneNumber, Password, UserStatus, AccountStatus) " +
                                    "VALUES (@FullName, @Email, @PhoneNumber, @Password, @UserStatus, @AccountStatus)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@UserStatus", 0); // Set UserStatus to 0 for customer
                        command.Parameters.AddWithValue("@AccountStatus", 1); // Set AccountStatus to 1 for active

                        command.ExecuteNonQuery();

                        MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();

                        // Close the form after successful account addition
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            txtaddFN.Text = string.Empty;
            txtaddEmail.Text = string.Empty;
            txtaddPhone.Text = string.Empty;
            txtaddpass.Text = string.Empty;
        }

        private string EncryptPassword(string plainPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                StringBuilder stringBuilder = new StringBuilder();

                foreach (byte b in hashedBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
