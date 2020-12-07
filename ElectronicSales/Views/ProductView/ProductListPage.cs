using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicSales.Models;
using ElectronicSales.Controllers;
using ElectronicSales.DTOs.ErrorMessages;
using System.Reflection;
using ElectronicSales.DTOs.Common;
using ElectronicSales.Helpers;

namespace ElectronicSales
{
    public partial class ProductListPage : UserControl
    {
        private Product currentEditingProduct;
        private List<Product> products;
        private List<Product> filteredProducts;

        internal Product CurrentEditingProduct
        {
            get
            {
                return currentEditingProduct;
            }

            set
            {
                currentEditingProduct = value;
            }
        }

        public ProductListPage()
        {
            InitializeComponent();
            productGridView.Columns[4].DefaultCellStyle.Format = "N";

            renderProducts();
        }

        public async Task getProducts()
        {
            var res = await ProductController.GetAllProducts();

            if (res == null || res.Data == null)
            {
                return;
            }

            products = res.Data;
            filteredProducts = res.Data;
        }

        public async void renderProducts()
        {
            await getProducts();

            filter();

            productGridView.DataSource = filteredProducts;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(this);
            addProductForm.Show();
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex != -1)
            {
                currentEditingProduct = filteredProducts.ElementAt(e.RowIndex);

                EditProductForm editForm = new EditProductForm(this);
                editForm.Show();
            }

            if (productGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Are you sure",
                    "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteProduct(filteredProducts.ElementAt(e.RowIndex).Id);
                }
            }
        }

        public async void DeleteProduct(int id)
        {
            var res = await ProductController.DeleteProduct(id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<ProductErrorMessage>.GetErrorString(res.Messages));
            }
            else
            {
                Notification.Success("Success");
                renderProducts();
            }
        }

        private void filter()
        {
            string name = inputSearchName.Text;
            List<Product> result = new List<Product>();

            if (string.IsNullOrWhiteSpace(name))
            {
                filteredProducts = products;
                return;
            }

            name = name.Trim().ToLower();

            foreach (Product item in products)
            {
                if (item.ProductName.ToLower().Contains(name))
                {
                    result.Add(item);
                }
            }

            filteredProducts = result;
        }

        private void inputSearchName_TextChanged(object sender, EventArgs e)
        {
            renderProducts();
        }
    }
}
