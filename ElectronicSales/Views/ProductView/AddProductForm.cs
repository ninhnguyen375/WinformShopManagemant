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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSales
{
    public partial class AddProductForm : Form
    {
        ProductListPage _productListPage;
        ErrorProvider errorProvider;

        public AddProductForm(ProductListPage productListPage)
        {
            _productListPage = productListPage;

            InitializeComponent();

            CenterToScreen();

            getCatalogs();

            errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = this;
        }

        private async void getCatalogs()
        {
            var res = await CatalogController.GetAllCatalogs();

            cbProductCatalog.DataSource = res.Data;
            cbProductCatalog.DisplayMember = "CatalogName";
        }

        private async void button1_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(productPrice) || !productPrice.All(char.IsNumber))
            {
                errorProvider.SetError(tbProductPrice, "Ko hop le");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbProductName, null);
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

            var res = await ProductController.CreateProduct(new Product
            {
                ProductName = productName,
                Price = Convert.ToDecimal(productPrice),
                InStock = 0,
                CatalogId = catalogID
            });

            if(!res.IsSuccess)
            {
                Notification.Error(HandleError<ProductErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            Notification.Success("Success");

            _productListPage.renderProducts();

            this.Hide();
        }
    }
}
