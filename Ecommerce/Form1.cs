using Ecommerce.Properties;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 231)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void pnAbout_Click(object sender, EventArgs e)
        {
            loadform(new aboutform());
        }

        private void pnSettings_Click(object sender, EventArgs e)
        {
            loadform(new settingsform());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlogout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlogout_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the login form
            loginform newLoginForm = new loginform();

            // Hide the current form
            this.Hide();

            // Show the new form as a dialog
            newLoginForm.ShowDialog();

            // Close the current form once the new form is closed
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the users form
            users usersForm = new users();

            // Load the users form using the loadform method
            loadform(usersForm);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            loadform(new ProductInformation());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            loadform(new orders());
        }
    }

    internal class formDashboard
    {
    }
}
