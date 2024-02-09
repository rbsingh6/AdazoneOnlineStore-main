namespace Lab_Project
{
    partial class Form2
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
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblProdModel = new System.Windows.Forms.Label();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.productDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataDataSet = new Lab_Project.StoreDataDataSet();
            this.productDataTableAdapter = new Lab_Project.StoreDataDataSetTableAdapters.ProductDataTableAdapter();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuaSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuaStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPicture = new System.Windows.Forms.Label();
            this.storeDataDataSet1 = new Lab_Project.StoreDataDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Image = global::Lab_Project.Properties.Resources.Webcam;
            this.picBoxProduct.Location = new System.Drawing.Point(95, 123);
            this.picBoxProduct.MaximumSize = new System.Drawing.Size(243, 253);
            this.picBoxProduct.MinimumSize = new System.Drawing.Size(243, 253);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(243, 253);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxProduct.TabIndex = 0;
            this.picBoxProduct.TabStop = false;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(455, 148);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(70, 25);
            this.lblProdName.TabIndex = 2;
            this.lblProdName.Text = "Name:";
            this.lblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.Location = new System.Drawing.Point(455, 284);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(37, 25);
            this.lblProdID.TabIndex = 3;
            this.lblProdID.Text = "ID:";
            this.lblProdID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdModel
            // 
            this.lblProdModel.AutoSize = true;
            this.lblProdModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdModel.Location = new System.Drawing.Point(455, 216);
            this.lblProdModel.Name = "lblProdModel";
            this.lblProdModel.Size = new System.Drawing.Size(72, 25);
            this.lblProdModel.TabIndex = 4;
            this.lblProdModel.Text = "Model:";
            this.lblProdModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPrice.Location = new System.Drawing.Point(455, 353);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(62, 25);
            this.lblProdPrice.TabIndex = 5;
            this.lblProdPrice.Text = "Price:";
            this.lblProdPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHomepage
            // 
            this.btnHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.Location = new System.Drawing.Point(276, 473);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(131, 31);
            this.btnHomepage.TabIndex = 12;
            this.btnHomepage.Text = "Homepage";
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(422, 473);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(119, 31);
            this.btnPurchase.TabIndex = 13;
            this.btnPurchase.Text = "Proceed";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
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
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodQuaSoldDataGridViewTextBoxColumn
            // 
            this.prodQuaSoldDataGridViewTextBoxColumn.DataPropertyName = "prodQuaSold";
            this.prodQuaSoldDataGridViewTextBoxColumn.HeaderText = "prodQuaSold";
            this.prodQuaSoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuaSoldDataGridViewTextBoxColumn.Name = "prodQuaSoldDataGridViewTextBoxColumn";
            this.prodQuaSoldDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodQuaStockDataGridViewTextBoxColumn
            // 
            this.prodQuaStockDataGridViewTextBoxColumn.DataPropertyName = "prodQuaStock";
            this.prodQuaStockDataGridViewTextBoxColumn.HeaderText = "prodQuaStock";
            this.prodQuaStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuaStockDataGridViewTextBoxColumn.Name = "prodQuaStockDataGridViewTextBoxColumn";
            this.prodQuaStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodModelDataGridViewTextBoxColumn
            // 
            this.prodModelDataGridViewTextBoxColumn.DataPropertyName = "prodModel";
            this.prodModelDataGridViewTextBoxColumn.HeaderText = "prodModel";
            this.prodModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodModelDataGridViewTextBoxColumn.Name = "prodModelDataGridViewTextBoxColumn";
            this.prodModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "prodDescription";
            this.prodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodModelDataGridViewTextBoxColumn,
            this.prodQuaStockDataGridViewTextBoxColumn,
            this.prodQuaSoldDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(809, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(30, 25);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicture.Location = new System.Drawing.Point(209, 83);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(88, 29);
            this.lblPicture.TabIndex = 1;
            this.lblPicture.Text = "Picture";
            this.lblPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeDataDataSet1
            // 
            this.storeDataDataSet1.DataSetName = "StoreDataDataSet";
            this.storeDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(811, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnHomepage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdModel);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.picBoxProduct);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblProdModel;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnPurchase;
        private StoreDataDataSet storeDataDataSet;
        private System.Windows.Forms.BindingSource productDataBindingSource;
        private StoreDataDataSetTableAdapters.ProductDataTableAdapter productDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuaSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuaStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPicture;
        private StoreDataDataSet storeDataDataSet1;
    }
}