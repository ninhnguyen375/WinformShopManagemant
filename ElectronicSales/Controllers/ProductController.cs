using ElectronicSales;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.ResponseDTOs;
using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Controllers
{
    static class ProductController
    {
        public static async Task<ServerResponse<List<Product>, ProductErrorMessage>> GetAllProducts()
        {
            var res = await FetchApi.GetAsync<List<Product>, ProductErrorMessage>("products");
            return res;
        }

        public static async Task<ServerResponse<Product, ProductErrorMessage>> GetProductByID(int productID)
        {
            var res = await FetchApi.GetAsync<Product, ProductErrorMessage>($"products/{productID}");

            return res;
        }

        public static async Task<ServerResponse<object, ProductErrorMessage>> CreateProduct(Product product)
        {
            return await FetchApi.PostAsync<ProductErrorMessage>("products", product);
        }

        public static async Task<ServerResponse<object, ProductErrorMessage>> UpdateProduct(int productID, Product product)
        {
            return await FetchApi.PutAsync<ProductErrorMessage>("products/" + productID, product);
        }

        public static async Task<ServerResponse<object, ProductErrorMessage>> DeleteProduct(int productID)
        {
            return await FetchApi.DeleteAsync<ProductErrorMessage>("products/" + productID);
        }
    }
}
