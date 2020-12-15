namespace ElectronicSales
{
    partial class CatalogListPage
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
            this.catalogGridView = new System.Windows.Forms.DataGridView();
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCatalogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.catalogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogGridView
            // 
            this.catalogGridView.AutoGenerateColumns = false;
            this.catalogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.catalogGridView.BackgroundColor = System.Drawing.Color.White;
            this.catalogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStringDataGridViewTextBoxColumn,
            this.catalogNameDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.catalogGridView.DataSource = this.catalogBindingSource;
            this.catalogGridView.Location = new System.Drawing.Point(3, 61);
            this.catalogGridView.Name = "catalogGridView";
            this.catalogGridView.Size = new System.Drawing.Size(793, 377);
            this.catalogGridView.TabIndex = 4;
            this.catalogGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalogGridView_CellContentClick);
            // 
            // idStringDataGridViewTextBoxColumn
            // 
            this.idStringDataGridViewTextBoxColumn.DataPropertyName = "IdString";
            this.idStringDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStringDataGridViewTextBoxColumn.Name = "idStringDataGridViewTextBoxColumn";
            // 
            // catalogNameDataGridViewTextBoxColumn
            // 
            this.catalogNameDataGridViewTextBoxColumn.DataPropertyName = "CatalogName";
            this.catalogNameDataGridViewTextBoxColumn.HeaderText = "Tên Catalog";
            this.catalogNameDataGridViewTextBoxColumn.Name = "catalogNameDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 14.13334F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Sửa";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 18.84446F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataSource = typeof(ElectronicSales.Models.Catalog);
            // 
            // addCatalogButton
            // 
            this.addCatalogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addCatalogButton.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.addCatalogButton.ForeColor = System.Drawing.Color.White;
            this.addCatalogButton.Location = new System.Drawing.Point(624, 24);
            this.addCatalogButton.Name = "addCatalogButton";
            this.addCatalogButton.Size = new System.Drawing.Size(172, 31);
            this.addCatalogButton.TabIndex = 3;
            this.addCatalogButton.Text = "THÊM MỚI CATALOG";
            this.addCatalogButton.UseVisualStyleBackColor = false;
            this.addCatalogButton.Click += new System.EventHandler(this.addCatalogButton_Click);
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
            // CatalogListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearchName);
            this.Controls.Add(this.catalogGridView);
            this.Controls.Add(this.addCatalogButton);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CatalogListPage";
            this.Size = new System.Drawing.Size(799, 441);
            ((System.ComponentModel.ISupportInitialize)(this.catalogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catalogGridView;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private System.Windows.Forms.Button addCatalogButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
