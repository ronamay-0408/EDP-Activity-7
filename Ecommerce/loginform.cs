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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizebtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forgotbtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the login form
            forgotpass newforgotpass = new forgotpass();

            // Hide the current form
            this.Hide();

            // Show the new form as a dialog
            newforgotpass.ShowDialog();

            // Close the current form once the new form is closed
            this.Close();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the login form
            Signupform newSignupform = new Signupform();

            // Hide the current form
            this.Hide();

            // Show the new form as a dialog
            newSignupform.ShowDialog();

            // Close the current form once the new form is closed
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            string userPassword = HashPassword(txtPassword.Text); // Hash the password

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(constring))
                {
                    connection.Open();

                    // Check if the user exists in the database
                    string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", userEmail);
                        command.Parameters.AddWithValue("@Password", userPassword);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userStatus = reader.GetInt32("UserStatus");
                                int accountStatus = reader.GetInt32("AccountStatus");

                                if (userStatus == 0)
                                {
                                    MessageBox.Show("You don't have access to this page.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (accountStatus == 0)
                                {
                                    MessageBox.Show("Your account is not active. Please contact support.", "Account Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Perform actions after successful login
                                    // For example, open the main application form
                                    Form1 mainForm = new Form1();
                                    mainForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to hash the password using SHA256
        private string HashPassword(string plainPassword)
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
