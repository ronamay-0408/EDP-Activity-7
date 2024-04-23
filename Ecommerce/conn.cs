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

namespace Ecommerce
{
    public partial class conn : Form
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "ecomm";
        private string uid = "your_username"; // Change to your MySQL username
        private string password = "your_password"; // Change to your MySQL password
        private string connectionString;

        public conn()
        {
            InitializeComponent();

            // Construct the connection string
            connectionString = "Server=" + server + ";Database=" + database + ";Uid=" + uid + ";Pwd=" + password + ";";

            // Initialize the MySQL connection
            connection = new MySqlConnection(connectionString);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the MySQL connection
                connection.Open();
                MessageBox.Show("Connected to MySQL database.", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to MySQL database: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the MySQL connection (optional)
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
