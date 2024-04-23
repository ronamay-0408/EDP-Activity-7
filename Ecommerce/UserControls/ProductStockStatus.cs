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
using ClosedXML.Excel;
using System.IO;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ecommerce.UserControls
{
    public partial class ProductStockStatus : UserControl
    {
        private string excelFilePath;
        public ProductStockStatus()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        private void PopProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected filter value from the ComboBox
            string selectedFilter = PopProductFilter.SelectedItem.ToString();

            // Construct the SQL query string based on the selected filter
            string query = "";

            switch (selectedFilter)
            {
                case "ALL":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus";
                    break;
                case "5":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 5";
                    break;
                case "10":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 10";
                    break;
                case "15":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 15";
                    break;
                case "20":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 20";
                    break;
                case "25":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 25";
                    break;
                case "30":
                    query = "SELECT ProductName, StockQuantity, OrderQuantity FROM ProductStockStatus WHERE OrderQuantity <= 30";
                    break;
            }

            string server = "localhost";
            string database = "ecomm";
            string uid = "root";
            string password = "1234";
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;

            // Execute the query and update the existing DataGridView based on the selected filter
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Assuming DataGridView1 is a DataGridView in the ProductStockStatus user control
                    DataGridView dataGridView1 = DataGridView1;

                    // Clear existing rows in DataGridView
                    dataGridView1.Rows.Clear();

                    // Read data and add rows to the DataGridView
                    while (reader.Read())
                    {
                        string productName = reader.GetString(0); // Retrieve ProductName as a string
                        int stockQuantity = reader.GetInt32(1); // Retrieve StockQuantity as an integer
                        int orderQuantity = reader.GetInt32(2); // Retrieve OrderQuantity as an integer

                        // Add a row to the existing DataGridView
                        dataGridView1.Rows.Add(productName, stockQuantity, orderQuantity);
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls"; // Filter to only show Excel files
            openFileDialog.Title = "Select Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelFilePath = openFileDialog.FileName;
                txtFileName.Text = Path.GetFileName(excelFilePath); // Display only the file name in the TextBox
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(excelFilePath))
                {
                    MessageBox.Show("Please select an Excel file.");
                    return;
                }

                // Export data from DataGridView to the selected Excel file
                ExportToExcel(excelFilePath); // Only passing one parameter here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportToExcel(string browseFilePath)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook newWorkbook = excelApp.Workbooks.Add(); // Create a new workbook
                Excel.Worksheet reportWorksheet = newWorkbook.Sheets[1]; // Sheet1 for report
                Excel.Worksheet graphWorksheet = newWorkbook.Sheets.Add(); // Add a new sheet for the graph
                // Name the new sheet as "Chart"
                graphWorksheet.Name = "Report Chart";

                // Copy content from browse file to the new workbook
                Excel.Workbook browseWorkbook = excelApp.Workbooks.Open(browseFilePath);
                Excel.Worksheet browseWorksheet = browseWorkbook.Sheets[1]; // Assuming the content is in the first sheet

                int browseRows = browseWorksheet.UsedRange.Rows.Count;
                int browseColumns = browseWorksheet.UsedRange.Columns.Count;

                Excel.Range browseRange = browseWorksheet.Range[
                    browseWorksheet.Cells[1, 1],
                    browseWorksheet.Cells[browseRows, browseColumns]
                ];

                Excel.Range destinationRange = reportWorksheet.Cells[1, 1];
                browseRange.Copy(destinationRange); // Copy content to report worksheet

                // Preserve column widths
                for (int col = 1; col <= browseColumns; col++)
                {
                    reportWorksheet.Columns[col].ColumnWidth = browseWorksheet.Columns[col].ColumnWidth;
                }

                // Add current date to the worksheet
                int currentDateColumn = 4; // Column 4
                int currentDateRow = 5; // Row 5
                string currentDate = DateTime.Now.ToString("ddd, MMMM dd, yyyy");
                reportWorksheet.Cells[currentDateRow, currentDateColumn].Value = currentDate;

                browseWorkbook.Close(false); // Close the browse workbook without saving changes

                int startRow = 11; // Row 11
                int productNameColumn = 5; // Column A
                int orderQuantityColumn = 6; // Column B

                int rowIndex = startRow;
                foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                {
                    if (!dataGridViewRow.IsNewRow)
                    {
                        // Check if the cell value is not null before accessing it
                        if (dataGridViewRow.Cells[0].Value != null)
                        {
                            string productName = dataGridViewRow.Cells[0].Value.ToString();
                            int orderQuantity = Convert.ToInt32(dataGridViewRow.Cells[2].Value);

                            // Check if order quantity is greater than 10
                            if (orderQuantity > 10)
                            {
                                // Write data to report worksheet
                                reportWorksheet.Cells[rowIndex, productNameColumn].Value = productName;
                                reportWorksheet.Cells[rowIndex, orderQuantityColumn].Value = orderQuantity;
                                rowIndex++;
                            }
                        }
                    }
                }

                // Create a chart on the graph worksheet
                Excel.ChartObjects xlCharts = (Excel.ChartObjects)graphWorksheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObj = xlCharts.Add(100, 100, 600, 400);
                Excel.Chart chart = chartObj.Chart;

                // Set the chart data range from the report worksheet, including product names and order quantities
                Excel.Range productNameRange = reportWorksheet.Range[reportWorksheet.Cells[startRow, productNameColumn], reportWorksheet.Cells[rowIndex - 1, productNameColumn]];
                Excel.Range orderQuantityRange = reportWorksheet.Range[reportWorksheet.Cells[startRow, orderQuantityColumn], reportWorksheet.Cells[rowIndex - 1, orderQuantityColumn]];

                Excel.Range chartRange = reportWorksheet.Range[productNameRange, orderQuantityRange];
                chart.SetSourceData(chartRange);

                // Set chart type
                chart.ChartType = Excel.XlChartType.xlColumnClustered;

                // Set chart title
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Order Quantity Distribution";

                // Set axis labels
                chart.Axes(Excel.XlAxisType.xlCategory).CategoryNames = productNameRange;
                chart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
                chart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Text = "Order Quantity";


                // Generate a new file name based on the current date and time
                string currentDateFormatted = DateTime.Now.ToString("MM-dd-yyyy");
                string fileName = $"ProductStockReport_{currentDateFormatted}.xlsx";
                string newFilePath = Path.Combine(Path.GetDirectoryName(browseFilePath), fileName);

                // Save the workbook with the new file name
                newWorkbook.SaveAs(newFilePath);

                newWorkbook.Close();
                excelApp.Quit();

                MessageBox.Show("Excel report generated successfully at: " + newFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to Excel: " + ex.Message);
            }
        }

    }
}
