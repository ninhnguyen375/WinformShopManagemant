using ElectronicSales.Controllers;
using ElectronicSales.DTOs.Common;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.RequestDTOs;
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

namespace ElectronicSales.Views.ProductView
{
    public partial class AddComboForm : Form
    {

        ComboListPage _comboListPage;
        ErrorProvider errorProvider;
        List<Product> products = new List<Product>();

        public AddComboForm(ComboListPage comboListPage)
        {
            _comboListPage = comboListPage;

            InitializeComponent();

            CenterToScreen();
            productOfComboList.Columns[3].DefaultCellStyle.Format = "N";

            errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = this;

            renderCombo();
        }

        private void renderCombo()
        {
            productOfComboList.DataSource = products;
            originalPrice.Text = calculateOriginalPrice().ToString("N");
            price.Text = calculatePrice().ToString("N");
        }

        private decimal calculateOriginalPrice()
        {
            decimal originalPrice = 0;

            foreach (Product item in products)
            {
                originalPrice += item.Price;
            }

            return originalPrice;
        }

        private decimal calculatePrice()
        {
            decimal originalP = calculateOriginalPrice();
            return (originalP - (originalP  * discountPercentNumber.Value / 100));
        }

        private async void createComboButton_Click(object sender, EventArgs e)
        {
            string comboName = tbComboName.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(comboName))
            {
                errorProvider.SetError(tbComboName, "Bat buoc");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbComboName, null);
            }

            if (discountPercentNumber.Value < 0)
            {
                errorProvider.SetError(discountPercentNumber, "Ko hop le");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(discountPercentNumber, null);
            }

            if (!isValid)
            {
                return;
            }

            List<int> productIDs = new List<int>();

            foreach (Product item in products)
            {
                productIDs.Add(item.Id);
            }


            var res = await ComboController.CreateCombo(
                new CreateComboDTO
                {
                    ComboName = comboName,
                    OriginalPrice = calculateOriginalPrice().ToString(),
                    Price = calculatePrice().ToString(),
                    DiscountPercent = Convert.ToInt32(discountPercentNumber.Value),
                    ProductIds = productIDs
                });

            if (res == null)
            {
                return;
            }
            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<ComboErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            Notification.Success("Success");

            _comboListPage.renderCombos();

            this.Close();
        }

        private void productOfComboList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productOfComboList.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (Notification.Confirm("Are you sure?"))
                {
                    List<Product> tmpProducts = products.ToList();
                    int deletedProductID = tmpProducts.ElementAt(e.RowIndex).Id;

                    tmpProducts.RemoveAt(e.RowIndex);
                    products = tmpProducts;

                    renderCombo();
                }
            }
        }

        private void addProductToComboButton_Click(object sender, EventArgs e)
        {
            SelectProductForm form = new SelectProductForm(handleSelectProduct, products.ToList<object>());
            form.Show();
        }

        private void handleSelectProduct(object value)
        {
            Product product = (Product)value;

            List<Product> tmpProducts = products.ToList();
            tmpProducts.Add(product);

            products = tmpProducts;

            renderCombo();
        }

        private void discountPercentNumber_ValueChanged(object sender, EventArgs e)
        {
            renderCombo();
        }
    }
}
