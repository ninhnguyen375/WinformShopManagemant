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
using ElectronicSales.Helpers;
using ElectronicSales.DTOs.Common;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.RequestDTOs;
using ElectronicSales.DTOs.ResponseDTOs;
using ElectronicSales.Constants;

namespace ElectronicSales.Views.UserView
{
    public partial class OrderListPage : UserControl
    {
        private Order currentEditingOrder;
        private List<Order> orders;
        private List<Order> filteredOrders;

        public OrderListPage()
        {
            InitializeComponent();

            orderGridView.Columns[4].DefaultCellStyle.Format = "N";
            orderGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            renderOrders();
        }

        public async Task getOrders()
        {
            var res = await OrderController.GetAllOrders();

            if (res == null || res.Data == null)
            {
                return;
            }

            orders = res.Data;
            filteredOrders = res.Data;
        }

        public async void renderOrders()
        {
            await getOrders();

            filter();

            orderGridView.DataSource = filteredOrders;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            //AddOrderForm addOrderForm = new AddOrderForm(this);
            //addOrderForm.Show();
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orderGridView.Columns[e.ColumnIndex].Name == "View" && e.RowIndex != -1)
            {
                currentEditingOrder = filteredOrders.ElementAt(e.RowIndex);

                OrderDetail detail = new OrderDetail(orders.ElementAt(e.RowIndex).Id);

                detail.Show();
            }

            if (orderGridView.Columns[e.ColumnIndex].Name == "Accept" && e.RowIndex != -1)
            {
                if(!orders.ElementAt(e.RowIndex).Status.Equals(OrderStatus.New))
                {
                    return;
                }

                if (Notification.Confirm("Are you sure?"))
                {
                    AcceptOrderForm acceptForm = new AcceptOrderForm(confirmOrder, orders.ElementAt(e.RowIndex).Id);
                    acceptForm.Show();
                }
            }

            if (orderGridView.Columns[e.ColumnIndex].Name == "Refuse" && e.RowIndex != -1)
            {
                if (!orders.ElementAt(e.RowIndex).Status.Equals(OrderStatus.New))
                {
                    return;
                }

                if (Notification.Confirm("Are you sure?"))
                {
                    confirmOrder(orders.ElementAt(e.RowIndex).Id, false, DateTime.Now);
                }
            }

            if (orderGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Are you sure",
                    "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteOrder(filteredOrders.ElementAt(e.RowIndex).Id);
                }
            }
        }

        public async void confirmOrder(int orderID, bool isAccept, DateTime delivaeryDate)
        {
            ServerResponse<object, OrderErrorMessage> res;

            if (isAccept)
            {
                res = await OrderController.AcceptOrder(
                    orderID,
                    new ConfirmOrderDTO
                    {
                        EmployeeId = Store.user.Id,
                        DeliveryDate = delivaeryDate
                    });
            }
            else
            {
                res = await OrderController.RefuseOrder(
                    orderID,
                    new ConfirmOrderDTO
                    {
                        EmployeeId = Store.user.Id
                    });
            }

            if (res == null) return;

            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<OrderErrorMessage>.GetErrorString(res.Messages));
            } else
            {
                Notification.Success("Success");
                renderOrders();
            }
        }

        public async void DeleteOrder(int id)
        {
            var res = await OrderController.DeleteOrder(id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<OrderErrorMessage>.GetErrorString(res.Messages));
            }
            else
            {
                Notification.Success("Success");
                renderOrders();
            }
        }

        private void filter()
        {
            string keywords = inputKeywords.Text;
            List<Order> result = new List<Order>();

            if (string.IsNullOrWhiteSpace(keywords))
            {
                filteredOrders = orders;
                return;
            }

            keywords = keywords.Trim().ToLower();

            foreach (Order item in orders)
            {
                if (item.IdString.ToLower().Contains(keywords) || item.Status.ToLower().Contains(keywords))
                {
                    result.Add(item);
                }
            }

            filteredOrders = result;
        }

        private void inputKeywords_TextChanged(object sender, EventArgs e)
        {
            renderOrders();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            renderOrders();
        }
    }
}
