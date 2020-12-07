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
using ElectronicSales.Views.CatalogView;
using ElectronicSales.Helpers;

namespace ElectronicSales
{
    public partial class CatalogListPage : UserControl
    {
        private Catalog currentEditingCatalog;
        private List<Catalog> catalogs;
        private List<Catalog> filteredCatalogs;

        internal Catalog CurrentEditingCatalog
        {
            get
            {
                return currentEditingCatalog;
            }

            set
            {
                currentEditingCatalog = value;
            }
        }

        public CatalogListPage()
        {
            InitializeComponent();

            renderCatalogs();
        }

        public async Task getCatalogs()
        {
            var res = await CatalogController.GetAllCatalogs();

            if (res == null || res.Data == null)
            {
                return;
            }

            catalogs = res.Data;
            filteredCatalogs = res.Data;
        }

        public async void renderCatalogs()
        {
            await getCatalogs();

            filter();

            catalogGridView.DataSource = filteredCatalogs;
        }

        private void addCatalogButton_Click(object sender, EventArgs e)
        {
            AddCatalogForm addCatalogForm = new AddCatalogForm(this);
            addCatalogForm.Show();
        }

        private void catalogGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (catalogGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex != -1)
            {
                currentEditingCatalog = filteredCatalogs.ElementAt(e.RowIndex);

                EditCatalogForm editForm = new EditCatalogForm(this);
                editForm.Show();
            }

            if (catalogGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Are you sure",
                    "Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteCatalog(filteredCatalogs.ElementAt(e.RowIndex).Id);
                }
            }
        }

        public async void DeleteCatalog(int id)
        {
            var res = await CatalogController.DeleteCatalog(id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<CatalogErrorMessage>.GetErrorString(res.Messages));
            }
            else
            {
                Notification.Success("Success");
                renderCatalogs();
            }
        }

        private void filter()
        {
            string name = inputSearchName.Text;
            List<Catalog> result = new List<Catalog>();

            if (string.IsNullOrWhiteSpace(name))
            {
                filteredCatalogs = catalogs;
                return;
            }

            name = name.Trim().ToLower();

            foreach (Catalog item in catalogs)
            {
                if (item.CatalogName.ToLower().Contains(name))
                {
                    result.Add(item);
                }
            }

            filteredCatalogs = result;
        }

        private void inputSearchName_TextChanged(object sender, EventArgs e)
        {
            renderCatalogs();
        }
    }
}
