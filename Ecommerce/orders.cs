using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Ecommerce
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();

            UserControls.customerorders uc = new UserControls.customerorders();
            addUserControl(uc);

            // Load data into DataGridView when the form is loaded
            LoadDataIntoDataGridView();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            GenerateReport.Controls.Clear();
            GenerateReport.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void LoadDataIntoDataGridView()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT OrderID, FullName, ProductName, Price, Quantity, Subtotal, Revenue, OrderDate FROM CustomerOrders"; // Include Subtotal and Revenue columns
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Assuming DataGridView1 is a DataGridView in the customerorders user control
                    DataGridView dataGridView1 = ((UserControls.customerorders)GenerateReport.Controls[0]).DataGridView1;

                    dataGridView1.Columns.Add("OrderID", "OrderID");
                    dataGridView1.Columns.Add("FullName", "FullName");
                    dataGridView1.Columns.Add("ProductName", "ProductName"); // Add ProductName column
                    dataGridView1.Columns.Add("Price", "Price"); // Add Price column
                    dataGridView1.Columns.Add("Quantity", "Quantity"); // Add Quantity column
                    dataGridView1.Columns.Add("Subtotal", "Subtotal"); // Add Subtotal column
                    dataGridView1.Columns.Add("Revenue", "Revenue"); // Add Revenue column
                    dataGridView1.Columns.Add("OrderDate", "OrderDate");

                    while (reader.Read())
                    {
                        // Assuming OrderID is numeric, use GetInt32 instead of GetDecimal
                        int orderId = reader.GetInt32(0);

                        // Assuming FullName is a string, use GetString directly
                        string fullName = reader.GetString(1);

                        // Assuming ProductName is a string, use GetString directly
                        string productName = reader.GetString(2);

                        // Assuming Price is a decimal, use GetDecimal directly
                        decimal price = reader.GetDecimal(3);

                        // Assuming Quantity is numeric, use GetInt32 instead of GetDecimal
                        int quantity = reader.GetInt32(4);

                        // Assuming Subtotal is a decimal, use GetDecimal directly
                        decimal subtotal = reader.GetDecimal(5);

                        // Assuming Revenue is a decimal, use GetDecimal directly
                        decimal revenue = reader.GetDecimal(6);

                        // Assuming OrderDate is a DateTime, use GetDateTime directly
                        DateTime orderDate = reader.GetDateTime(7);

                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(orderId, fullName, productName, price, quantity, subtotal, revenue, orderDate);
                    }
                }
            }

        }


        private void btnHVO_Click(object sender, EventArgs e)
        {
            UserControls.HighValueOrders uc = new UserControls.HighValueOrders();
            addUserControl(uc);

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {

                con.Open();
                string query = "select * from highvalueorders";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Assuming DataGridView1 is a DataGridView in the customerorders user control
                    DataGridView dataGridView1 = uc.DataGridView1;

                    dataGridView1.Columns.Add("TotalValue", "TotalValue");

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(
                            reader.GetDecimal(1)    // TotalValue
                        );
                    }
                }
            }

        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            UserControls.customerorders uc = new UserControls.customerorders();
            addUserControl(uc);

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = "SELECT OrderID, FullName, ProductName, Price, Quantity, Subtotal, Revenue, OrderDate FROM CustomerOrders"; // Include Subtotal and Revenue columns
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Assuming DataGridView1 is a DataGridView in the customerorders user control
                    DataGridView dataGridView1 = ((UserControls.customerorders)GenerateReport.Controls[0]).DataGridView1;

                    dataGridView1.Columns.Add("OrderID", "OrderID");
                    dataGridView1.Columns.Add("FullName", "FullName");
                    dataGridView1.Columns.Add("ProductName", "ProductName"); // Add ProductName column
                    dataGridView1.Columns.Add("Price", "Price"); // Add Price column
                    dataGridView1.Columns.Add("Quantity", "Quantity"); // Add Quantity column
                    dataGridView1.Columns.Add("Subtotal", "Subtotal"); // Add Subtotal column
                    dataGridView1.Columns.Add("Revenue", "Revenue"); // Add Revenue column
                    dataGridView1.Columns.Add("OrderDate", "OrderDate");

                    while (reader.Read())
                    {
                        // Assuming OrderID is numeric, use GetInt32 instead of GetDecimal
                        int orderId = reader.GetInt32(0);

                        // Assuming FullName is a string, use GetString directly
                        string fullName = reader.GetString(1);

                        // Assuming ProductName is a string, use GetString directly
                        string productName = reader.GetString(2);

                        // Assuming Price is a decimal, use GetDecimal directly
                        decimal price = reader.GetDecimal(3);

                        // Assuming Quantity is numeric, use GetInt32 instead of GetDecimal
                        int quantity = reader.GetInt32(4);

                        // Assuming Subtotal is a decimal, use GetDecimal directly
                        decimal subtotal = reader.GetDecimal(5);

                        // Assuming Revenue is a decimal, use GetDecimal directly
                        decimal revenue = reader.GetDecimal(6);

                        // Assuming OrderDate is a DateTime, use GetDateTime directly
                        DateTime orderDate = reader.GetDateTime(7);

                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(orderId, fullName, productName, price, quantity, subtotal, revenue, orderDate);
                    }
                }
            }

        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            UserControls.OrderDetails uc = new UserControls.OrderDetails();
            addUserControl(uc);

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string query = @"
            SELECT p.ProductName, p.Price, od.Quantity, o.OrderDate
            FROM orderdetails od
            INNER JOIN products p ON od.ProductID = p.ProductID
            INNER JOIN orders o ON od.OrderID = o.OrderID";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Assuming DataGridView1 is a DataGridView in the customerorders user control
                    DataGridView dataGridView1 = uc.DataGridView1;

                    dataGridView1.Columns.Add("ProductName", "ProductName");
                    dataGridView1.Columns.Add("Price", "Price");
                    dataGridView1.Columns.Add("Quantity", "Quantity");
                    dataGridView1.Columns.Add("OrderDate", "OrderDate");

                    while (reader.Read())
                    {
                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(
                            reader.GetString(0),           // ProductName
                            reader.GetDecimal(1),          // Price
                            reader.GetDecimal(2),          // Quantity
                            reader.GetDateTime(3).ToString("yyyy-MM-dd")  // OrderDate
                        );
                    }
                }
            }
        }
    }
}
