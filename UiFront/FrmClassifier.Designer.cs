namespace UiFront
{
    partial class FrmClassifier
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uiCrudKey = new UiFront.UiCrud();
            this.uiCrudValue = new UiFront.UiCrud();
            this.uiCrudType = new UiFront.UiCrud();
            this.uiCrudMake = new UiFront.UiCrud();
            this.uiCrudModel = new UiFront.UiCrud();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRowData = new System.Windows.Forms.ComboBox();
            this.lblPkId = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.btnUpdateAttribute = new System.Windows.Forms.Button();
            this.btnDeleteAttribute = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductTreeSelected = new System.Windows.Forms.Label();
            this.lblProductSelected = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.treeView1, 2);
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(251, 358);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblProductSelected);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.uiCrudValue);
            this.groupBox4.Controls.Add(this.uiCrudKey);
            this.groupBox4.Location = new System.Drawing.Point(570, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 512);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Attribute CRUD";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel4);
            this.groupBox7.Controls.Add(this.uiCrudModel);
            this.groupBox7.Controls.Add(this.uiCrudMake);
            this.groupBox7.Controls.Add(this.uiCrudType);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(552, 484);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Classification Tree";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Product Tree";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // uiCrudKey
            // 
            this.uiCrudKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCrudKey.Location = new System.Drawing.Point(14, 19);
            this.uiCrudKey.Name = "uiCrudKey";
            this.uiCrudKey.Padding = new System.Windows.Forms.Padding(3);
            this.uiCrudKey.PkId = "-1";
            this.uiCrudKey.Size = new System.Drawing.Size(246, 139);
            this.uiCrudKey.TabIndex = 0;
            this.uiCrudKey.TableName = "Key";
            // 
            // uiCrudValue
            // 
            this.uiCrudValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCrudValue.Location = new System.Drawing.Point(14, 159);
            this.uiCrudValue.Name = "uiCrudValue";
            this.uiCrudValue.Padding = new System.Windows.Forms.Padding(3);
            this.uiCrudValue.PkId = "-1";
            this.uiCrudValue.Size = new System.Drawing.Size(246, 179);
            this.uiCrudValue.TabIndex = 1;
            this.uiCrudValue.TableName = "Value";
            // 
            // uiCrudType
            // 
            this.uiCrudType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCrudType.Location = new System.Drawing.Point(283, 13);
            this.uiCrudType.Name = "uiCrudType";
            this.uiCrudType.Padding = new System.Windows.Forms.Padding(3);
            this.uiCrudType.PkId = "-1";
            this.uiCrudType.Size = new System.Drawing.Size(254, 150);
            this.uiCrudType.TabIndex = 9;
            this.uiCrudType.TableName = "Type";
            // 
            // uiCrudMake
            // 
            this.uiCrudMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCrudMake.Location = new System.Drawing.Point(283, 168);
            this.uiCrudMake.Name = "uiCrudMake";
            this.uiCrudMake.Padding = new System.Windows.Forms.Padding(3);
            this.uiCrudMake.PkId = "-1";
            this.uiCrudMake.Size = new System.Drawing.Size(254, 150);
            this.uiCrudMake.TabIndex = 10;
            this.uiCrudMake.TableName = "Make";
            // 
            // uiCrudModel
            // 
            this.uiCrudModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCrudModel.Location = new System.Drawing.Point(283, 324);
            this.uiCrudModel.Name = "uiCrudModel";
            this.uiCrudModel.Padding = new System.Windows.Forms.Padding(3);
            this.uiCrudModel.PkId = "-1";
            this.uiCrudModel.Size = new System.Drawing.Size(254, 150);
            this.uiCrudModel.TabIndex = 11;
            this.uiCrudModel.TableName = "Model";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(11, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 141);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Product Attributes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRowData, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPkId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 122);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pk:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRowData
            // 
            this.cbRowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRowData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbRowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRowData.FormattingEnabled = true;
            this.cbRowData.Items.AddRange(new object[] {
            "Empty"});
            this.cbRowData.Location = new System.Drawing.Point(71, 3);
            this.cbRowData.Name = "cbRowData";
            this.tableLayoutPanel1.SetRowSpan(this.cbRowData, 2);
            this.cbRowData.Size = new System.Drawing.Size(183, 80);
            this.cbRowData.TabIndex = 4;
            // 
            // lblPkId
            // 
            this.lblPkId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPkId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPkId.Location = new System.Drawing.Point(37, 0);
            this.lblPkId.Name = "lblPkId";
            this.lblPkId.Size = new System.Drawing.Size(28, 21);
            this.lblPkId.TabIndex = 2;
            this.lblPkId.Text = "-1";
            this.lblPkId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddAttribute, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateAttribute, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteAttribute, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 30);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAttribute.Location = new System.Drawing.Point(17, 3);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(59, 24);
            this.btnAddAttribute.TabIndex = 3;
            this.btnAddAttribute.Text = "ADD";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAttribute
            // 
            this.btnUpdateAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateAttribute.Location = new System.Drawing.Point(96, 3);
            this.btnUpdateAttribute.Name = "btnUpdateAttribute";
            this.btnUpdateAttribute.Size = new System.Drawing.Size(59, 24);
            this.btnUpdateAttribute.TabIndex = 4;
            this.btnUpdateAttribute.Text = "UPDATE";
            this.btnUpdateAttribute.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAttribute
            // 
            this.btnDeleteAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteAttribute.Location = new System.Drawing.Point(175, 3);
            this.btnDeleteAttribute.Name = "btnDeleteAttribute";
            this.btnDeleteAttribute.Size = new System.Drawing.Size(59, 24);
            this.btnDeleteAttribute.TabIndex = 5;
            this.btnDeleteAttribute.Text = "DELETE";
            this.btnDeleteAttribute.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddProduct, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateProduct, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteProduct, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 410);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(251, 41);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Location = new System.Drawing.Point(17, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(59, 35);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateProduct.Location = new System.Drawing.Point(96, 3);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(59, 35);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "UPDATE";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteProduct.Location = new System.Drawing.Point(175, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(59, 35);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblProductTreeSelected, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 454);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // lblProductTreeSelected
            // 
            this.lblProductTreeSelected.AutoSize = true;
            this.lblProductTreeSelected.BackColor = System.Drawing.Color.White;
            this.lblProductTreeSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.lblProductTreeSelected, 2);
            this.lblProductTreeSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductTreeSelected.Location = new System.Drawing.Point(3, 384);
            this.lblProductTreeSelected.Name = "lblProductTreeSelected";
            this.lblProductTreeSelected.Size = new System.Drawing.Size(251, 23);
            this.lblProductTreeSelected.TabIndex = 17;
            this.lblProductTreeSelected.Text = "...";
            this.lblProductTreeSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductSelected
            // 
            this.lblProductSelected.BackColor = System.Drawing.Color.White;
            this.lblProductSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductSelected.Location = new System.Drawing.Point(17, 341);
            this.lblProductSelected.Name = "lblProductSelected";
            this.lblProductSelected.Size = new System.Drawing.Size(251, 23);
            this.lblProductSelected.TabIndex = 18;
            this.lblProductSelected.Text = "...";
            this.lblProductSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmClassifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 538);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmClassifier";
            this.Text = "AI ETL Classifier";
            this.Load += new System.EventHandler(this.FrmClassifier_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label11;
        private UiCrud uiCrudValue;
        private UiCrud uiCrudKey;
        private UiCrud uiCrudType;
        private UiCrud uiCrudMake;
        private UiCrud uiCrudModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRowData;
        private System.Windows.Forms.Label lblPkId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.Button btnUpdateAttribute;
        private System.Windows.Forms.Button btnDeleteAttribute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblProductTreeSelected;
        private System.Windows.Forms.Label lblProductSelected;
    }
}

