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

namespace ElectronicSales
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            CenterToScreen();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                Notification.Warning("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            var res = await UserController.Login(tbEmail.Text, tbPassword.Text);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(res == null
                    ? "Tài khoản hoặc mật khẩu không chính xác"
                    : HandleError<UserErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            User u = (User)res.Data;

            Store.user = u;

            this.Hide();

            activeLayout(Store.user.RoleName);

        }

        public void activeLayout(string role)
        {
            MainLayout main = new MainLayout();
            main.FormClosing += new FormClosingEventHandler((object _, FormClosingEventArgs __) => Show());
            main.Show();
        }
    }
}
