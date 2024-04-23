using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ecommerce.UserControls
{
    public partial class OrderDetails : UserControl
    {
        private string templateFilePath = "";
        public OrderDetails()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        private void MonthYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter data based on the selected year
            string selectedYear = MonthYearFilter.SelectedItem.ToString();

            // Construct the WHERE clause to filter by year
            string whereClause = "";
            if (selectedYear != "ALL")
            {
                whereClause = "WHERE YEAR(OrderDate) = " + selectedYear;
            }

            // Refresh the data based on the filter
            RefreshData(whereClause);
        }

        private void RefreshData(string whereClause)
        {
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
                    INNER JOIN orders o ON od.OrderID = o.OrderID " + whereClause;

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing rows in DataGridView
                    dataGridView1.Rows.Clear();

                    // Add data to the DataGridView
                    while (reader.Read())
                    {
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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(templateFilePath))
                {
                    MessageBox.Show("Please select a template file.");
                    return;
                }

                // Get the selected year from the combo box
                string selectedYear = MonthYearFilter.SelectedItem.ToString();

                // Get the data based on the selected year
                DataTable data = GetData(selectedYear);

                // Generate Excel report with dynamic file name
                GenerateExcelReport(data, selectedYear, templateFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetData(string selectedYear)
        {
            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                // Construct the SQL query to select the sum of prices for each month in the selected year
                string query = "SELECT MONTH(OrderDate) AS Month, SUM(Price) AS Sale " +
                               "FROM CustomerOrders " +
                               "WHERE YEAR(OrderDate) = @Year " +
                               "GROUP BY MONTH(OrderDate)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Add parameter for the selected year
                    cmd.Parameters.AddWithValue("@Year", selectedYear);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Load data into DataTable
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        private void GenerateExcelReport(DataTable data, string selectedYear, string templateFilePath)
        {
            try
            {
                // Get the current date in the desired format
                string currentDate = DateTime.Now.ToString("ddd, MMMM dd, yyyy");

                // Create Excel application object
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Make Excel visible for demonstration purposes

                // Load the existing workbook
                Excel.Workbook existingWorkbook = excelApp.Workbooks.Open(templateFilePath);

                // Get the first worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)existingWorkbook.Worksheets[1];

                // Starting location of the current date
                int currentDateColumn = 4; // Column 4
                int currentDateRow = 5; // Row 5

                // Add current date to the worksheet
                worksheet.Cells[currentDateRow, currentDateColumn].Value = currentDate;

                // Write data to the worksheet starting from row 11
                // Starting location of the records
                int startRow = 11; // Start from row 11
                decimal totalSale = 0; // Initialize total sale
                foreach (DataRow row in data.Rows)
                {
                    int monthValue = Convert.ToInt32(row["Month"]);
                    string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthValue);

                    // Output the Month name in column 5 (index 4) and Sale value in column 6 (index 5)
                    worksheet.Cells[startRow, 5].Value = monthName;
                    worksheet.Cells[startRow, 6].Value = Convert.ToDecimal(row["Sale"]);

                    // Add the sale value to the total sale
                    totalSale += Convert.ToDecimal(row["Sale"]);

                    startRow++;
                }

                // Output the total sale in the last row of the worksheet
                worksheet.Cells[startRow + 1, 5].Value = "Total Sale:";
                worksheet.Cells[startRow + 1, 6].Value = totalSale;

                // Add a new worksheet for the chart
                Excel.Worksheet chartWorksheet = (Excel.Worksheet)existingWorkbook.Worksheets.Add();
                chartWorksheet.Name = "Report Chart";

                // Add a chart to the new worksheet
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartWorksheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObject = chartObjects.Add(100, 80, 600, 400);
                Excel.Chart chart = chartObject.Chart;

                // Define the range for the chart
                Excel.Range chartRange = worksheet.Range[worksheet.Cells[11, 5], worksheet.Cells[startRow, 6]];

                // Set source data and chart type
                chart.SetSourceData(chartRange, Type.Missing);
                chart.ChartType = Excel.XlChartType.xlColumnClustered;

                // Set X-axis and Y-axis labels
                chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
                chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "Month";
                chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).HasTitle = true;
                chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary).AxisTitle.Text = "Sale";

                // Customize category labels to show month names
                chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary).CategoryNames = worksheet.Range[worksheet.Cells[11, 5], worksheet.Cells[startRow, 5]];

                // Construct the file name for the new Excel file
                string fileName = $"SalesReport_{selectedYear}.xlsx";
                string newFilePath = Path.Combine(Path.GetDirectoryName(templateFilePath), fileName);

                // Save the workbook with the new file name
                existingWorkbook.SaveAs(newFilePath);

                MessageBox.Show("Excel report generated successfully at: " + newFilePath);

                // Close the workbook and Excel application
                existingWorkbook.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Excel report: " + ex.Message);
            }
        }
    }
}
