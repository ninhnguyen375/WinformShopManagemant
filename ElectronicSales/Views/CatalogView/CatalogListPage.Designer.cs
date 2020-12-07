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
            this.addCatalogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSearchName = new System.Windows.Forms.TextBox();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.catalogGridView.Location = new System.Drawing.Point(3, 53);
            this.catalogGridView.Name = "catalogGridView";
            this.catalogGridView.Size = new System.Drawing.Size(793, 375);
            this.catalogGridView.TabIndex = 4;
            this.catalogGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalogGridView_CellContentClick);
            // 
            // addCatalogButton
            // 
            this.addCatalogButton.Location = new System.Drawing.Point(685, 24);
            this.addCatalogButton.Name = "addCatalogButton";
            this.addCatalogButton.Size = new System.Drawing.Size(111, 23);
            this.addCatalogButton.TabIndex = 3;
            this.addCatalogButton.Text = "Add New Catalog";
            this.addCatalogButton.UseVisualStyleBackColor = true;
            this.addCatalogButton.Click += new System.EventHandler(this.addCatalogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search by name:";
            // 
            // inputSearchName
            // 
            this.inputSearchName.Location = new System.Drawing.Point(3, 26);
            this.inputSearchName.Name = "inputSearchName";
            this.inputSearchName.Size = new System.Drawing.Size(185, 20);
            this.inputSearchName.TabIndex = 5;
            this.inputSearchName.TextChanged += new System.EventHandler(this.inputSearchName_TextChanged);
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataSource = typeof(ElectronicSales.Models.Catalog);
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
            this.catalogNameDataGridViewTextBoxColumn.HeaderText = "Catalog Name";
            this.catalogNameDataGridViewTextBoxColumn.Name = "catalogNameDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 14.13334F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
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
            // CatalogListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearchName);
            this.Controls.Add(this.catalogGridView);
            this.Controls.Add(this.addCatalogButton);
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
