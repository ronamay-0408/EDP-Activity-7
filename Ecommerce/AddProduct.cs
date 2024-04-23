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
    public partial class AddProduct : Form
    {
        private const string ConnectionString = "Server=localhost; database=ecomm; uid=root; pwd=1234;";
        private ProductInformation productInfoForm;

        public AddProduct(ProductInformation productInfoForm)
        {
            InitializeComponent();
            this.productInfoForm = productInfoForm;
        }

        private void PUFsubmit_Click(object sender, EventArgs e)
        {
            // Call the function to add a new product
            AddNewProduct();
        }

        private void AddNewProduct()
        {
            try
            {
                // Get values from textboxes
                string productName = txtProductName.Text;
                string priceText = txtPrice.Text;
                string stockQuantityText = txtStockQuantity.Text;

                // Check for missing textboxes
                if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(stockQuantityText))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse values
                decimal price = decimal.Parse(priceText);
                int stockQuantity = int.Parse(stockQuantityText);

                // SQL query to insert a new product
                string query = "INSERT INTO Products (ProductName, Price, StockQuantity) VALUES (@ProductName, @Price, @StockQuantity)";
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Product added successfully!");

                        // Clear the textboxes after successful insertion
                        ClearTextBoxes();

                        // Close the AddProduct form
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to clear the textboxes
        private void ClearTextBoxes()
        {
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStockQuantity.Text = string.Empty;
        }
    }
}
