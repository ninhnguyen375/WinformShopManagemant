using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.ResponseDTOs;
using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Controllers
{
    static class UserController
    {
        public static async Task<ServerResponse<List<User>, UserErrorMessage>> GetAllUsers()
        {
            var res = await FetchApi.GetAsync<List<User>, UserErrorMessage>("users");
            return res;
        }

        public static async Task<ServerResponse<User, UserErrorMessage>> GetUserByID(int userID)
        {
            var res = await FetchApi.GetAsync<User, UserErrorMessage>($"users/{userID}");

            return res;
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> CreateUser(User user)
        {
            return await FetchApi.PostAsync<UserErrorMessage>("users", user);
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> UpdateUser(int userID, User user)
        {
            return await FetchApi.PutAsync<UserErrorMessage>("users/" + userID, user);
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> DeleteUser(int userID)
        {
            return await FetchApi.DeleteAsync<UserErrorMessage>("users/" + userID);
        }

        public static async Task<ServerResponse<User, UserErrorMessage>> Login(string email, string password)
        {
            return await FetchApi.PostAsync<User, UserErrorMessage>("user/login", new { email, password });
        }
    }
}
