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

namespace Ecommerce.UserControls
{
    public partial class products : UserControl
    {
        private ProductEditForm editForm;
        private ProductDeleteForm deleteForm;
        public products()
        {
            InitializeComponent();

            // Subscribe to the CellContentClick event
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            editForm = new ProductEditForm();
            deleteForm = new ProductDeleteForm();

            // Assuming dataGridView1 is the DataGridView you want to populate
            LoadDataIntoDataGridView(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any necessary logic for cell content click
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        private void LoadDataIntoDataGridView(DataGridView dataGridView, string searchText = "")
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "select * from products";

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Add a WHERE clause to filter products by name
                    query += $" WHERE ProductName LIKE '%{searchText}%'";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing columns before adding new ones to avoid duplication
                    dataGridView.Columns.Clear();

                    // Add columns
                    dataGridView.Columns.Add("ProductName", "ProductName");
                    dataGridView.Columns.Add("Price", "Price");
                    dataGridView.Columns.Add("StockQuality", "StockQuality");

                    // Add buttons
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(editButtonColumn);

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(deleteButtonColumn);

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView
                        int rowIndex = dataGridView.Rows.Add(
                            reader.GetString(1),    // Product Name
                            reader.GetDecimal(2),   // Price
                            reader.GetValue(3)      // Use GetValue to retrieve the value without specifying the type
                        );

                        // Set the Tag property for the cells to store the product ID
                        dataGridView.Rows[rowIndex].Cells["Edit"].Tag = reader.GetInt32(0); // Assuming the first column is the product ID
                        dataGridView.Rows[rowIndex].Cells["Delete"].Tag = reader.GetInt32(0); // Assuming the first column is the product ID
                    }

                    // Add event handler for CellContentClick for the entire grid
                    dataGridView.CellContentClick += DataGridView_CellContentClick;
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                // Check if the clicked cell is not null
                DataGridViewCell clickedCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (clickedCell != null)
                {
                    if (dataGridView.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        // Check if the Tag property is not null
                        if (clickedCell.Tag != null)
                        {
                            int productId = (int)clickedCell.Tag;

                            // Use the constructor that takes a product ID
                            ProductEditForm editForm = new ProductEditForm(productId);
                            editForm.ShowDialog();
                        }
                        else
                        {
                            // Handle the case when Tag is null (optional)
                            MessageBox.Show("Tag property is null for the 'Edit' cell.");
                        }
                    }
                    else if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
                    {
                        // Check if the Tag property is not null
                        if (clickedCell.Tag != null)
                        {
                            int productId = (int)clickedCell.Tag;

                            // Use the constructor without arguments
                            ProductDeleteForm deleteForm = new ProductDeleteForm(productId);
                            deleteForm.ShowDialog();
                        }
                        else
                        {
                            // Handle the case when Tag is null (optional)
                            MessageBox.Show("Tag property is null for the 'Delete' cell.");
                        }
                    }
                }
                else
                {
                    // Handle the case when clickedCell is null (optional)
                    MessageBox.Show("Clicked cell is null.");
                }
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            // Call the LoadDataIntoDataGridView method passing the DataGridView and search text
            LoadDataIntoDataGridView(dataGridView1, SearchBar.Text);
        }
    }
}
