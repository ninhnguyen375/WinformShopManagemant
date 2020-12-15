namespace ElectronicSales
{
    partial class EditProductForm
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
            this.chooseIamgeButton = new System.Windows.Forms.Button();
            this.cbProductCatalog = new System.Windows.Forms.ComboBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelImage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.inStockNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseIamgeButton
            // 
            this.chooseIamgeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.chooseIamgeButton.ForeColor = System.Drawing.Color.White;
            this.chooseIamgeButton.Location = new System.Drawing.Point(15, 248);
            this.chooseIamgeButton.Name = "chooseIamgeButton";
            this.chooseIamgeButton.Size = new System.Drawing.Size(111, 27);
            this.chooseIamgeButton.TabIndex = 17;
            this.chooseIamgeButton.Text = "Chọn hình ảnh";
            this.chooseIamgeButton.UseVisualStyleBackColor = false;
            this.chooseIamgeButton.Click += new System.EventHandler(this.chooseIamgeButton_Click);
            // 
            // cbProductCatalog
            // 
            this.cbProductCatalog.FormattingEnabled = true;
            this.cbProductCatalog.Location = new System.Drawing.Point(15, 147);
            this.cbProductCatalog.Name = "cbProductCatalog";
            this.cbProductCatalog.Size = new System.Drawing.Size(243, 21);
            this.cbProductCatalog.TabIndex = 16;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(15, 87);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(243, 20);
            this.tbProductPrice.TabIndex = 15;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(15, 27);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(243, 20);
            this.tbProductName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn Catalog:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giá sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(132, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "CẬP NHẬT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Location = new System.Drawing.Point(132, 248);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(126, 126);
            this.panelImage.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng sản phẩm trong kho:";
            // 
            // inStockNumber
            // 
            this.inStockNumber.Location = new System.Drawing.Point(15, 205);
            this.inStockNumber.Name = "inStockNumber";
            this.inStockNumber.Size = new System.Drawing.Size(243, 20);
            this.inStockNumber.TabIndex = 20;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 445);
            this.Controls.Add(this.inStockNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooseIamgeButton);
            this.Controls.Add(this.cbProductCatalog);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelImage);
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseIamgeButton;
        private System.Windows.Forms.ComboBox cbProductCatalog;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inStockNumber;
    }
}