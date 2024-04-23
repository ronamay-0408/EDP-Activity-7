namespace Ecommerce
{
    partial class orders
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnorders = new Guna.UI2.WinForms.Guna2Button();
            btnHVO = new Guna.UI2.WinForms.Guna2Button();
            btnOrderDetails = new Guna.UI2.WinForms.Guna2Button();
            GenerateReport = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 51);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnorders);
            panel2.Controls.Add(btnHVO);
            panel2.Controls.Add(btnOrderDetails);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 52);
            panel2.TabIndex = 3;
            // 
            // btnorders
            // 
            btnorders.BorderThickness = 1;
            btnorders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnorders.Checked = true;
            btnorders.CheckedState.CustomBorderColor = Color.DarkOrange;
            btnorders.CheckedState.FillColor = Color.Transparent;
            btnorders.CustomBorderColor = Color.Transparent;
            btnorders.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnorders.CustomizableEdges = customizableEdges1;
            btnorders.DisabledState.BorderColor = Color.DarkGray;
            btnorders.DisabledState.CustomBorderColor = Color.DarkGray;
            btnorders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnorders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnorders.FillColor = Color.Transparent;
            btnorders.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnorders.ForeColor = Color.Black;
            btnorders.HoverState.CustomBorderColor = Color.DarkOrange;
            btnorders.Location = new Point(72, 16);
            btnorders.Name = "btnorders";
            btnorders.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnorders.Size = new Size(106, 35);
            btnorders.TabIndex = 4;
            btnorders.Text = "Orders";
            btnorders.Click += btnorders_Click;
            // 
            // btnHVO
            // 
            btnHVO.BorderThickness = 1;
            btnHVO.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnHVO.CheckedState.CustomBorderColor = Color.DarkOrange;
            btnHVO.CheckedState.FillColor = Color.Transparent;
            btnHVO.CustomBorderColor = Color.Transparent;
            btnHVO.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnHVO.CustomizableEdges = customizableEdges3;
            btnHVO.DisabledState.BorderColor = Color.DarkGray;
            btnHVO.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHVO.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHVO.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHVO.FillColor = Color.Transparent;
            btnHVO.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHVO.ForeColor = Color.Black;
            btnHVO.HoverState.CustomBorderColor = Color.DarkOrange;
            btnHVO.Location = new Point(383, 16);
            btnHVO.Name = "btnHVO";
            btnHVO.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHVO.Size = new Size(177, 35);
            btnHVO.TabIndex = 6;
            btnHVO.Text = "High Value Orders";
            btnHVO.Click += btnHVO_Click;
            // 
            // btnOrderDetails
            // 
            btnOrderDetails.BorderThickness = 1;
            btnOrderDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnOrderDetails.CheckedState.CustomBorderColor = Color.DarkOrange;
            btnOrderDetails.CheckedState.FillColor = Color.Transparent;
            btnOrderDetails.CustomBorderColor = Color.Transparent;
            btnOrderDetails.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnOrderDetails.CustomizableEdges = customizableEdges5;
            btnOrderDetails.DisabledState.BorderColor = Color.DarkGray;
            btnOrderDetails.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOrderDetails.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOrderDetails.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOrderDetails.FillColor = Color.Transparent;
            btnOrderDetails.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderDetails.ForeColor = Color.Black;
            btnOrderDetails.HoverState.CustomBorderColor = Color.DarkOrange;
            btnOrderDetails.Location = new Point(206, 16);
            btnOrderDetails.Name = "btnOrderDetails";
            btnOrderDetails.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnOrderDetails.Size = new Size(150, 35);
            btnOrderDetails.TabIndex = 5;
            btnOrderDetails.Text = "Order Details";
            btnOrderDetails.Click += btnOrderDetails_Click;
            // 
            // GenerateReport
            // 
            GenerateReport.BackColor = Color.Transparent;
            GenerateReport.Dock = DockStyle.Fill;
            GenerateReport.Location = new Point(0, 103);
            GenerateReport.Name = "GenerateReport";
            GenerateReport.Size = new Size(900, 527);
            GenerateReport.TabIndex = 4;
            // 
            // orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 630);
            Controls.Add(GenerateReport);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "orders";
            Text = "orders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnorders;
        private Guna.UI2.WinForms.Guna2Button btnOrderDetails;
        private Guna.UI2.WinForms.Guna2Button btnHVO;
        private Panel GenerateReport;
    }
}