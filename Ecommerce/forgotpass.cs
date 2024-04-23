using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography; // For SHA256
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class forgotpass : Form
    {
        public forgotpass()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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



        private void txtFEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFConPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            string userEmail = txtFEmail.Text;
            string newPassword = EncryptPassword(txtFNewPass.Text); // Encrypt the new password

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

                    // Check if the user email exists in the database
                    string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@Email", userEmail);

                        int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                        if (emailCount == 0)
                        {
                            MessageBox.Show("Email not found in the database. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Update the user's password
                    string updatePasswordQuery = "UPDATE Users SET Password = @Password WHERE Email = @Email";
                    using (MySqlCommand updatePasswordCommand = new MySqlCommand(updatePasswordQuery, connection))
                    {
                        updatePasswordCommand.Parameters.AddWithValue("@Password", newPassword);
                        updatePasswordCommand.Parameters.AddWithValue("@Email", userEmail);

                        int rowsAffected = updatePasswordCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            txtFEmail.Text = string.Empty;
            txtFNewPass.Text = string.Empty;
            txtFConPass.Text = string.Empty;
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
