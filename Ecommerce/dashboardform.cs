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
    public partial class dashboardform : Form
    {
        public dashboardform()
        {
            InitializeComponent();
            UpdateOrderReceivedLabel();
            UpdateTotalSalesLabel(); // Call the method to update TotalSalesLabel
            UpdateRevenueLabel(); // 5%

            UpdateAccountsLabel();
        }

        private void UpdateOrderReceivedLabel()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            string query = "SELECT COUNT(*) FROM orderdetails"; // Assuming 'orderdetails' is the table name

            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int totalOrders = Convert.ToInt32(command.ExecuteScalar());
                    OrderReceivedLabel.Text = " " + totalOrders;
                }
            }
        }

        private void UpdateTotalSalesLabel()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            string totalSalesQuery = "SELECT SUM(p.Price * od.Quantity) " +
                                     "FROM OrderDetails od " +
                                     "JOIN Products p ON od.ProductID = p.ProductID";

            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(totalSalesQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalSales = Convert.ToDecimal(result);
                        TotalSalesLabel.Text = "" + totalSales.ToString("0.00");
                    }
                    else
                    {
                        TotalSalesLabel.Text = "$0.00";
                    }
                }
            }
        }

        private void UpdateRevenueLabel()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            string revenueQuery = "SELECT SUM(p.Price * od.Quantity * 0.05) " +
                                  "FROM OrderDetails od " +
                                  "JOIN Products p ON od.ProductID = p.ProductID";

            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(revenueQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalRevenue = Convert.ToDecimal(result);
                        RevenueLabel.Text = "" + totalRevenue.ToString("0.00");
                    }
                    else
                    {
                        RevenueLabel.Text = "$0.00";
                    }
                }
            }
        }

        private void UpdateAccountsLabel()
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = $"Server={server}; database={database}; uid={uid}; pwd={password}";

            string accountsCountQuery = "SELECT COUNT(*) FROM Users";

            using (MySqlConnection connection = new MySqlConnection(constring))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(accountsCountQuery, connection))
                {
                    int totalAccounts = Convert.ToInt32(command.ExecuteScalar());
                    AccountsLabel.Text = "" + totalAccounts;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OrderReceivedLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalSalesLabel_Click(object sender, EventArgs e)
        {

        }

        private void RevenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalProfitLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccountsLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Define your data
            string[] labels = { "Order Received", "Total Sales", "Revenue", "Accounts" };
            decimal[] values = { Convert.ToDecimal(OrderReceivedLabel.Text.Trim()),
                         Convert.ToDecimal(TotalSalesLabel.Text.Trim()),
                         Convert.ToDecimal(RevenueLabel.Text.Trim()),
                         Convert.ToDecimal(AccountsLabel.Text.Trim()) };

            Graphics g = e.Graphics;
            int barWidth = 100; // Width of each bar
            int spacing = 20; // Spacing between bars
            int startX = 50; // X-coordinate to start drawing bars
            int startY = 200; // Y-coordinate to start drawing bars
            int maxValue = (int)values.Max(); // Get the maximum value to scale the bars

            // Draw labels
            for (int i = 0; i < labels.Length; i++)
            {
                g.DrawString(labels[i], Font, Brushes.Black, startX + (barWidth + spacing) * i, startY + 20);
            }

            // Draw bars
            for (int i = 0; i < values.Length; i++)
            {
                int barHeight = (int)(values[i] / maxValue * 100); // Scale the height of the bar
                g.FillRectangle(Brushes.Blue, startX + (barWidth + spacing) * i, startY - barHeight, barWidth, barHeight);
                g.DrawString(values[i].ToString(), Font, Brushes.Black, startX + (barWidth + spacing) * i, startY - barHeight - 20);
            }
        }
    }
}
