namespace Ecommerce
{
    partial class EditUser
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
            panel2 = new Panel();
            txtUserAccountStatus = new TextBox();
            label6 = new Label();
            txtUserStatus = new TextBox();
            label5 = new Label();
            UserUFsubmit = new Guna.UI2.WinForms.Guna2Button();
            txtUserName = new TextBox();
            txtUserPhoneNumber = new TextBox();
            txtUserEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserAccountStatus);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtUserStatus);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UserUFsubmit);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtUserPhoneNumber);
            panel2.Controls.Add(txtUserEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 384);
            panel2.TabIndex = 7;
            // 
            // txtUserAccountStatus
            // 
            txtUserAccountStatus.Font = new Font("Segoe UI", 12F);
            txtUserAccountStatus.Location = new Point(139, 246);
            txtUserAccountStatus.Name = "txtUserAccountStatus";
            txtUserAccountStatus.Size = new Size(237, 29);
            txtUserAccountStatus.TabIndex = 11;
            txtUserAccountStatus.TextChanged += txtUserAccountStatus_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 250);
            label6.Name = "label6";
            label6.Size = new Size(122, 19);
            label6.TabIndex = 10;
            label6.Text = "Account Status";
            // 
            // txtUserStatus
            // 
            txtUserStatus.Font = new Font("Segoe UI", 12F);
            txtUserStatus.Location = new Point(139, 194);
            txtUserStatus.Name = "txtUserStatus";
            txtUserStatus.Size = new Size(237, 29);
            txtUserStatus.TabIndex = 9;
            txtUserStatus.TextChanged += txtUserStatus_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 198);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 8;
            label5.Text = "User Status";
            // 
            // UserUFsubmit
            // 
            UserUFsubmit.BorderRadius = 5;
            UserUFsubmit.CustomizableEdges = customizableEdges1;
            UserUFsubmit.DisabledState.BorderColor = Color.DarkGray;
            UserUFsubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            UserUFsubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UserUFsubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UserUFsubmit.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserUFsubmit.ForeColor = Color.White;
            UserUFsubmit.Location = new Point(111, 319);
            UserUFsubmit.Name = "UserUFsubmit";
            UserUFsubmit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UserUFsubmit.Size = new Size(180, 45);
            UserUFsubmit.TabIndex = 7;
            UserUFsubmit.Text = "Submit";
            UserUFsubmit.Click += UserUFsubmit_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(139, 38);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 29);
            txtUserName.TabIndex = 6;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtUserPhoneNumber
            // 
            txtUserPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtUserPhoneNumber.Location = new Point(139, 139);
            txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            txtUserPhoneNumber.Size = new Size(237, 29);
            txtUserPhoneNumber.TabIndex = 5;
            txtUserPhoneNumber.TextChanged += txtUserPhoneNumber_TextChanged;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Font = new Font("Segoe UI", 12F);
            txtUserEmail.Location = new Point(139, 88);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(237, 29);
            txtUserEmail.TabIndex = 4;
            txtUserEmail.TextChanged += txtUserEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 143);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 2;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(60, 5, 60, 5);
            panel1.Size = new Size(397, 33);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 5);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 1;
            label1.Text = "ACCOUNT UPDATE FORM";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 417);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUser";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtUserAccountStatus;
        private Label label6;
        private TextBox txtUserStatus;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button UserUFsubmit;
        private TextBox txtUserName;
        private TextBox txtUserPhoneNumber;
        private TextBox txtUserEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}