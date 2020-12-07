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

namespace ElectronicSales.Views.CatalogView
{
    public partial class AddCatalogForm : Form
    {
        CatalogListPage _catalogListPage;
        ErrorProvider errorProvider;

        public AddCatalogForm(CatalogListPage catalogListPage)
        {
            _catalogListPage = catalogListPage;

            InitializeComponent();

            CenterToScreen();

            errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = this;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string catalogName = tbCatalogName.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(catalogName))
            {
                errorProvider.SetError(tbCatalogName, "Bat buoc");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCatalogName, null);
            }

            if (!isValid)
            {
                return;
            }

            var res = await CatalogController.CreateCatalog(new Catalog
            {
                CatalogName = catalogName,
            });

            if (!res.IsSuccess)
            {
                Notification.Error(HandleError<CatalogErrorMessage>.GetErrorString(res.Messages));
                return;
            }

            Notification.Success("Success");

            _catalogListPage.renderCatalogs();

            this.Hide();
        }
    }
}
