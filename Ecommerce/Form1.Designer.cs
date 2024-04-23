namespace Ecommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Minimize = new PictureBox();
            Maximize = new PictureBox();
            Exit_btn = new PictureBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnDashboard = new Button();
            panel8 = new Panel();
            UsersPage = new Button();
            panel7 = new Panel();
            btnProduct = new Button();
            panel10 = new Panel();
            btnOrder = new Button();
            panel3 = new Panel();
            pnSettings = new Button();
            panel11 = new Panel();
            pnAbout = new Button();
            panel12 = new Panel();
            panel9 = new Panel();
            pnlogout = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainpanel = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Maximize);
            panel1.Controls.Add(Exit_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1184, 15);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(20, 20);
            Minimize.TabIndex = 3;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // Maximize
            // 
            Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximize.Cursor = Cursors.Hand;
            Maximize.Image = (Image)resources.GetObject("Maximize.Image");
            Maximize.Location = new Point(1220, 15);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(20, 20);
            Maximize.TabIndex = 2;
            Maximize.TabStop = false;
            Maximize.Click += Maximize_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit_btn.Cursor = Cursors.Hand;
            Exit_btn.Image = (Image)resources.GetObject("Exit_btn.Image");
            Exit_btn.Location = new Point(1256, 15);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(20, 20);
            Exit_btn.TabIndex = 0;
            Exit_btn.TabStop = false;
            Exit_btn.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(65, 15);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 1;
            label1.Text = "BUMM - Bicol University Merge Merchandise";
            label1.Click += label1_Click;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(19, 9);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(40, 34);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel11);
            sidebar.Controls.Add(panel12);
            sidebar.Controls.Add(panel9);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 50);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(238, 645);
            sidebar.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 108);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnDashboard);
            panel2.Location = new Point(0, 114);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 5, 0, 5);
            panel2.Size = new Size(238, 52);
            panel2.TabIndex = 2;
            // 
            // pnDashboard
            // 
            pnDashboard.BackColor = Color.FromArgb(32, 33, 36);
            pnDashboard.Cursor = Cursors.Hand;
            pnDashboard.Dock = DockStyle.Fill;
            pnDashboard.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            pnDashboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            pnDashboard.FlatStyle = FlatStyle.Flat;
            pnDashboard.Font = new Font("Century Gothic", 9.75F);
            pnDashboard.ForeColor = Color.White;
            pnDashboard.Image = (Image)resources.GetObject("pnDashboard.Image");
            pnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            pnDashboard.Location = new Point(0, 5);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Padding = new Padding(15, 0, 0, 0);
            pnDashboard.Size = new Size(238, 42);
            pnDashboard.TabIndex = 3;
            pnDashboard.Text = "Dashboard";
            pnDashboard.UseVisualStyleBackColor = false;
            pnDashboard.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(UsersPage);
            panel8.Location = new Point(0, 166);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 5, 0, 5);
            panel8.Size = new Size(238, 52);
            panel8.TabIndex = 9;
            // 
            // UsersPage
            // 
            UsersPage.BackColor = Color.FromArgb(32, 33, 36);
            UsersPage.Cursor = Cursors.Hand;
            UsersPage.Dock = DockStyle.Fill;
            UsersPage.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            UsersPage.FlatStyle = FlatStyle.Flat;
            UsersPage.Font = new Font("Century Gothic", 9.75F);
            UsersPage.ForeColor = Color.White;
            UsersPage.Image = (Image)resources.GetObject("UsersPage.Image");
            UsersPage.ImageAlign = ContentAlignment.MiddleLeft;
            UsersPage.Location = new Point(0, 5);
            UsersPage.Name = "UsersPage";
            UsersPage.Padding = new Padding(15, 0, 0, 0);
            UsersPage.Size = new Size(238, 42);
            UsersPage.TabIndex = 3;
            UsersPage.Text = "Users";
            UsersPage.UseVisualStyleBackColor = false;
            UsersPage.Click += button1_Click_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnProduct);
            panel7.Location = new Point(0, 218);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 5, 0, 5);
            panel7.Size = new Size(238, 52);
            panel7.TabIndex = 11;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(32, 33, 36);
            btnProduct.Cursor = Cursors.Hand;
            btnProduct.Dock = DockStyle.Fill;
            btnProduct.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Century Gothic", 9.75F);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 5);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(15, 0, 0, 0);
            btnProduct.Size = new Size(238, 42);
            btnProduct.TabIndex = 11;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnOrder);
            panel10.Location = new Point(0, 270);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(0, 5, 0, 5);
            panel10.Size = new Size(238, 52);
            panel10.TabIndex = 14;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(32, 33, 36);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.Dock = DockStyle.Fill;
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Century Gothic", 9.75F);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 5);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(15, 0, 0, 0);
            btnOrder.Size = new Size(238, 42);
            btnOrder.TabIndex = 12;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnSettings);
            panel3.Location = new Point(0, 322);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 5, 0, 5);
            panel3.Size = new Size(238, 52);
            panel3.TabIndex = 8;
            // 
            // pnSettings
            // 
            pnSettings.BackColor = Color.FromArgb(32, 33, 36);
            pnSettings.Cursor = Cursors.Hand;
            pnSettings.Dock = DockStyle.Fill;
            pnSettings.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            pnSettings.FlatStyle = FlatStyle.Flat;
            pnSettings.Font = new Font("Century Gothic", 9.75F);
            pnSettings.ForeColor = Color.White;
            pnSettings.Image = (Image)resources.GetObject("pnSettings.Image");
            pnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            pnSettings.Location = new Point(0, 5);
            pnSettings.Name = "pnSettings";
            pnSettings.Padding = new Padding(15, 0, 0, 0);
            pnSettings.Size = new Size(238, 42);
            pnSettings.TabIndex = 3;
            pnSettings.Text = "Account Settings";
            pnSettings.UseVisualStyleBackColor = false;
            pnSettings.Click += pnSettings_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(pnAbout);
            panel11.Location = new Point(0, 374);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(0, 5, 0, 5);
            panel11.Size = new Size(238, 52);
            panel11.TabIndex = 15;
            // 
            // pnAbout
            // 
            pnAbout.BackColor = Color.FromArgb(32, 33, 36);
            pnAbout.Cursor = Cursors.Hand;
            pnAbout.Dock = DockStyle.Fill;
            pnAbout.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            pnAbout.FlatStyle = FlatStyle.Flat;
            pnAbout.Font = new Font("Century Gothic", 9.75F);
            pnAbout.ForeColor = Color.White;
            pnAbout.Image = (Image)resources.GetObject("pnAbout.Image");
            pnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            pnAbout.Location = new Point(0, 5);
            pnAbout.Name = "pnAbout";
            pnAbout.Padding = new Padding(15, 0, 0, 0);
            pnAbout.Size = new Size(238, 42);
            pnAbout.TabIndex = 3;
            pnAbout.Text = "About";
            pnAbout.UseVisualStyleBackColor = false;
            pnAbout.Click += pnAbout_Click;
            // 
            // panel12
            // 
            panel12.Location = new Point(3, 429);
            panel12.Name = "panel12";
            panel12.Size = new Size(232, 155);
            panel12.TabIndex = 16;
            // 
            // panel9
            // 
            panel9.Controls.Add(pnlogout);
            panel9.Location = new Point(0, 587);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 5, 0, 5);
            panel9.Size = new Size(249, 52);
            panel9.TabIndex = 10;
            // 
            // pnlogout
            // 
            pnlogout.BackColor = Color.FromArgb(32, 33, 36);
            pnlogout.Cursor = Cursors.Hand;
            pnlogout.FlatAppearance.BorderColor = Color.FromArgb(32, 33, 36);
            pnlogout.FlatStyle = FlatStyle.Flat;
            pnlogout.Font = new Font("Century Gothic", 9.75F);
            pnlogout.ForeColor = Color.White;
            pnlogout.Image = (Image)resources.GetObject("pnlogout.Image");
            pnlogout.ImageAlign = ContentAlignment.MiddleLeft;
            pnlogout.Location = new Point(0, 5);
            pnlogout.Name = "pnlogout";
            pnlogout.Padding = new Padding(15, 0, 0, 0);
            pnlogout.Size = new Size(246, 42);
            pnlogout.TabIndex = 3;
            pnlogout.Text = "Logout";
            pnlogout.UseVisualStyleBackColor = false;
            pnlogout.Click += pnlogout_Click_1;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(238, 50);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1054, 645);
            mainpanel.TabIndex = 2;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1054, 645);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 695);
            Controls.Add(mainpanel);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel mainpanel;
        private Panel panel5;
        private PictureBox pictureBox1;
        private PictureBox Minimize;
        private PictureBox Maximize;
        private PictureBox Exit_btn;
        private Panel panel3;
        private Button button1;
        private Panel panel7;
        private Button pnDashboard;
        private Button pnSettings;
        private Panel panel8;
        private Button UsersPage;
        private Panel panel10;
        private Button button2;
        private Panel panel11;
        private Button pnAbout;
        private PictureBox pictureBox2;
        private Button btnProduct;
        private Button btnOrder;
        private Button pnlogout;
        private Panel panel12;
        private Panel panel9;
    }
}
