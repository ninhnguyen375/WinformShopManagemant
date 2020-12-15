using ElectronicSales.Controllers;
using ElectronicSales.DTOs.Common;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.Helpers;
using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSales
{
    public partial class EditProductForm : Form
    {
        ProductListPage _productListPage;
        ErrorProvider errorProvider;
        List<Catalog> catalogs;
        private byte[] productImage;
        private string fileName;

        public EditProductForm(ProductListPage productListPage)
        {
            _productListPage = productListPage;

            InitializeComponent();

            CenterToScreen();

            getCatalogs();

            errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = this;

            tbProductName.Text = _productListPage.CurrentEditingProduct.ProductName;
            tbProductPrice.Text = _productListPage.CurrentEditingProduct.Price + "";
            inStockNumber.Value = _productListPage.CurrentEditingProduct.InStock;
            panelImage.BackgroundImage = _productListPage.CurrentEditingProduct.ProductImage;

            ImageConverter imgCon = new ImageConverter();
            productImage = (byte[])imgCon.ConvertTo(_productListPage.CurrentEditingProduct.ProductImage, typeof(byte[]));
            string[] splited = _productListPage.CurrentEditingProduct.ImageUrl.Split('/');
            fileName = splited[splited.Length - 1];
        }

        private async void getCatalogs()
        {
            var res = await CatalogController.GetAllCatalogs();

            catalogs = res.Data;
            cbProductCatalog.DataSource = res.Data;
            cbProductCatalog.DisplayMember = "CatalogName";
            cbProductCatalog.SelectedIndex = catalogs.FindIndex(c => c.Id.Equals(_productListPage.CurrentEditingProduct.Catalog.Id));
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            string productName = tbProductName.Text;
            string productPrice = tbProductPrice.Text;
            Catalog productCatalog = (Catalog)cbProductCatalog.SelectedItem;
            int catalogID = productCatalog == null ? -1 : productCatalog.Id;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(productName))
            {
                errorProvider.SetError(tbProductName, "Bat buoc");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbProductName, null);
            }
            if (string.IsNullOrWhiteSpace(productPrice))
            {
                errorProvider.SetError(tbProductPrice, "Ko hop le");
                isValid = false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(productPrice);
                    errorProvider.SetError(tbProductName, null);
                }
                catch (Exception)
                {
                    errorProvider.SetError(tbProductPrice, "Ko hop le");
                    isValid = false;
                }

            }
            if (catalogID == -1)
            {
                errorProvider.SetError(cbProductCatalog, "Ko hop le");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(cbProductCatalog, null);
            }

            if (!isValid)
            {
                return;
            }

            var res = await ProductController.UpdateProduct(
                _productListPage.CurrentEditingProduct.Id,
                productImage,
                fileName,
                new Product
                {
                    ProductName = productName,
                    Price = Convert.ToDecimal(productPrice),
                    CatalogId = catalogID,
                    InStock = Convert.ToInt32(inStockNumber.Value)
                });
            
            if(res == null)
            {
                return;
            }

            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<ProductErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            Notification.Success("Success");

            _productListPage.renderProducts();

            this.Hide();
        }

        private void chooseIamgeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = Path.GetFileName(openFileDialog1.FileName);
                productImage = File.ReadAllBytes(openFileDialog1.FileName);

                try
                {
                    MemoryStream ms = new MemoryStream(productImage);
                    panelImage.BackgroundImage = Image.FromStream(ms);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
