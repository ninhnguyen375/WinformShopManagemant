using ElectronicSales.Constants;
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
    public partial class SelectCustomerForm : Form
    {
        private List<User> customers = new List<User>();
        private List<User> filteredCustomers = new List<User>();
        private Action<object> _callback;

        public SelectCustomerForm(Action<object> callback)
        {
            _callback = callback;

            InitializeComponent();
            CenterToScreen();

            renderCustomers();
        }

        private async Task getCustomers()
        {
            var res = await UserController.GetAllUsers(Role.Customer);

            if (res == null) return;

            customers = res;
            filteredCustomers = res;
        }

        private async void renderCustomers()
        {
            await getCustomers();

            customerList.DataSource = filteredCustomers;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CreateUserForm form = new CreateUserForm(Role.Customer, renderCustomers);
            form.Show();
        }

        private void inputKeywords_TextChanged(object sender, EventArgs e)
        {
            filteredCustomers = new List<User>();
            string keywords = inputKeywords.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keywords))
            {
                renderCustomers();
                return;
            }

            foreach (User item in customers)
            {
                if (item.FullName.ToLower().Contains(keywords)
                    || item.Email.ToLower().Contains(keywords)
                    || item.Address.ToLower().Contains(keywords))
                {
                    filteredCustomers.Add(item);
                }
            }

            customerList.DataSource = filteredCustomers;
        }

        private void customerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerList.Columns[e.ColumnIndex].Name == "Choose" && e.RowIndex != -1)
            {
                _callback(filteredCustomers.ElementAt(e.RowIndex));
                Close();
            }
        }
    }
}
