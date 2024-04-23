namespace Ecommerce
{
    partial class ProductEditForm
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
            label1 = new Label();
            panel1 = new Panel();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 5);
            label1.Name = "label1";
            label1.Size = new Size(256, 25);
            label1.TabIndex = 1;
            label1.Text = "PRODUCT UPDATE FORM";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(70, 5, 70, 5);
            panel1.Size = new Size(402, 33);
            panel1.TabIndex = 2;
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
            panel2.Size = new Size(402, 261);
            panel2.TabIndex = 3;
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
            PUFsubmit.Location = new Point(110, 204);
            PUFsubmit.Name = "PUFsubmit";
            PUFsubmit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PUFsubmit.Size = new Size(180, 45);
            PUFsubmit.TabIndex = 7;
            PUFsubmit.Text = "Submit";
            PUFsubmit.Click += PUFsubmit_Click;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F);
            txtProductName.Location = new Point(139, 38);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(237, 29);
            txtProductName.TabIndex = 6;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Segoe UI", 12F);
            txtStockQuantity.Location = new Point(139, 139);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(237, 29);
            txtStockQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(139, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 29);
            txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 143);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 2;
            label4.Text = "Stock Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 1;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 0;
            label2.Text = "Product Name";
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 294);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStockQuantity;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2Button PUFsubmit;
    }
}