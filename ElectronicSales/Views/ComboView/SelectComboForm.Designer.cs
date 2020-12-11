namespace ElectronicSales.Views.ComboView
{
    partial class SelectComboForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboList = new System.Windows.Forms.DataGridView();
            this.choose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboList
            // 
            this.comboList.AutoGenerateColumns = false;
            this.comboList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comboList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.comboList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.comboNameDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.discountPercentDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.choose});
            this.comboList.DataSource = this.comboBindingSource;
            this.comboList.Location = new System.Drawing.Point(12, 38);
            this.comboList.Name = "comboList";
            this.comboList.Size = new System.Drawing.Size(672, 264);
            this.comboList.TabIndex = 2;
            this.comboList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comboList_CellContentClick);
            // 
            // choose
            // 
            this.choose.FillWeight = 95.23858F;
            this.choose.HeaderText = "Choose";
            this.choose.Name = "choose";
            this.choose.Text = "Choose";
            this.choose.UseColumnTextForButtonValue = true;
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.HeaderText = "IdString";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // comboNameDataGridViewTextBoxColumn
            // 
            this.comboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.HeaderText = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.Name = "comboNameDataGridViewTextBoxColumn";
            // 
            // originalPriceDataGridViewTextBoxColumn
            // 
            this.originalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.HeaderText = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.Name = "originalPriceDataGridViewTextBoxColumn";
            // 
            // discountPercentDataGridViewTextBoxColumn
            // 
            this.discountPercentDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.HeaderText = "DiscountPercent";
            this.discountPercentDataGridViewTextBoxColumn.Name = "discountPercentDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // comboBindingSource
            // 
            this.comboBindingSource.DataSource = typeof(ElectronicSales.Models.Combo);
            // 
            // SelectComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 315);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboList);
            this.Name = "SelectComboForm";
            this.Text = "SelectComboForm";
            ((System.ComponentModel.ISupportInitialize)(this.comboList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView comboList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn choose;
        private System.Windows.Forms.BindingSource comboBindingSource;
    }
}