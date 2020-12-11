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
        public static async Task<List<User>> GetAllUsers(string role)
        {
            var res = await FetchApi.GetAsync<List<User>, UserErrorMessage>("user");
            if (res == null || !res.IsSuccess) return null;

            List<User> users = new List<User>();
            foreach (User item in res.Data)
            {
                if (item.RoleName.Equals(role))
                {
                    users.Add(item);
                }
            }

            return users;
        }

        public static async Task<ServerResponse<User, UserErrorMessage>> GetUserByID(int userID)
        {
            var res = await FetchApi.GetAsync<User, UserErrorMessage>($"user/{userID}");

            return res;
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> CreateUser(User user)
        {
            return await FetchApi.PostAsync<UserErrorMessage>("user", user);
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> UpdateUser(int userID, User user)
        {
            return await FetchApi.PutAsync<UserErrorMessage>("user/" + userID, user);
        }

        public static async Task<ServerResponse<object, UserErrorMessage>> DeleteUser(int userID)
        {
            return await FetchApi.DeleteAsync<UserErrorMessage>("user/" + userID);
        }

        public static async Task<ServerResponse<User, UserErrorMessage>> Login(string email, string password)
        {
            return await FetchApi.PostAsync<User, UserErrorMessage>("user/login", new { email, password });
        }
    }
}
