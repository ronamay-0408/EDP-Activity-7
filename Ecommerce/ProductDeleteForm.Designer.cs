namespace Ecommerce.UserControls
{
    partial class ProductDeleteForm
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
            panel1 = new Panel();
            label1 = new Label();
            labelproductid = new Label();
            Nobtn = new Guna.UI2.WinForms.Guna2Button();
            Yesbtn = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(120, 5, 120, 5);
            panel1.Size = new Size(411, 33);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 5);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 1;
            label1.Text = "PRODUCT DELETE";
            // 
            // labelproductid
            // 
            labelproductid.AutoSize = true;
            labelproductid.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelproductid.Location = new Point(164, 81);
            labelproductid.Name = "labelproductid";
            labelproductid.Size = new Size(87, 19);
            labelproductid.TabIndex = 4;
            labelproductid.Text = "Product ID";
            // 
            // Nobtn
            // 
            Nobtn.BorderRadius = 5;
            Nobtn.CustomizableEdges = customizableEdges1;
            Nobtn.DisabledState.BorderColor = Color.DarkGray;
            Nobtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Nobtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Nobtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Nobtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nobtn.ForeColor = Color.White;
            Nobtn.Location = new Point(112, 158);
            Nobtn.Name = "Nobtn";
            Nobtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Nobtn.Size = new Size(84, 45);
            Nobtn.TabIndex = 8;
            Nobtn.Text = "No";
            // 
            // Yesbtn
            // 
            Yesbtn.BorderRadius = 5;
            Yesbtn.CustomizableEdges = customizableEdges3;
            Yesbtn.DisabledState.BorderColor = Color.DarkGray;
            Yesbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Yesbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Yesbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Yesbtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yesbtn.ForeColor = Color.White;
            Yesbtn.Location = new Point(216, 158);
            Yesbtn.Name = "Yesbtn";
            Yesbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Yesbtn.Size = new Size(84, 45);
            Yesbtn.TabIndex = 9;
            Yesbtn.Text = "Yes";
            // 
            // ProductDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 229);
            Controls.Add(Yesbtn);
            Controls.Add(Nobtn);
            Controls.Add(labelproductid);
            Controls.Add(panel1);
            Name = "ProductDeleteForm";
            Text = "ProductDeleteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelproductid;
        private Guna.UI2.WinForms.Guna2Button Nobtn;
        private Guna.UI2.WinForms.Guna2Button Yesbtn;
    }
}