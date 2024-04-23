using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.UserControls
{
    public partial class ProductDeleteForm : Form
    {
        // Other properties and methods...
        private Label lblProductID;

        public int ProductID { get; set; }

        public ProductDeleteForm(int productId)
        {
            // Use the productId as needed in the form
        }

        public ProductDeleteForm()
        {
            InitializeComponent();

            // Initialize the label
            lblProductID = new Label();
            lblProductID.Text = "Product ID: ";
            lblProductID.Location = new System.Drawing.Point(10, 10);
            // Add the label to the form's Controls collection
            Controls.Add(lblProductID);
        }

    }
}
