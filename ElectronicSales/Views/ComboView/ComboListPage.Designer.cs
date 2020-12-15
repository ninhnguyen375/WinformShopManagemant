namespace ElectronicSales.Views.ProductView
{
    partial class ComboListPage
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
            this.comboGridView = new System.Windows.Forms.DataGridView();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addComboButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.comboGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboGridView
            // 
            this.comboGridView.AutoGenerateColumns = false;
            this.comboGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comboGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.comboGridView.BackgroundColor = System.Drawing.Color.White;
            this.comboGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comboGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.comboNameDataGridViewTextBoxColumn,
            this.OriginalPrice,
            this.DiscountPercent,
            this.Price,
            this.Edit,
            this.Delete});
            this.comboGridView.DataSource = this.comboBindingSource;
            this.comboGridView.Location = new System.Drawing.Point(3, 61);
            this.comboGridView.Name = "comboGridView";
            this.comboGridView.Size = new System.Drawing.Size(793, 377);
            this.comboGridView.TabIndex = 4;
            this.comboGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comboGridView_CellContentClick);
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.FillWeight = 76.18138F;
            this.idStringDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // comboNameDataGridViewTextBoxColumn
            // 
            this.comboNameDataGridViewTextBoxColumn.DataPropertyName = "ComboName";
            this.comboNameDataGridViewTextBoxColumn.FillWeight = 76.18138F;
            this.comboNameDataGridViewTextBoxColumn.HeaderText = "Tên Combo";
            this.comboNameDataGridViewTextBoxColumn.Name = "comboNameDataGridViewTextBoxColumn";
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.FillWeight = 76.18138F;
            this.OriginalPrice.HeaderText = "Giá gốc";
            this.OriginalPrice.Name = "OriginalPrice";
            // 
            // DiscountPercent
            // 
            this.DiscountPercent.DataPropertyName = "DiscountPercent";
            this.DiscountPercent.FillWeight = 76.18138F;
            this.DiscountPercent.HeaderText = "% giảm";
            this.DiscountPercent.Name = "DiscountPercent";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 76.18138F;
            this.Price.HeaderText = "Giá Combo";
            this.Price.Name = "Price";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Sửa";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 35F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // comboBindingSource
            // 
            this.comboBindingSource.DataSource = typeof(ElectronicSales.Models.Combo);
            // 
            // addComboButton
            // 
            this.addComboButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addComboButton.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComboButton.ForeColor = System.Drawing.Color.White;
            this.addComboButton.Location = new System.Drawing.Point(650, 24);
            this.addComboButton.Name = "addComboButton";
            this.addComboButton.Size = new System.Drawing.Size(146, 31);
            this.addComboButton.TabIndex = 3;
            this.addComboButton.Text = "THÊM MỚI COMBO";
            this.addComboButton.UseVisualStyleBackColor = false;
            this.addComboButton.Click += new System.EventHandler(this.addComboButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm theo tên:";
            // 
            // inputSearchName
            // 
            this.inputSearchName.Location = new System.Drawing.Point(3, 30);
            this.inputSearchName.Name = "inputSearchName";
            this.inputSearchName.Size = new System.Drawing.Size(185, 23);
            this.inputSearchName.TabIndex = 5;
            this.inputSearchName.TextChanged += new System.EventHandler(this.inputSearchName_TextChanged);
            // 
            // ComboListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearchName);
            this.Controls.Add(this.comboGridView);
            this.Controls.Add(this.addComboButton);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ComboListPage";
            this.Size = new System.Drawing.Size(799, 441);
            ((System.ComponentModel.ISupportInitialize)(this.comboGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView comboGridView;
        private System.Windows.Forms.BindingSource comboBindingSource;
        private System.Windows.Forms.Button addComboButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comboNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
