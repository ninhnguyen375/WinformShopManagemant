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
    public partial class EditComboForm : Form
    {
        ComboListPage _comboListPage;
        ErrorProvider errorProvider;
        Combo combo;
        List<int> deletedProductIds = new List<int>();
        List<int> insertedProductIds = new List<int>();

        public EditComboForm(ComboListPage comboListPage)
        {
            _comboListPage = comboListPage;

            InitializeComponent();

            CenterToScreen();

            errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = this;

            renderCombo(true);
        }

        private async void renderCombo(bool hard)
        {
            if (hard)
            {
                await getCombo();
            }

            tbComboName.Text = combo.ComboName;
            productOfComboList.DataSource = combo.products;
            discountPercentNumber.Value = combo.DiscountPercent;
            idString.Text = combo.IdString;
            originalPrice.Text = combo.OriginalPrice.ToString("N");
            price.Text = combo.Price.ToString("N");

            productOfComboList.Columns[4].DefaultCellStyle.Format = "N";
        }

        private async Task getCombo()
        {
            var res = await ComboController.GetComboByID(_comboListPage.CurrentEditingCombo.Id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<ComboErrorMessage>.GetErrorString(res.Messages));
            }

            combo = res.Data;
        }

        private async void updateComboButton_Click(object sender, EventArgs e)
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

            decimal originalPrice = 0;

            foreach (Product item in combo.products)
            {
                originalPrice += item.Price;
            }


            var res = await ComboController.UpdateCombo(
                combo.Id,
                new UpdateComboDTO
                {
                    ComboName = comboName,
                    OriginalPrice = originalPrice.ToString(),
                    Price = (originalPrice - (originalPrice * discountPercentNumber.Value / 100)).ToString(),
                    DiscountPercent = Convert.ToInt32(discountPercentNumber.Value),
                    DeletedProductIds = deletedProductIds,
                    InsertedProductIds = insertedProductIds
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

            deletedProductIds = new List<int>();
            insertedProductIds = new List<int>();

            _comboListPage.renderCombos();

            this.renderCombo(true);
        }

        private void productOfComboList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productOfComboList.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (Notification.Confirm("Are you sure?"))
                {
                    List<Product> tmpProducts = combo.products.ToList();
                    int deletedProductID = tmpProducts.ElementAt(e.RowIndex).Id;

                    deletedProductIds.Add(deletedProductID);

                    tmpProducts.RemoveAt(e.RowIndex);
                    combo.products = tmpProducts;

                    renderCombo(false);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectProductForm form = new SelectProductForm(handleSelectProduct, combo.products.ToList<object>());
            form.Show();
        }

        private void handleSelectProduct(object value)
        {
            Product product = (Product)value;
            insertedProductIds.Add(product.Id);

            List<Product> tmpProducts = combo.products.ToList();
            tmpProducts.Add(product);

            combo.products = tmpProducts;

            renderCombo(false);
        }
    }
}
