namespace ElectronicSales
{
    partial class AddProductForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.cbProductCatalog = new System.Windows.Forms.ComboBox();
            this.chooseIamgeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Catalog:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(27, 29);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(228, 20);
            this.tbProductName.TabIndex = 5;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(27, 81);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(228, 20);
            this.tbProductPrice.TabIndex = 6;
            // 
            // cbProductCatalog
            // 
            this.cbProductCatalog.FormattingEnabled = true;
            this.cbProductCatalog.Location = new System.Drawing.Point(27, 133);
            this.cbProductCatalog.Name = "cbProductCatalog";
            this.cbProductCatalog.Size = new System.Drawing.Size(228, 21);
            this.cbProductCatalog.TabIndex = 7;
            // 
            // chooseIamgeButton
            // 
            this.chooseIamgeButton.Location = new System.Drawing.Point(28, 242);
            this.chooseIamgeButton.Name = "chooseIamgeButton";
            this.chooseIamgeButton.Size = new System.Drawing.Size(111, 23);
            this.chooseIamgeButton.TabIndex = 8;
            this.chooseIamgeButton.Text = "Choose Image";
            this.chooseIamgeButton.UseVisualStyleBackColor = true;
            this.chooseIamgeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(145, 175);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(110, 90);
            this.panelImage.TabIndex = 9;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.chooseIamgeButton);
            this.Controls.Add(this.cbProductCatalog);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.ComboBox cbProductCatalog;
        private System.Windows.Forms.Button chooseIamgeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelImage;
    }
}