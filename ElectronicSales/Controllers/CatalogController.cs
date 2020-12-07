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
    static class CatalogController
    {
        public static async Task<ServerResponse<List<Catalog>, CatalogErrorMessage>> GetAllCatalogs()
        {
            var res = await FetchApi.GetAsync<List<Catalog>, CatalogErrorMessage>("catalogs");
            return res;
        }

        public static async Task<ServerResponse<Catalog, CatalogErrorMessage>> GetCatalogByID(int catalogID)
        {
            var res = await FetchApi.GetAsync<Catalog, CatalogErrorMessage>($"catalogs/{catalogID}");

            return res;
        }

        public static async Task<ServerResponse<object, CatalogErrorMessage>> CreateCatalog(Catalog catalog)
        {
            return await FetchApi.PostAsync<CatalogErrorMessage>("catalogs", catalog);
        }

        public static async Task<ServerResponse<object, CatalogErrorMessage>> UpdateCatalog(int catalogID, Catalog catalog)
        {
            return await FetchApi.PutAsync<CatalogErrorMessage>("catalogs/" + catalogID, catalog);
        }

        public static async Task<ServerResponse<object, CatalogErrorMessage>> DeleteCatalog(int catalogID)
        {
            return await FetchApi.DeleteAsync<CatalogErrorMessage>("catalogs/" + catalogID);
        }
    }
}
