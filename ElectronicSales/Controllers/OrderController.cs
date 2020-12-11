using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.RequestDTOs;
using ElectronicSales.DTOs.ResponseDTOs;
using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Controllers
{
    class OrderController
    {
        public static async Task<ServerResponse<List<Order>, OrderErrorMessage>> GetAllOrders()
        {
            var res = await FetchApi.GetAsync<List<Order>, OrderErrorMessage>("orders");
            return res;
        }

        public static async Task<ServerResponse<Order, OrderErrorMessage>> GetOrderByID(int orderID)
        {
            var res = await FetchApi.GetAsync<Order, OrderErrorMessage>($"orders/{orderID}");

            return res;
        }

        public static async Task<ServerResponse<object, OrderErrorMessage>> CreateOrder(CreateOrderDTO order)
        {
            return await FetchApi.PostAsync<OrderErrorMessage>("orders", order);
        }

        public static async Task<ServerResponse<object, OrderErrorMessage>> UpdateOrder(int orderID, Order order)
        {
            return await FetchApi.PutAsync<OrderErrorMessage>($"orders/{orderID}", order);
        }

        public static async Task<ServerResponse<object, OrderErrorMessage>> DeleteOrder(int orderID)
        {
            return await FetchApi.DeleteAsync<OrderErrorMessage>($"orders/{orderID}");
        }

        public static async Task<ServerResponse<object, OrderErrorMessage>> AcceptOrder(int orderID, ConfirmOrderDTO data)
        {
            return await FetchApi.PostAsync<OrderErrorMessage>($"orders/{orderID}/accept", data);
        }

        public static async Task<ServerResponse<object, OrderErrorMessage>> RefuseOrder(int orderID, ConfirmOrderDTO data)
        {
            return await FetchApi.PostAsync<OrderErrorMessage>($"orders/{orderID}/refuse", data);
        }
    }
}
