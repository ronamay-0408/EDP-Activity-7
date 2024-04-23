namespace Ecommerce.UserControls
{
    partial class OrderDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel7 = new Panel();
            txtFileName = new TextBox();
            panel6 = new Panel();
            btnBrowse = new Button();
            panel5 = new Panel();
            reportBtn = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            MonthYearFilter = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(890, 517);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 56);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 20, 50, 20);
            panel2.Size = new Size(880, 456);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(50, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(780, 416);
            dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 5);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(880, 51);
            panel3.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtFileName);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(147, 10);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5, 1, 5, 0);
            panel7.Size = new Size(571, 31);
            panel7.TabIndex = 3;
            // 
            // txtFileName
            // 
            txtFileName.Dock = DockStyle.Fill;
            txtFileName.Font = new Font("Segoe UI", 11F);
            txtFileName.Location = new Point(5, 1);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(561, 27);
            txtFileName.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBrowse);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(718, 10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5, 1, 5, 3);
            panel6.Size = new Size(45, 31);
            panel6.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.FlatStyle = FlatStyle.Popup;
            btnBrowse.Location = new Point(5, 1);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(35, 27);
            btnBrowse.TabIndex = 11;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(reportBtn);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(763, 10);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5, 1, 5, 3);
            panel5.Size = new Size(107, 31);
            panel5.TabIndex = 1;
            // 
            // reportBtn
            // 
            reportBtn.BackColor = Color.Transparent;
            reportBtn.BorderColor = SystemColors.ActiveCaption;
            reportBtn.BorderRadius = 1;
            reportBtn.BorderThickness = 1;
            reportBtn.CheckedState.CustomBorderColor = Color.DarkOrange;
            reportBtn.CheckedState.FillColor = Color.Transparent;
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.CustomBorderColor = Color.Transparent;
            reportBtn.CustomBorderThickness = new Padding(0, 0, 0, 3);
            reportBtn.CustomizableEdges = customizableEdges1;
            reportBtn.DisabledState.BorderColor = Color.DarkGray;
            reportBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            reportBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            reportBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            reportBtn.Dock = DockStyle.Fill;
            reportBtn.FillColor = Color.MediumSeaGreen;
            reportBtn.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportBtn.ForeColor = Color.White;
            reportBtn.HoverState.CustomBorderColor = Color.Transparent;
            reportBtn.Location = new Point(5, 1);
            reportBtn.Name = "reportBtn";
            reportBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            reportBtn.Size = new Size(97, 27);
            reportBtn.TabIndex = 8;
            reportBtn.Text = "Export";
            reportBtn.Click += reportBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(MonthYearFilter);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 1, 5, 0);
            panel4.Size = new Size(137, 31);
            panel4.TabIndex = 0;
            // 
            // MonthYearFilter
            // 
            MonthYearFilter.Dock = DockStyle.Fill;
            MonthYearFilter.Font = new Font("Segoe UI", 11F);
            MonthYearFilter.FormattingEnabled = true;
            MonthYearFilter.Items.AddRange(new object[] { "ALL", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036" });
            MonthYearFilter.Location = new Point(5, 1);
            MonthYearFilter.Name = "MonthYearFilter";
            MonthYearFilter.Size = new Size(127, 28);
            MonthYearFilter.TabIndex = 9;
            MonthYearFilter.SelectedIndexChanged += MonthYearFilter_SelectedIndexChanged;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderDetails";
            Padding = new Padding(5);
            Size = new Size(900, 527);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Button btnBrowse;
        private TextBox txtFileName;
        private ComboBox MonthYearFilter;
        private Guna.UI2.WinForms.Guna2Button reportBtn;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}
