using ElectronicSales;
using ElectronicSales.Constants;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.ResponseDTOs;
using ElectronicSales.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
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

        public static async Task<ServerResponse<object, ProductErrorMessage>> CreateProduct(byte[] productImage, string fileName, Product product)
        {
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new ByteArrayContent(productImage, 0, productImage.Length), "ProductImageFile", Regex.Replace(fileName, @"[\(\)]", "_"));
            form.Add(new StringContent(product.ProductName), "ProductName");
            form.Add(new StringContent(product.Price.ToString()), "Price");
            form.Add(new StringContent(product.CatalogId.ToString()), "CatalogId");

            return await FetchApi.PostMultipartAsync<ProductErrorMessage>("products", form);
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
