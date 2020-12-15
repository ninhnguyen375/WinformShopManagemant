namespace ElectronicSales.Views.ProductView
{
    partial class EditComboForm
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
            this.tbComboName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idString = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.originalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.productOfComboList = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.discountPercentNumber = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productOfComboList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComboName
            // 
            this.tbComboName.Location = new System.Drawing.Point(12, 27);
            this.tbComboName.Name = "tbComboName";
            this.tbComboName.Size = new System.Drawing.Size(158, 23);
            this.tbComboName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên combo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(395, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "CẬP NHẬT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.updateComboButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Combo ID:";
            // 
            // idString
            // 
            this.idString.AutoSize = true;
            this.idString.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idString.Location = new System.Drawing.Point(8, 80);
            this.idString.Name = "idString";
            this.idString.Size = new System.Drawing.Size(75, 19);
            this.idString.TabIndex = 13;
            this.idString.Text = "Combo ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá gốc:";
            // 
            // originalPrice
            // 
            this.originalPrice.AutoSize = true;
            this.originalPrice.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPrice.Location = new System.Drawing.Point(391, 25);
            this.originalPrice.Name = "originalPrice";
            this.originalPrice.Size = new System.Drawing.Size(58, 20);
            this.originalPrice.TabIndex = 15;
            this.originalPrice.Text = "Giá gốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giá combo:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.OrangeRed;
            this.price.Location = new System.Drawing.Point(391, 80);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(81, 20);
            this.price.TabIndex = 17;
            this.price.Text = "Giá combo";
            // 
            // productOfComboList
            // 
            this.productOfComboList.AutoGenerateColumns = false;
            this.productOfComboList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productOfComboList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productOfComboList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOfComboList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productImageDataGridViewImageColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Delete});
            this.productOfComboList.DataSource = this.productBindingSource;
            this.productOfComboList.Location = new System.Drawing.Point(11, 150);
            this.productOfComboList.Name = "productOfComboList";
            this.productOfComboList.Size = new System.Drawing.Size(555, 194);
            this.productOfComboList.TabIndex = 18;
            this.productOfComboList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productOfComboList_CellContentClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.FillWeight = 99.61929F;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productImageDataGridViewImageColumn
            // 
            this.productImageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productImageDataGridViewImageColumn.DataPropertyName = "ProductImage";
            this.productImageDataGridViewImageColumn.FillWeight = 40F;
            this.productImageDataGridViewImageColumn.HeaderText = "Image";
            this.productImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
            this.productImageDataGridViewImageColumn.ReadOnly = true;
            this.productImageDataGridViewImageColumn.Width = 44;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.FillWeight = 99.61929F;
            this.inStockDataGridViewTextBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 99.61929F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 99.61929F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ElectronicSales.Models.Product);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phần trăm giảm:";
            // 
            // discountPercentNumber
            // 
            this.discountPercentNumber.Location = new System.Drawing.Point(194, 27);
            this.discountPercentNumber.Name = "discountPercentNumber";
            this.discountPercentNumber.Size = new System.Drawing.Size(110, 23);
            this.discountPercentNumber.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(395, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "Thêm sản phẩm vào Combo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.discountPercentNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productOfComboList);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbComboName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditComboForm";
            this.Text = "Chỉnh sửa combo";
            ((System.ComponentModel.ISupportInitialize)(this.productOfComboList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountPercentNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label originalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DataGridView productOfComboList;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown discountPercentNumber;
        private System.Windows.Forms.Button button2;
    }
}