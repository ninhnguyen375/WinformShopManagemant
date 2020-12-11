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
    public partial class CreateUserForm : Form
    {
        private ErrorProvider _error = new ErrorProvider();
        private bool isError = false;
        private Action _callback;
        private string _role;

        public CreateUserForm(string role, Action callback)
        {
            _callback = callback;
            _role = role;

            InitializeComponent();
            CenterToScreen();
            this.Text = "Add New " + role;

            _error.ContainerControl = this;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _error.SetError(tbName, string.IsNullOrWhiteSpace(tbName.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbEmail, string.IsNullOrWhiteSpace(tbEmail.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbPhone, string.IsNullOrWhiteSpace(tbPhone.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbAddress, string.IsNullOrWhiteSpace(tbAddress.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbPassword, string.IsNullOrWhiteSpace(tbPassword.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbConfirmPassword, tbConfirmPassword.Equals(tbPassword.Text) ? activeError("Không khớp") : null);

            if (isError)
            {
                isError = false;
                return;
            }

            var res = await UserController.CreateUser(new User
            {
                FullName = tbName.Text,
                Address = tbAddress.Text,
                Email = tbEmail.Text,
                RoleName = _role,
                PhoneNumber = tbPhone.Text,
                Password = tbPassword.Text
            });

            if (res == null) return;
            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<UserErrorMessage>.GetErrorString(res.Messages));
            } else
            {
                Notification.Success("Success");
                _callback();
                Close();
            }
        }

        private string activeError(string t)
        {
            isError = true;

            return t;
        }
    }
}
