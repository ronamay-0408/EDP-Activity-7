using Ecommerce.UserControls;
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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();

            // Load user data when the form is loaded
            LoadUserData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Instantiate the AddUsers form
            AddUsers addUsersForm = new AddUsers();

            // Show the AddUsers form
            addUsersForm.Show();
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        private void LoadUserData(string searchText = "")
        {
            // Clear existing columns before adding new ones
            dataGridView1.Columns.Clear();

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE FullName LIKE @searchText OR Email LIKE @searchText";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Add the search parameter
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();


                    // Add columns only if the DataGridView is empty
                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("UserID", "UserID");
                        dataGridView1.Columns.Add("FullName", "FullName");
                        dataGridView1.Columns.Add("Email", "Email");
                        dataGridView1.Columns.Add("PhoneNumber", "PhoneNumber");
                        dataGridView1.Columns.Add("Password", "Password");
                        dataGridView1.Columns.Add("UserStatus", "UserStatus");
                        dataGridView1.Columns.Add("AccountStatus", "AccountStatus");

                        // Add the "Edit" button column
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(editButtonColumn);

                        // Handle the cell click event to open EditUser form when the "Edit" button is clicked
                        dataGridView1.CellClick += DataGridView1_CellClick;
                    }

                    while (reader.Read())
                    {
                        // Convert UserStatus and AccountStatus to meaningful strings
                        string userStatus = (reader.GetInt32(5) == 0) ? "Customer" : "Admin";
                        string accountStatus = (reader.GetInt32(6) == 0) ? "Not Active" : "Active";

                        // Add a row to the DataGridView with converted values
                        int rowIndex = dataGridView1.Rows.Add(
                            reader.GetInt32(0),     // UserID
                            reader.GetString(1),    // FullName
                            reader.GetString(2),    // Email
                            reader.GetString(3),    // PhoneNumber
                            reader.GetString(4),    // Password
                            reader.GetInt32(5),     // UserStatus
                            reader.GetInt32(6)      // AccountStatus
                        );
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "Edit" button is clicked (assuming it's the last column)
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                // Get the UserID of the selected user
                int userID = (int)dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value;

                // Open the EditUser form with the selected user's information
                EditUser editUserForm = new EditUser(userID);
                editUserForm.Show();
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            // Call LoadUserData with the search text when the text in the search bar changes
            LoadUserData(SearchBar.Text);
        }
    }
}
