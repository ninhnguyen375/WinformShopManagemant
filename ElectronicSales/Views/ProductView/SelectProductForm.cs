using ElectronicSales.Controllers;
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
    public partial class SelectProductForm : Form
    {

        private List<Product> products;
        private List<Product> filteredProducts;
        private Action<object> _callback;
        private List<object> _excludes;

        public SelectProductForm(Action<object> callback, List<object> excludes)
        {
            _callback = callback;
            _excludes = excludes;

            InitializeComponent();
            CenterToScreen();
            productList.Columns[4].DefaultCellStyle.Format = "N";

            renderProducts(true);
        }

        private async void renderProducts(bool hard)
        {
            if(hard)
            {
                await getProducts();

                productList.DataSource = products;
            } else
            {
                productList.DataSource = filteredProducts == null ? products : filteredProducts;
            }
        }

        private async Task getProducts()
        {
            var res = await ProductController.GetAllProducts();

            if (res == null || res.Data == null)
            {
                return;
            }

            List<int> exludeIDs = new List<int>();

            foreach (object item in _excludes)
            {
                exludeIDs.Add(((Product)item).Id);
            }

            var result = res.Data.Where(item => !exludeIDs.Contains(item.Id)).ToList();

            products = result.ToList<Product>();
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productList.Columns[e.ColumnIndex].Name == "ProductImage" && e.RowIndex != -1)
            {
                ViewImageForm form = new ViewImageForm(filteredProducts.ElementAt(e.RowIndex).ProductImage);

                form.Show();
            }

            if (productList.Columns[e.ColumnIndex].Name == "choose" && e.RowIndex != -1)
            {
                _callback(products.ElementAt(e.RowIndex));
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            filteredProducts = products.ToList();

            if (string.IsNullOrWhiteSpace(value))
            {
                filteredProducts = null;
            }
            else
            {
                filteredProducts = filteredProducts
                    .Where(item =>
                        item.ProductName.ToLower().Contains(value.Trim().ToLower()))
                    .ToList();
            }

            renderProducts(false);
        }
    }
}
