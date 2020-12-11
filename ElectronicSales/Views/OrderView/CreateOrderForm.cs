using ElectronicSales.Controllers;
using ElectronicSales.DTOs.Common;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.RequestDTOs;
using ElectronicSales.Helpers;
using ElectronicSales.Models;
using ElectronicSales.Views.ComboView;
using ElectronicSales.Views.ProductView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElectronicSales.DTOs.RequestDTOs.CreateOrderDTO;

namespace ElectronicSales.Views.UserView
{
    public partial class CreateOrderForm : Form
    {

        private User customer;
        private List<ProductOfOrder> products = new List<ProductOfOrder>();
        private List<ComboOfOrder> combos = new List<ComboOfOrder>();

        public CreateOrderForm()
        {
            InitializeComponent();
            CenterToScreen();

            productList.Columns[2].DefaultCellStyle.Format = "N";
            productList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            productList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            productList.Columns[4].DefaultCellStyle.Format = "N";
            productList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            productList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            comboList.Columns[2].DefaultCellStyle.Format = "N";
            comboList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            comboList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboList.Columns[4].DefaultCellStyle.Format = "N";
            comboList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            comboList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void chooseCustomerButton_Click(object sender, EventArgs e)
        {
            SelectCustomerForm form = new SelectCustomerForm(handleChoosedCustomer);
            form.Show();
        }

        private void handleChoosedCustomer(object item)
        {
            customer = (User)item;

            chooseCustomerButton.Text = customer.FullName;
            deliveryAddress.Text = customer.Address;
        }

        private void includeProductButton_Click(object sender, EventArgs e)
        {
            SelectProductForm form = new SelectProductForm(handleSelectProduct, products.ToList<object>());
            form.Show();
        }

        private void handleSelectProduct(object item)
        {
            Product p = (Product)item;

            InputAmountForm form = new InputAmountForm(amount =>
            {
                if (amount > p.InStock)
                {
                    Notification.Error("Out of stock");
                    return;
                }

                products.Add(new ProductOfOrder
                {
                    Id = p.Id,
                    IdString = p.IdString,
                    ProductName = p.ProductName,
                    Amount = amount,
                    Price = p.Price,
                    TotalPrice = p.Price * amount,
                });

                productList.DataSource = products.ToList();

                calculateTotalPrice();
            });

            form.Show();
        }

        private decimal calculateTotalPrice()
        {
            decimal total = 0;

            foreach (ProductOfOrder item in products)
            {
                total += item.TotalPrice;
            }

            foreach (ComboOfOrder item in combos)
            {
                total += item.TotalPrice;
            }

            totalPrice.Text = total.ToString("N");

            return total;
        }

        private void includeComboButton_Click(object sender, EventArgs e)
        {
            SelectComboForm form = new SelectComboForm(handleSelectCombo, combos.ToList<object>());
            form.Show();
        }

        private void handleSelectCombo(object item)
        {
            Combo p = (Combo)item;

            InputAmountForm form = new InputAmountForm(amount =>
            {
                combos.Add(new ComboOfOrder
                {
                    Id = p.Id,
                    IdString = p.IdString,
                    ComboName = p.ComboName,
                    Amount = amount,
                    Price = p.Price,
                    TotalPrice = p.Price * amount,
                });

                comboList.DataSource = combos.ToList();

                calculateTotalPrice();
            });

            form.Show();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();

            foreach (ComboOfOrder item in combos)
            {
                orderDetails.Add(new OrderDetailDTO
                {
                    ComboId = item.Id,
                    Amount = item.Amount,
                    TotalPrice = item.TotalPrice
                });
            }

            foreach (ProductOfOrder item in products)
            {
                orderDetails.Add(new OrderDetailDTO
                {
                    ProductId = item.Id,
                    Amount = item.Amount,
                    TotalPrice = item.TotalPrice
                });
            }

            if(string.IsNullOrWhiteSpace(deliveryAddress.Text))
            {
                Notification.Error("Vui lòng điền địa chỉ giao hàng");
                return;
            }

            var res = await OrderController.CreateOrder(new CreateOrderDTO
            {
                OrderDetails = orderDetails,
                CustomerId = customer.Id,
                DeliveryAddress = deliveryAddress.Text,
                TotalPrice = calculateTotalPrice(),
            });

            if (res == null) return;
            if(res.IsSuccess == false)
            {
                Notification.Error(HandleError<OrderErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            Notification.Success("Success");

            Close();
        }
    }
}
