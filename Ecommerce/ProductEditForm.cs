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
    public partial class ProductEditForm : Form
    {
        private int productId; // Add a field to store the product ID
        public ProductEditForm()
        {
            InitializeComponent();
        }

        // Add a constructor that takes a product ID
        public ProductEditForm(int productId) : this()
        {
            this.productId = productId;
            LoadProductData(); // Load data based on the provided product ID
        }
        private void LoadProductData()
        {
            // Use the productId to retrieve product data from the database
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = $"SELECT * FROM products WHERE ProductID = {productId}";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Set the form controls based on retrieved data
                        ProductName = reader.GetString("ProductName");
                        Price = reader.GetDecimal("Price");
                        StockQuantity = reader.GetInt32("StockQuantity"); // Corrected column name
                    }
                }
            }
        }


        public string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }

        public decimal Price
        {
            get { return Convert.ToDecimal(txtPrice.Text); }
            set { txtPrice.Text = value.ToString(); }
        }

        public int StockQuantity
        {
            get { return Convert.ToInt32(txtStockQuantity.Text); }
            set { txtStockQuantity.Text = value.ToString(); }
        }

        private void PUFsubmit_Click(object sender, EventArgs e)
        {
            // Update the product in the database
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = $"UPDATE products SET ProductName = @productName, Price = @price, StockQuantity = @stockQuantity WHERE ProductID = {productId}";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@productName", ProductName);
                    cmd.Parameters.AddWithValue("@price", Price);
                    cmd.Parameters.AddWithValue("@stockQuantity", StockQuantity);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully");
                        this.Close(); // Close the form after a successful update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product");
                    }
                }
            }
        }
    }
}
