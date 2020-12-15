namespace ElectronicSales.Views.ProductView
{
    partial class AddComboForm
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
            this.addProductToComboButton = new System.Windows.Forms.Button();
            this.discountPercentNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.productOfComboList = new System.Windows.Forms.DataGridView();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.originalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComboName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfComboList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductToComboButton
            // 
            this.addProductToComboButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addProductToComboButton.ForeColor = System.Drawing.Color.White;
            this.addProductToComboButton.Location = new System.Drawing.Point(393, 120);
            this.addProductToComboButton.Name = "addProductToComboButton";
            this.addProductToComboButton.Size = new System.Drawing.Size(171, 27);
            this.addProductToComboButton.TabIndex = 34;
            this.addProductToComboButton.Text = "Thêm sản phẩm vào Combo";
            this.addProductToComboButton.UseVisualStyleBackColor = false;
            this.addProductToComboButton.Click += new System.EventHandler(this.addProductToComboButton_Click);
            // 
            // discountPercentNumber
            // 
            this.discountPercentNumber.Location = new System.Drawing.Point(15, 78);
            this.discountPercentNumber.Name = "discountPercentNumber";
            this.discountPercentNumber.Size = new System.Drawing.Size(158, 23);
            this.discountPercentNumber.TabIndex = 33;
            this.discountPercentNumber.ValueChanged += new System.EventHandler(this.discountPercentNumber_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phần trăm giảm:";
            // 
            // productOfComboList
            // 
            this.productOfComboList.AutoGenerateColumns = false;
            this.productOfComboList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productOfComboList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productOfComboList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOfComboList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productImageDataGridViewImageColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Delete});
            this.productOfComboList.DataSource = this.productBindingSource;
            this.productOfComboList.Location = new System.Drawing.Point(9, 153);
            this.productOfComboList.Name = "productOfComboList";
            this.productOfComboList.Size = new System.Drawing.Size(555, 194);
            this.productOfComboList.TabIndex = 31;
            this.productOfComboList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productOfComboList_CellContentClick);
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productImageDataGridViewImageColumn
            // 
            this.productImageDataGridViewImageColumn.DataPropertyName = "ProductImage";
            this.productImageDataGridViewImageColumn.HeaderText = "Image";
            this.productImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
            this.productImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 99.61929F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ElectronicSales.Models.Product);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.OrangeRed;
            this.price.Location = new System.Drawing.Point(389, 77);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(81, 20);
            this.price.TabIndex = 30;
            this.price.Text = "Giá combo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Giá combo:";
            // 
            // originalPrice
            // 
            this.originalPrice.AutoSize = true;
            this.originalPrice.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPrice.Location = new System.Drawing.Point(388, 24);
            this.originalPrice.Name = "originalPrice";
            this.originalPrice.Size = new System.Drawing.Size(58, 20);
            this.originalPrice.TabIndex = 28;
            this.originalPrice.Text = "Giá gốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giá gốc:";
            // 
            // tbComboName
            // 
            this.tbComboName.Location = new System.Drawing.Point(15, 24);
            this.tbComboName.Name = "tbComboName";
            this.tbComboName.Size = new System.Drawing.Size(158, 23);
            this.tbComboName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên combo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(413, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "TẠO MỚI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.createComboButton_Click);
            // 
            // AddComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 417);
            this.Controls.Add(this.addProductToComboButton);
            this.Controls.Add(this.discountPercentNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productOfComboList);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbComboName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddComboForm";
            this.Text = "AddComboForm";
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfComboList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductToComboButton;
        private System.Windows.Forms.NumericUpDown discountPercentNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView productOfComboList;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label originalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbComboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}