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
    public partial class EditUserForm : Form
    {
        private ErrorProvider _error = new ErrorProvider();
        private bool isError = false;
        private Action _callback;
        private string _role;
        private User _user;

        public EditUserForm(object user, string role, Action callback)
        {
            InitializeComponent();
            CenterToScreen();
            this.Text = "Edit " + role;

            _error.ContainerControl = this;
            _user = (User)user;
            _role = role;
            _callback = callback;

            tbName.Text = _user.FullName;
            tbEmail.Text = _user.Email;
            tbAddress.Text = _user.Address;
            tbPhone.Text = _user.PhoneNumber;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _error.SetError(tbName, string.IsNullOrWhiteSpace(tbName.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbEmail, string.IsNullOrWhiteSpace(tbEmail.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbPhone, string.IsNullOrWhiteSpace(tbPhone.Text) ? activeError("Bắt buộc") : null);
            _error.SetError(tbAddress, string.IsNullOrWhiteSpace(tbAddress.Text) ? activeError("Bắt buộc") : null);

            if (isError)
            {
                isError = false;
                return;
            }

            var res = await UserController.UpdateUser(_user.Id, new User
            {
                FullName = tbName.Text,
                Address = tbAddress.Text,
                Email = tbEmail.Text,
                RoleName = _role,
                PhoneNumber = tbPhone.Text,
            });

            if (res == null) return;
            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<UserErrorMessage>.GetErrorString(res.Messages));
            }
            else
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
