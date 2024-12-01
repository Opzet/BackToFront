using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiFront
{
    // A generic ui user control for CRUD of data via WebApiClient
    public partial class UiCrud : UserControl
    {
        //Create a constructor

        // Data source for CRUD operations


        // Type of data source

        //Create public properties to get and set ui elements
        // Create public properties to get and set ui elements
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TableName
        {
            get { return this.lblTableName.Text; }
            set { this.lblTableName.Text = value; }
        }

        public string PkId
        {
            get { return this.lblPkId.Text; }
            set { this.lblPkId.Text = value; }
        }

        public (int PkId, string CurrentItem) SelectedItem()
        {
            // Get PkId from Tag

            return (int.Parse(this.lblPkId.Text), this.cbRowData.Text);

        }



        public UiCrud()
        {
            InitializeComponent();
        }

        // ============ Event Handlers ============
        private void UiCrud_Load(object sender, EventArgs e)
        {

        }

        // Populate cbRowData with Data 
        public void PopulateRowData(DataRow row)
        {
            this.cbRowData.Items.Clear();
            foreach (DataColumn column in row.Table.Columns)
            {

                this.cbRowData.Items.Add(column.ColumnName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbRowData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get PkId from Tag 
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lblTableName_Enter(object sender, EventArgs e)
        {

        }
    }
}
