namespace ElectronicSales
{
    partial class ProductListPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inputSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(685, 14);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(111, 23);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add New Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.AutoGenerateColumns = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.BackgroundColor = System.Drawing.Color.White;
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.ProductImage,
            this.productNameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.productGridView.DataSource = this.productBindingSource;
            this.productGridView.Location = new System.Drawing.Point(3, 43);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(793, 395);
            this.productGridView.TabIndex = 2;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            // 
            // ProductImage
            // 
            this.ProductImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductImage.DataPropertyName = "ProductImage";
            this.ProductImage.FillWeight = 80F;
            this.ProductImage.HeaderText = "Product Image";
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Width = 80;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 14.13334F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 18.84446F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // inputSearchName
            // 
            this.inputSearchName.Location = new System.Drawing.Point(3, 17);
            this.inputSearchName.Name = "inputSearchName";
            this.inputSearchName.Size = new System.Drawing.Size(185, 20);
            this.inputSearchName.TabIndex = 3;
            this.inputSearchName.TextChanged += new System.EventHandler(this.inputSearchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by name:";
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.FillWeight = 47.11114F;
            this.idStringDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 47.11114F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.FillWeight = 47.11114F;
            this.inStockDataGridViewTextBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 47.11114F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ElectronicSales.Models.Product);
            // 
            // ProductListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearchName);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.addProductButton);
            this.Name = "ProductListPage";
            this.Size = new System.Drawing.Size(799, 441);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox inputSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
