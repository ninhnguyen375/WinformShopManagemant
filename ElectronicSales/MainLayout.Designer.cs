using ElectronicSales.Constants;
using System.Drawing;

namespace ElectronicSales
{
    partial class MainLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.comboButton = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.productButton = new System.Windows.Forms.Panel();
            this.productIcon = new System.Windows.Forms.PictureBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.catalogButton = new System.Windows.Forms.Panel();
            this.catalogIcon = new System.Windows.Forms.PictureBox();
            this.catalogLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.comboListPage = new ElectronicSales.Views.ComboView.ComboListPage();
            this.productListPage = new ElectronicSales.ProductListPage();
            this.catalogListPage = new ElectronicSales.CatalogListPage();
            this.sideBarPanel.SuspendLayout();
            this.comboButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.productButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIcon)).BeginInit();
            this.catalogButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogIcon)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.sideBarPanel.Controls.Add(this.comboButton);
            this.sideBarPanel.Controls.Add(this.Brand);
            this.sideBarPanel.Controls.Add(this.productButton);
            this.sideBarPanel.Controls.Add(this.catalogButton);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 500);
            this.sideBarPanel.TabIndex = 0;
            // 
            // comboButton
            // 
            this.comboButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.comboButton.Controls.Add(this.pictureBox2);
            this.comboButton.Controls.Add(this.label1);
            this.comboButton.Location = new System.Drawing.Point(0, 169);
            this.comboButton.Name = "comboButton";
            this.comboButton.Size = new System.Drawing.Size(200, 39);
            this.comboButton.TabIndex = 6;
            this.comboButton.Click += new System.EventHandler(this.sideBarComboButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.sideBarComboButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combo";
            this.label1.Click += new System.EventHandler(this.sideBarComboButton_Click);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Source Sans Pro Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ForeColor = System.Drawing.Color.White;
            this.Brand.Location = new System.Drawing.Point(22, 23);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(156, 27);
            this.Brand.TabIndex = 3;
            this.Brand.Text = "ElectronicShop";
            this.Brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.productButton.Controls.Add(this.productIcon);
            this.productButton.Controls.Add(this.productLabel);
            this.productButton.Location = new System.Drawing.Point(0, 124);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(200, 39);
            this.productButton.TabIndex = 5;
            this.productButton.Click += new System.EventHandler(this.sideBarProductButton_Click);
            // 
            // productIcon
            // 
            this.productIcon.Image = ((System.Drawing.Image)(resources.GetObject("productIcon.Image")));
            this.productIcon.Location = new System.Drawing.Point(3, 8);
            this.productIcon.Name = "productIcon";
            this.productIcon.Size = new System.Drawing.Size(27, 24);
            this.productIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productIcon.TabIndex = 1;
            this.productIcon.TabStop = false;
            this.productIcon.Click += new System.EventHandler(this.sideBarProductButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.Color.White;
            this.productLabel.Location = new System.Drawing.Point(36, 11);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(76, 19);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Sản phẩm";
            this.productLabel.Click += new System.EventHandler(this.sideBarProductButton_Click);
            // 
            // catalogButton
            // 
            this.catalogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.catalogButton.Controls.Add(this.catalogIcon);
            this.catalogButton.Controls.Add(this.catalogLabel);
            this.catalogButton.Location = new System.Drawing.Point(0, 79);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(200, 39);
            this.catalogButton.TabIndex = 4;
            this.catalogButton.Click += new System.EventHandler(this.sideBarCatalogButton_Click);
            // 
            // catalogIcon
            // 
            this.catalogIcon.Image = ((System.Drawing.Image)(resources.GetObject("catalogIcon.Image")));
            this.catalogIcon.Location = new System.Drawing.Point(3, 8);
            this.catalogIcon.Name = "catalogIcon";
            this.catalogIcon.Size = new System.Drawing.Size(27, 24);
            this.catalogIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catalogIcon.TabIndex = 1;
            this.catalogIcon.TabStop = false;
            this.catalogIcon.Click += new System.EventHandler(this.sideBarCatalogButton_Click);
            // 
            // catalogLabel
            // 
            this.catalogLabel.AutoSize = true;
            this.catalogLabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogLabel.ForeColor = System.Drawing.Color.White;
            this.catalogLabel.Location = new System.Drawing.Point(36, 11);
            this.catalogLabel.Name = "catalogLabel";
            this.catalogLabel.Size = new System.Drawing.Size(146, 19);
            this.catalogLabel.TabIndex = 0;
            this.catalogLabel.Text = "Danh mục sản phẩm";
            this.catalogLabel.Click += new System.EventHandler(this.sideBarCatalogButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(799, 50);
            this.headerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userEmailLabel);
            this.panel1.Location = new System.Drawing.Point(531, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 47);
            this.panel1.TabIndex = 4;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userEmailLabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailLabel.Location = new System.Drawing.Point(153, 0);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.userEmailLabel.Size = new System.Drawing.Size(47, 21);
            this.userEmailLabel.TabIndex = 0;
            this.userEmailLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.comboListPage);
            this.contentPanel.Controls.Add(this.productListPage);
            this.contentPanel.Controls.Add(this.catalogListPage);
            this.contentPanel.Location = new System.Drawing.Point(200, 56);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(799, 441);
            this.contentPanel.TabIndex = 3;
            // 
            // comboListPage
            // 
            this.comboListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboListPage.Location = new System.Drawing.Point(0, 0);
            this.comboListPage.Name = "comboListPage";
            this.comboListPage.Size = new System.Drawing.Size(799, 441);
            this.comboListPage.TabIndex = 2;
            // 
            // productListPage
            // 
            this.productListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPage.Location = new System.Drawing.Point(0, 0);
            this.productListPage.Name = "productListPage";
            this.productListPage.Size = new System.Drawing.Size(799, 441);
            this.productListPage.TabIndex = 1;
            // 
            // catalogListPage
            // 
            this.catalogListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogListPage.Location = new System.Drawing.Point(0, 0);
            this.catalogListPage.Name = "catalogListPage";
            this.catalogListPage.Size = new System.Drawing.Size(799, 441);
            this.catalogListPage.TabIndex = 0;
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "MainLayout";
            this.Text = "MainLayout";
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            this.comboButton.ResumeLayout(false);
            this.comboButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.productButton.ResumeLayout(false);
            this.productButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIcon)).EndInit();
            this.catalogButton.ResumeLayout(false);
            this.catalogButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogIcon)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Panel productButton;
        private System.Windows.Forms.PictureBox productIcon;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Panel catalogButton;
        private System.Windows.Forms.PictureBox catalogIcon;
        private System.Windows.Forms.Label catalogLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contentPanel;
        private CatalogListPage catalogListPage;
        private ProductListPage productListPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userEmailLabel;
        private Views.ComboView.ComboListPage comboListPage;
        private System.Windows.Forms.Panel comboButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}