using MySql.Data.MySqlClient;
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

namespace Ecommerce
{
    public partial class Signupform : Form
    {
        public Signupform()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Con_loginbtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the login form
            loginform newLoginForm = new loginform();

            // Hide the current form
            this.Hide();

            // Show the new form as a dialog
            newLoginForm.ShowDialog();

            // Close the current form once the new form is closed
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any textbox is empty
            if (string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtpass.Text) ||
                string.IsNullOrWhiteSpace(txtretypepass.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the passwords match
            if (txtpass.Text != txtretypepass.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullName = txtFN.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhone.Text;
            string password = EncryptPassword(txtpass.Text); // Encrypt the password
            int userStatus = 0; // Set UserStatus to 0 for customer
            int accountStatus = 1; // Set AccountStatus to 1 for active

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
                        command.Parameters.AddWithValue("@UserStatus", userStatus);
                        command.Parameters.AddWithValue("@AccountStatus", accountStatus);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();

                        // Navigate to the main form (replace Form1 with your actual main form)
                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to clear the textboxes
        private void ClearTextBoxes()
        {
            txtFN.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtretypepass.Text = string.Empty;
        }

        // Function to encrypt the password using SHA256
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

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtretypepass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
