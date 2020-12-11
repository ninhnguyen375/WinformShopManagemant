namespace ElectronicSales.Views.UserView
{
    partial class OrderDetail
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
            this.comboOfOrderList = new System.Windows.Forms.DataGridView();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOfOrderList = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idString = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.createdAt = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.orderTotalPrice = new System.Windows.Forms.Label();
            this.deliveryAddress = new System.Windows.Forms.Label();
            this.deliveryDate = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOfOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboOfOrderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboOfOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboOfOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboOfOrderList
            // 
            this.comboOfOrderList.AutoGenerateColumns = false;
            this.comboOfOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comboOfOrderList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.comboOfOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboOfOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.comboNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.TotalPrice});
            this.comboOfOrderList.DataSource = this.comboOfOrderBindingSource2;
            this.comboOfOrderList.Location = new System.Drawing.Point(14, 311);
            this.comboOfOrderList.Name = "comboOfOrderList";
            this.comboOfOrderList.Size = new System.Drawing.Size(555, 152);
            this.comboOfOrderList.TabIndex = 19;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // productOfOrderList
            // 
            this.productOfOrderList.AutoGenerateColumns = false;
            this.productOfOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productOfOrderList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productOfOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOfOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productOfOrderList.DataSource = this.productOfOrderBindingSource;
            this.productOfOrderList.Location = new System.Drawing.Point(14, 136);
            this.productOfOrderList.Name = "productOfOrderList";
            this.productOfOrderList.Size = new System.Drawing.Size(555, 158);
            this.productOfOrderList.TabIndex = 21;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Created At:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Employee Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Delivery Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Delivery Date:";
            // 
            // idString
            // 
            this.idString.AutoSize = true;
            this.idString.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idString.Location = new System.Drawing.Point(10, 17);
            this.idString.Name = "idString";
            this.idString.Size = new System.Drawing.Size(63, 19);
            this.idString.TabIndex = 30;
            this.idString.Text = "Order ID";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(224, 17);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(109, 19);
            this.customerName.TabIndex = 31;
            this.customerName.Text = "customerName";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(395, 17);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(112, 19);
            this.employeeName.TabIndex = 32;
            this.employeeName.Text = "employeeName";
            // 
            // createdAt
            // 
            this.createdAt.AutoSize = true;
            this.createdAt.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdAt.Location = new System.Drawing.Point(10, 58);
            this.createdAt.Name = "createdAt";
            this.createdAt.Size = new System.Drawing.Size(72, 19);
            this.createdAt.TabIndex = 33;
            this.createdAt.Text = "createdAt";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Blue;
            this.status.Location = new System.Drawing.Point(224, 58);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(47, 19);
            this.status.TabIndex = 34;
            this.status.Text = "status";
            // 
            // orderTotalPrice
            // 
            this.orderTotalPrice.AutoSize = true;
            this.orderTotalPrice.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.orderTotalPrice.Location = new System.Drawing.Point(395, 58);
            this.orderTotalPrice.Name = "orderTotalPrice";
            this.orderTotalPrice.Size = new System.Drawing.Size(111, 19);
            this.orderTotalPrice.TabIndex = 35;
            this.orderTotalPrice.Text = "orderTotalPrice";
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.AutoSize = true;
            this.deliveryAddress.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddress.Location = new System.Drawing.Point(224, 101);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Size = new System.Drawing.Size(111, 19);
            this.deliveryAddress.TabIndex = 36;
            this.deliveryAddress.Text = "deliveryAddress";
            // 
            // deliveryDate
            // 
            this.deliveryDate.AutoSize = true;
            this.deliveryDate.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDate.Location = new System.Drawing.Point(10, 101);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(91, 19);
            this.deliveryDate.TabIndex = 37;
            this.deliveryDate.Text = "deliveryDate";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdString";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Single Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productOfOrderBindingSource
            // 
            this.productOfOrderBindingSource.DataSource = typeof(ElectronicSales.Models.ProductOfOrder);
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // comboNameDataGridViewTextBoxColumn
            // 
            this.comboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.HeaderText = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.Name = "comboNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Single Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // comboOfOrderBindingSource2
            // 
            this.comboOfOrderBindingSource2.DataSource = typeof(ElectronicSales.Models.ComboOfOrder);
            // 
            // comboOfOrderBindingSource
            // 
            this.comboOfOrderBindingSource.DataSource = typeof(ElectronicSales.Models.ComboOfOrder);
            // 
            // comboOfOrderBindingSource1
            // 
            this.comboOfOrderBindingSource1.DataSource = typeof(ElectronicSales.Models.ComboOfOrder);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 475);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.deliveryAddress);
            this.Controls.Add(this.orderTotalPrice);
            this.Controls.Add(this.status);
            this.Controls.Add(this.createdAt);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.idString);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productOfOrderList);
            this.Controls.Add(this.comboOfOrderList);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboOfOrderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView comboOfOrderList;
        private System.Windows.Forms.BindingSource comboOfOrderBindingSource;
        private System.Windows.Forms.BindingSource comboOfOrderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.BindingSource comboOfOrderBindingSource2;
        private System.Windows.Forms.DataGridView productOfOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource productOfOrderBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idString;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label createdAt;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label orderTotalPrice;
        private System.Windows.Forms.Label deliveryAddress;
        private System.Windows.Forms.Label deliveryDate;
    }
}