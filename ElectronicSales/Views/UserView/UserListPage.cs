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
using ElectronicSales.DTOs.ErrorMessages;
using ElectronicSales.DTOs.Common;
using ElectronicSales.Views;
using ElectronicSales.Helpers;
using ElectronicSales.Constants;
using ElectronicSales.Views.UserView;

namespace ElectronicSales.UserView
{
    public partial class UserListPage : UserControl
    {
        private User currentEditingUser;
        private List<User> users;
        private List<User> filteredUsers;
        private string _role = Role.Customer;

        internal User CurrentEditingUser
        {
            get
            {
                return currentEditingUser;
            }

            set
            {
                currentEditingUser = value;
            }
        }

        public UserListPage()
        {
            InitializeComponent();
            addUserButton.Text = "Add New " + _role;

            renderUsers();
        }

        public UserListPage(string role)
        {
            InitializeComponent();
            _role = role;
            addUserButton.Text = "Add New " + _role;

            renderUsers();
        }

        public async Task getUsers()
        {
            var res = await UserController.GetAllUsers(_role);

            users = res;
            filteredUsers = res;
        }

        public async void renderUsers()
        {
            await getUsers();

            filter();

            userGridView.DataSource = filteredUsers;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm form = new CreateUserForm(_role, () => renderUsers());
            form.Show();
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex != -1)
            {
                currentEditingUser = filteredUsers.ElementAt(e.RowIndex);

                EditUserForm editForm = new EditUserForm(
                    filteredUsers.ElementAt(e.RowIndex),
                    _role,
                    () => renderUsers());
                editForm.Show();
            }

            if (userGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Are you sure",
                    "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteUser(filteredUsers.ElementAt(e.RowIndex).Id);
                }
            }
        }

        public async void DeleteUser(int id)
        {
            var res = await UserController.DeleteUser(id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<UserErrorMessage>.GetErrorString(res.Messages));
            }
            else
            {
                Notification.Success("Success");
                renderUsers();
            }
        }

        private void filter()
        {
            string name = inputSearchName.Text;
            List<User> result = new List<User>();

            if (string.IsNullOrWhiteSpace(name))
            {
                filteredUsers = users;
                return;
            }

            name = name.Trim().ToLower();

            foreach (User item in users)
            {
                if (item.FullName.ToLower().Contains(name))
                {
                    result.Add(item);
                }
            }

            filteredUsers = result;
        }

        private void inputSearchName_TextChanged(object sender, EventArgs e)
        {
            renderUsers();
        }
    }
}
