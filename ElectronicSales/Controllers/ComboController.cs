using ElectronicSales;
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.RequestDTOs;
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
    static class ComboController
    {
        public static async Task<ServerResponse<List<Combo>, ComboErrorMessage>> GetAllCombos()
        {
            var res = await FetchApi.GetAsync<List<Combo>, ComboErrorMessage>("combos");
            return res;
        }

        public static async Task<ServerResponse<Combo, ComboErrorMessage>> GetComboByID(int comboID)
        {
            var res = await FetchApi.GetAsync<Combo, ComboErrorMessage>($"combos/{comboID}");

            return res;
        }

        public static async Task<ServerResponse<object, ComboErrorMessage>> CreateCombo(Combo combo)
        {
            return await FetchApi.PostAsync<ComboErrorMessage>("combos", combo);
        }

        public static async Task<ServerResponse<object, ComboErrorMessage>> UpdateCombo(int comboID, object combo)
        {
            return await FetchApi.PutAsync<ComboErrorMessage>("combos/" + comboID, combo);
        }

        public static async Task<ServerResponse<object, ComboErrorMessage>> DeleteCombo(int comboID)
        {
            return await FetchApi.DeleteAsync<ComboErrorMessage>("combos/" + comboID);
        }
    }
}
