using ClosedXML.Excel;
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
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Ecommerce.UserControls
{
    public partial class customerorders : UserControl
    {
        private string templateFilePath = "";
        public customerorders()
        {
            InitializeComponent();
        }

        private void values_label_Click(object sender, EventArgs e)
        {

        }

        private void MonthYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected month and year from the combo box
            string selectedMonthName = MonthYearFilter.SelectedItem.ToString();

            // If "ALL" is selected, set selectedMonth to 0 to indicate no specific month filter
            int selectedMonth = 0;
            if (selectedMonthName != "ALL")
            {
                // Map month names to their corresponding numeric values
                Dictionary<string, int> monthMap = new Dictionary<string, int>
                {
                    {"JANUARY", 1},
                    {"FEBRUARY", 2},
                    {"MARCH", 3},
                    {"APRIL", 4},
                    {"MAY", 5},
                    {"JUNE", 6},
                    {"JULY", 7},
                    {"AUGUST", 8},
                    {"SEPTEMBER", 9},
                    {"OCTOBER", 10},
                    {"NOVEMBER", 11},
                    {"DECEMBER", 12}
                };

                // Get the selected month and year from the combo box
                selectedMonth = monthMap[selectedMonthName];
            }

            int selectedYear = DateTime.Now.Year; // Assuming current year as default, you can replace it with the desired default year

            // Construct the start and end dates based on the selectedMonth
            DateTime startDate;
            DateTime endDate;
            if (selectedMonth == 0) // No specific month selected
            {
                startDate = new DateTime(selectedYear, 1, 1); // First day of the year
                endDate = new DateTime(selectedYear, 12, 31); // Last day of the year
            }
            else
            {
                startDate = new DateTime(selectedYear, selectedMonth, 1); // First day of the selected month
                endDate = startDate.AddMonths(1).AddDays(-1); // Last day of the selected month
            }

            // Construct the WHERE clause to filter by date range
            string whereClause = string.Format("OrderDate >= '{0}' AND OrderDate <= '{1}'", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

            // Construct the SQL query to select OrderID, FullName, ProductName, Price, Quantity, and OrderDate
            string query = string.Format("SELECT OrderID, FullName, ProductName, Price, Quantity, Subtotal, Revenue, OrderDate FROM CustomerOrders WHERE {0}", whereClause);

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            // Execute the query and update the existing DataGridView
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing rows in DataGridView
                    dataGridView1.Rows.Clear();

                    // Read data and add rows to the existing DataGridView
                    while (reader.Read())
                    {
                        int orderId = reader.GetInt32(0); // Retrieve OrderID as an integer
                        string fullName = reader.GetString(1); // Retrieve FullName as a string
                        string productName = reader.GetString(2); // Retrieve ProductName as a string
                        decimal price = reader.GetDecimal(3); // Retrieve Price as a decimal
                        int quantity = reader.GetInt32(4); // Retrieve Quantity as an integer
                        decimal subtotal = reader.GetDecimal(5);
                        decimal revenue = reader.GetDecimal(6);
                        DateTime orderDate = reader.GetDateTime(7); // Retrieve OrderDate as a DateTime

                        // Add a row to the existing DataGridView
                        dataGridView1.Rows.Add(orderId, fullName, productName, price, quantity, subtotal, revenue, orderDate);
                    }
                }
            }

        }

        private DataTable GetData(int selectedMonth)
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                // Construct the WHERE clause based on the selected month
                string whereClause = (selectedMonth == 0) ? "" : string.Format("WHERE MONTH(OrderDate) = {0}", selectedMonth);

                // Construct the SQL query
                string query = string.Format("SELECT OrderID, FullName, ProductName, Price, Quantity, Subtotal, Revenue, OrderDate FROM CustomerOrders {0}", whereClause);

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Load data into DataTable
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        private void GenerateExcelReport(DataTable data, string monthName, string templateFilePath)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            try
            {
                // Get the current date in the desired format
                string currentDate = DateTime.Now.ToString("ddd, MMMM dd, yyyy");

                // Get the current year
                int currentYear = DateTime.Now.Year;

                // Construct the file name with the selected month and current year
                string fileName = $"Report_{monthName}_{currentYear}.xlsx";
                string filePath = Path.Combine(Path.GetDirectoryName(templateFilePath), fileName);

                // Copy the template Excel file to the destination path
                File.Copy(templateFilePath, filePath, true);

                // Open the copied workbook
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                // Find the cells where you want to insert the current date and insert it
                worksheet.Cells[5, 4] = currentDate;

                // Starting location of the records
                int startRow = 11; // Start from row 11
                int startColumn = 4; // Start from column 4

                // Add data to the worksheet
                int row = startRow;
                double total = 0; // Initialize total price

                // Variables for tracking product revenue
                Dictionary<string, decimal> productRevenue = new Dictionary<string, decimal>();

                foreach (DataRow dr in data.Rows)
                {
                    // Assuming OrderID is in the first column, FullName in the second, ProductName in the third, Price in the fourth, Quantity in the fifth, Subtotal in the sixth, Revenue in the seventh, and OrderDate in the eighth
                    worksheet.Cells[row, startColumn] = dr["OrderID"].ToString();
                    worksheet.Cells[row, startColumn + 1] = dr["FullName"].ToString();
                    worksheet.Cells[row, startColumn + 2] = dr["ProductName"].ToString(); // Add ProductName
                    worksheet.Cells[row, startColumn + 3] = dr["Price"].ToString(); // Add Price
                    worksheet.Cells[row, startColumn + 4] = dr["Quantity"].ToString(); // Add Quantity
                    worksheet.Cells[row, startColumn + 5] = dr["Subtotal"].ToString(); // Add Subtotal
                    worksheet.Cells[row, startColumn + 6] = dr["Revenue"].ToString(); // Add Revenue
                    worksheet.Cells[row, startColumn + 7] = dr["OrderDate"].ToString(); // Add OrderDate

                    // Compute total price for each row
                    double subtotal = Convert.ToDouble(dr["Subtotal"]);
                    total += subtotal;

                    // Update product revenue
                    string productName = dr["ProductName"].ToString();
                    decimal revenue = Convert.ToDecimal(dr["Revenue"]);

                    if (productRevenue.ContainsKey(productName))
                        productRevenue[productName] += revenue;
                    else
                        productRevenue[productName] = revenue;

                    row++;
                }

                // Calculate total revenue
                decimal totalRevenue = productRevenue.Values.Sum();

                // Add total price and total revenue at the end of the Excel file
                worksheet.Cells[row + 1, startColumn + 2] = "Total Price:";
                worksheet.Cells[row + 1, startColumn + 3] = total;

                worksheet.Cells[row + 1, startColumn + 5] = "Total Revenue:";
                worksheet.Cells[row + 1, startColumn + 6] = totalRevenue;

                // Create a new worksheet for the chart
                Excel.Worksheet chartSheet = workbook.Worksheets.Add();
                chartSheet.Name = "Report Chart";

                // Insert product-wise revenue data into the chart worksheet
                int chartStartRow = 1;
                foreach (var item in productRevenue)
                {
                    chartSheet.Cells[chartStartRow, 1] = item.Key;
                    chartSheet.Cells[chartStartRow, 2] = item.Value;
                    chartStartRow++;
                }

                // Add a chart to the chart worksheet
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartSheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObject = chartObjects.Add(100, 100, 600, 400);
                Excel.Chart chart = chartObject.Chart;

                // Set chart data range
                Excel.Range chartRange = chartSheet.Range[chartSheet.Cells[1, 1], chartSheet.Cells[productRevenue.Count, 2]];
                chart.SetSourceData(chartRange);

                // Set chart type
                chart.ChartType = Excel.XlChartType.xlColumnClustered;

                // Set chart title
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Product Revenue";

                // Set axis titles
                chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
                chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "Product";
                chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
                chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "Revenue";

                // Save the workbook
                workbook.Save();

                MessageBox.Show("Excel report generated successfully at: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel report: " + ex.Message);
            }
            finally
            {
                // Close workbook and Excel application
                if (workbook != null)
                {
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(templateFilePath))
                {
                    MessageBox.Show("Please select a template file.");
                    return;
                }

                // Get the selected month from the combo box
                string selectedMonthName = MonthYearFilter.SelectedItem.ToString();

                // If "ALL" is selected, set selectedMonth to 0 to indicate no specific month filter
                int selectedMonth = 0;
                string monthName = "";
                if (selectedMonthName != "ALL")
                {
                    // Map month names to their corresponding numeric values
                    Dictionary<string, int> monthMap = new Dictionary<string, int>
                    {
                        {"JANUARY", 1},
                        {"FEBRUARY", 2},
                        {"MARCH", 3},
                        {"APRIL", 4},
                        {"MAY", 5},
                        {"JUNE", 6},
                        {"JULY", 7},
                        {"AUGUST", 8},
                        {"SEPTEMBER", 9},
                        {"OCTOBER", 10},
                        {"NOVEMBER", 11},
                        {"DECEMBER", 12}
                    };

                    // Get the selected month
                    selectedMonth = monthMap[selectedMonthName];
                    monthName = selectedMonthName;
                }
                else
                {
                    monthName = "ALL";
                }

                // Get the data based on the selected month
                DataTable data = GetData(selectedMonth);

                // Generate Excel report with dynamic file name and the template file path
                GenerateExcelReport(data, monthName, templateFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"; // Filter to only show Excel files
            openFileDialog.Title = "Select Excel Template File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templateFilePath = openFileDialog.FileName;
                txtFileName.Text = templateFilePath; // Display the selected file path in the text box
            }
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }
    }
}
