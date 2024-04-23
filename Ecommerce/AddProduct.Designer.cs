namespace Ecommerce
{
    partial class AddProduct
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            PUFsubmit = new Guna.UI2.WinForms.Guna2Button();
            txtProductName = new TextBox();
            txtStockQuantity = new TextBox();
            txtPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(100, 5, 100, 5);
            panel1.Size = new Size(347, 33);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 5);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "ADD PRODUCT";
            // 
            // panel2
            // 
            panel2.Controls.Add(PUFsubmit);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(txtStockQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 280);
            panel2.TabIndex = 4;
            // 
            // PUFsubmit
            // 
            PUFsubmit.BorderRadius = 5;
            PUFsubmit.CustomizableEdges = customizableEdges1;
            PUFsubmit.DisabledState.BorderColor = Color.DarkGray;
            PUFsubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            PUFsubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PUFsubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PUFsubmit.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PUFsubmit.ForeColor = Color.White;
            PUFsubmit.Location = new Point(114, 214);
            PUFsubmit.Name = "PUFsubmit";
            PUFsubmit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PUFsubmit.Size = new Size(130, 45);
            PUFsubmit.TabIndex = 14;
            PUFsubmit.Text = "ADD";
            PUFsubmit.Click += PUFsubmit_Click;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(143, 48);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(187, 29);
            txtProductName.TabIndex = 13;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Segoe UI", 12F);
            txtStockQuantity.Location = new Point(143, 149);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(187, 29);
            txtStockQuantity.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(143, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(187, 29);
            txtPrice.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 153);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 10;
            label4.Text = "Stock Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 102);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 8;
            label2.Text = "Product Name";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 313);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button PUFsubmit;
        private TextBox txtProductName;
        private TextBox txtStockQuantity;
        private TextBox txtPrice;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}