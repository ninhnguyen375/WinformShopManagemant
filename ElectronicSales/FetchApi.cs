using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.ResponseDTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales
{
    internal static class FetchApi
    {
        private static readonly HttpClient _client;

        static FetchApi()
        {
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/") };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<ServerResponse<D, M>> GetAsync<D, M>(string uri)
        {
            try
            {
                var response = await _client.GetAsync(uri);
                var data = await response.Content.ReadAsAsync<ServerResponse<D, M>>();

                return data;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
                return null;
                throw;
            }
        }

        public static async Task<ServerResponse<object, M>> PostAsync<M>(string uri, object data)
        {
            var res = await _client.PostAsJsonAsync(uri, data);
            return await res.Content.ReadAsAsync<ServerResponse<object, M>>();
        }

        public static async Task<ServerResponse<object, M>> PutAsync<M>(string uri, object data)
        {
            var res = await _client.PutAsJsonAsync(uri, data);

            return await res.Content.ReadAsAsync<ServerResponse<object, M>>();
        }

        public static async Task<ServerResponse<object, M>> DeleteAsync<M>(string uri)
        {
            var res = await _client.DeleteAsync(uri);
            return await res.Content.ReadAsAsync<ServerResponse<object, M>>();
        }

        public static async Task<ServerResponse<D, M>> PostAsync<D, M>(string uri, object data)
        {
            var res = await _client.PostAsJsonAsync(uri, data);
            return await res.Content.ReadAsAsync<ServerResponse<D, M>>();
        }
    }
}
