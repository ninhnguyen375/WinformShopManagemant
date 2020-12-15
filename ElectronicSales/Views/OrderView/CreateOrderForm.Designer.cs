namespace ElectronicSales.Views.UserView
{
    partial class CreateOrderForm
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
            this.comboList = new System.Windows.Forms.DataGridView();
            this.idStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboOfOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createButton = new System.Windows.Forms.Button();
            this.includeComboButton = new System.Windows.Forms.Button();
            this.includeProductButton = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.DataGridView();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOfOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.deliveryAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseCustomerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.comboList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboList
            // 
            this.comboList.AutoGenerateColumns = false;
            this.comboList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comboList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.comboList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn1,
            this.comboNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.comboList.DataSource = this.comboOfOrderBindingSource;
            this.comboList.Location = new System.Drawing.Point(12, 302);
            this.comboList.Name = "comboList";
            this.comboList.Size = new System.Drawing.Size(547, 127);
            this.comboList.TabIndex = 1;
            // 
            // idStringDataGridViewTextBoxColumn1
            // 
            this.idStringDataGridViewTextBoxColumn1.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn1.Name = "idStringDataGridViewTextBoxColumn1";
            // 
            // comboNameDataGridViewTextBoxColumn
            // 
            this.comboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.HeaderText = "Tên Combo";
            this.comboNameDataGridViewTextBoxColumn.Name = "comboNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "Tổng giá";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            // 
            // comboOfOrderBindingSource
            // 
            this.comboOfOrderBindingSource.DataSource = typeof(ElectronicSales.Models.ComboOfOrder);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.createButton.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(413, 443);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(146, 34);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "HOÀN TẤT";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // includeComboButton
            // 
            this.includeComboButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.includeComboButton.ForeColor = System.Drawing.Color.White;
            this.includeComboButton.Location = new System.Drawing.Point(413, 269);
            this.includeComboButton.Name = "includeComboButton";
            this.includeComboButton.Size = new System.Drawing.Size(146, 27);
            this.includeComboButton.TabIndex = 4;
            this.includeComboButton.Text = "Thêm Combo";
            this.includeComboButton.UseVisualStyleBackColor = false;
            this.includeComboButton.Click += new System.EventHandler(this.includeComboButton_Click);
            // 
            // includeProductButton
            // 
            this.includeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.includeProductButton.ForeColor = System.Drawing.Color.White;
            this.includeProductButton.Location = new System.Drawing.Point(413, 102);
            this.includeProductButton.Name = "includeProductButton";
            this.includeProductButton.Size = new System.Drawing.Size(146, 27);
            this.includeProductButton.TabIndex = 5;
            this.includeProductButton.Text = "Thêm Sản Phẩm";
            this.includeProductButton.UseVisualStyleBackColor = false;
            this.includeProductButton.Click += new System.EventHandler(this.includeProductButton_Click);
            // 
            // productList
            // 
            this.productList.AutoGenerateColumns = false;
            this.productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.productList.DataSource = this.productOfOrderBindingSource;
            this.productList.Location = new System.Drawing.Point(12, 135);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(547, 127);
            this.productList.TabIndex = 6;
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
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng giá";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // productOfOrderBindingSource
            // 
            this.productOfOrderBindingSource.DataSource = typeof(ElectronicSales.Models.ProductOfOrder);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ giao hàng:";
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.Location = new System.Drawing.Point(12, 87);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Size = new System.Drawing.Size(203, 41);
            this.deliveryAddress.TabIndex = 10;
            this.deliveryAddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Khánh hàng:";
            // 
            // chooseCustomerButton
            // 
            this.chooseCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.chooseCustomerButton.ForeColor = System.Drawing.Color.White;
            this.chooseCustomerButton.Location = new System.Drawing.Point(12, 29);
            this.chooseCustomerButton.Name = "chooseCustomerButton";
            this.chooseCustomerButton.Size = new System.Drawing.Size(203, 27);
            this.chooseCustomerButton.TabIndex = 12;
            this.chooseCustomerButton.Text = "Chọn Khánh Hàng";
            this.chooseCustomerButton.UseVisualStyleBackColor = false;
            this.chooseCustomerButton.Click += new System.EventHandler(this.chooseCustomerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "THÀNH TIỀN";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalPrice.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.totalPrice.Location = new System.Drawing.Point(105, 0);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(40, 24);
            this.totalPrice.TabIndex = 14;
            this.totalPrice.Text = "000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalPrice);
            this.panel1.Location = new System.Drawing.Point(414, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 37);
            this.panel1.TabIndex = 15;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseCustomerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.includeProductButton);
            this.Controls.Add(this.includeComboButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.comboList);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateOrderForm";
            this.Text = "Bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.comboList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView comboList;
        private System.Windows.Forms.BindingSource comboOfOrderBindingSource;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button includeComboButton;
        private System.Windows.Forms.Button includeProductButton;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.BindingSource productOfOrderBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox deliveryAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseCustomerButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}