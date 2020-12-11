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

namespace ElectronicSales.Views.UserView
{
    public partial class OrderDetail : Form
    {
        private Order order;
        private int orderID;

        public OrderDetail(int orderID)
        {
            InitializeComponent();
            // format price
            productOfOrderList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            productOfOrderList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            productOfOrderList.Columns[2].DefaultCellStyle.Format = "N";
            productOfOrderList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productOfOrderList.Columns[4].DefaultCellStyle.Format = "N";
            productOfOrderList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productOfOrderList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            productOfOrderList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            comboOfOrderList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            comboOfOrderList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            comboOfOrderList.Columns[2].DefaultCellStyle.Format = "N";
            comboOfOrderList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboOfOrderList.Columns[4].DefaultCellStyle.Format = "N";
            comboOfOrderList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboOfOrderList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            comboOfOrderList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            // format amount
            productOfOrderList.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            productOfOrderList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            comboOfOrderList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            comboOfOrderList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOfOrderList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.orderID = orderID;

            renderOrder();
        }

        private async Task<bool> getOrderDetail()
        {
            var res = await OrderController.GetOrderByID(orderID);

            if(res == null)
            {
                return false;
            }

            if(!res.IsSuccess)
            {
                Notification.Error(HandleError<OrderErrorMessage>.GetErrorString(res.Messages));
                return false;
            }

            order = res.Data;
            return true;
        }

        private async void renderOrder()
        {
            bool res = await getOrderDetail();

            if(!res)
            {
                return;
            }

            idString.Text = order.IdString;
            customerName.Text = order.Customer != null ? order.Customer.FullName : "---";
            employeeName.Text = order.Employee != null ? order.Employee.FullName : "---";
            createdAt.Text = Format.getDisplayString(order, "CreatedAt");
            status.Text = Format.getDisplayString(order, "Status");
            orderTotalPrice.Text = Format.getDisplayString(order, "TotalPrice");
            deliveryDate.Text = Format.getDisplayString(order, "DeliveryDate");
            deliveryAddress.Text = Format.getDisplayString(order, "DeliveryAddress");

            comboOfOrderList.DataSource = order.Combos;
            productOfOrderList.DataSource = order.Products;
        }
    }
}
