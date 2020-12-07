using ElectronicSales.Constants;
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
    public partial class MainLayout : Form
    {
        public static string currentPage = Pages.catalogListPage;

        public static List<string> products = new List<string>();

        public MainLayout()
        {
            InitializeComponent();

            this.CenterToScreen();

            // init first page to show
            HandleChangePage(Pages.catalogListPage);

            userEmailLabel.Text = Store.user.Email;
        }

        private void HandleChangePage(string page)
        {
            currentPage = page;

            // Disable all pages
            catalogListPage.Visible = false;
            productListPage.Visible = false;
            comboListPage.Visible = false;
            // Reset color for all buttons
            catalogButton.BackColor = LayoutUnits.defaultSidebarColor;
            productButton.BackColor = LayoutUnits.defaultSidebarColor;
            comboButton.BackColor = LayoutUnits.defaultSidebarColor;

            switch (page)
            {
                case Pages.catalogListPage:
                    catalogButton.BackColor = LayoutUnits.primaryColor;
                    catalogListPage.Visible = true;
                    break;
                case Pages.productListPage:
                    productButton.BackColor = LayoutUnits.primaryColor;
                    productListPage.Visible = true;
                    break;
                case Pages.comboListPage:
                    comboButton.BackColor = LayoutUnits.primaryColor;
                    comboListPage.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void sideBarProductButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.productListPage);
        }

        private void sideBarCatalogButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.catalogListPage);
        }

        private void sideBarComboButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.comboListPage);
        }
    }
}
