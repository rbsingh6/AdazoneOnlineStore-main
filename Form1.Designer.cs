namespace Lab_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuaStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuaSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataDataSet = new Lab_Project.StoreDataDataSet();
            this.productDataTableAdapter = new Lab_Project.StoreDataDataSetTableAdapters.ProductDataTableAdapter();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtboxProductName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodModelDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodQuaStockDataGridViewTextBoxColumn,
            this.prodQuaSoldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(477, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(372, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            this.productIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 90;
            // 
            // prodModelDataGridViewTextBoxColumn
            // 
            this.prodModelDataGridViewTextBoxColumn.DataPropertyName = "prodModel";
            this.prodModelDataGridViewTextBoxColumn.HeaderText = "prodModel";
            this.prodModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodModelDataGridViewTextBoxColumn.Name = "prodModelDataGridViewTextBoxColumn";
            this.prodModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodModelDataGridViewTextBoxColumn.Width = 90;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodPriceDataGridViewTextBoxColumn.Visible = false;
            this.prodPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // prodQuaStockDataGridViewTextBoxColumn
            // 
            this.prodQuaStockDataGridViewTextBoxColumn.DataPropertyName = "prodQuaStock";
            this.prodQuaStockDataGridViewTextBoxColumn.HeaderText = "prodQuaStock";
            this.prodQuaStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuaStockDataGridViewTextBoxColumn.Name = "prodQuaStockDataGridViewTextBoxColumn";
            this.prodQuaStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodQuaStockDataGridViewTextBoxColumn.Visible = false;
            this.prodQuaStockDataGridViewTextBoxColumn.Width = 80;
            // 
            // prodQuaSoldDataGridViewTextBoxColumn
            // 
            this.prodQuaSoldDataGridViewTextBoxColumn.DataPropertyName = "prodQuaSold";
            this.prodQuaSoldDataGridViewTextBoxColumn.HeaderText = "prodQuaSold";
            this.prodQuaSoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuaSoldDataGridViewTextBoxColumn.Name = "prodQuaSoldDataGridViewTextBoxColumn";
            this.prodQuaSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodQuaSoldDataGridViewTextBoxColumn.Visible = false;
            this.prodQuaSoldDataGridViewTextBoxColumn.Width = 80;
            // 
            // productDataBindingSource
            // 
            this.productDataBindingSource.DataMember = "ProductData";
            this.productDataBindingSource.DataSource = this.storeDataDataSet;
            // 
            // storeDataDataSet
            // 
            this.storeDataDataSet.DataSetName = "StoreDataDataSet";
            this.storeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDataTableAdapter
            // 
            this.productDataTableAdapter.ClearBeforeFill = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(396, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(293, 32);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Adazone Online Store";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(99, 190);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(250, 25);
            this.lblSearchProduct.TabIndex = 7;
            this.lblSearchProduct.Text = "Search for a product below!";
            this.lblSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(37, 258);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 25);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxProductName
            // 
            this.txtboxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProductName.Location = new System.Drawing.Point(211, 258);
            this.txtboxProductName.Name = "txtboxProductName";
            this.txtboxProductName.Size = new System.Drawing.Size(195, 24);
            this.txtboxProductName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(171, 369);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(71, 448);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(321, 32);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Note: Please enter the exact product name in the box,\r\nfrom the prodDescription c" +
    "olumn in the table.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(938, 508);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtboxProductName);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StoreDataDataSet storeDataDataSet;
        private System.Windows.Forms.BindingSource productDataBindingSource;
        private StoreDataDataSetTableAdapters.ProductDataTableAdapter productDataTableAdapter;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtboxProductName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuaStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuaSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInfo;
    }
}

