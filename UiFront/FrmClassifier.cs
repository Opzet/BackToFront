using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFront
{
    public partial class FrmClassifier : Form
    {
        public FrmClassifier()
        {
            InitializeComponent();
        }

        private void FrmClassifier_Load(object sender, EventArgs e)
        {
            // Load Product Tree

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Create a new product (if not exists) using the values from:
            // 1. uiCrudType
            // 2. uiCrudMake
            // 3. uiCrudModel


        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //Update exiting product using the values from:

            // 1. uiCrudType
            // 2. uiCrudMake
            // 3. uiCrudModel

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Delete exiting product using the PkId from selected item tag
        }
    }
}
