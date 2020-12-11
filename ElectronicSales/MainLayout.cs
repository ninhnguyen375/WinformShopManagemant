using ElectronicSales.Constants;
using ElectronicSales.UserView;
using ElectronicSales.Views.UserView;
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
        private UserListPage employeeListPage;

        public MainLayout()
        {
            InitializeComponent();

            // apply employeeListPage
            employeeListPage = new UserListPage(Role.Employee);
            contentPanel.Controls.Add(employeeListPage);
            employeeListPage.Dock = DockStyle.Fill;
            employeeListPage.Location = new Point(0, 0);
            employeeListPage.Name = "employeeListPage";
            employeeListPage.Size = new Size(799, 441);
            employeeListPage.TabIndex = 4;

            makeOrderButton.BackColor = LayoutUnits.primaryColor;
            makeOrderButton.ForeColor = Color.White;

            this.CenterToScreen();

            // init first page to show
            HandleChangePage(Pages.catalogListPage);

            userEmailLabel.Text = Store.user.Email;
            roleName.Text = Store.user.RoleName;

            if(Store.user.RoleName.Equals(Role.Employee))
            {
                employeeButton.Visible = false;
            }
        }

        private void HandleChangePage(string page)
        {
            currentPage = page;

            // Disable all pages
            catalogListPage.Visible = false;
            productListPage.Visible = false;
            comboListPage.Visible = false;
            orderListPage.Visible = false;
            customerListPage.Visible = false;
            employeeListPage.Visible = false;
            // Reset color for all buttons
            catalogButton.BackColor = LayoutUnits.defaultSidebarColor;
            productButton.BackColor = LayoutUnits.defaultSidebarColor;
            comboButton.BackColor = LayoutUnits.defaultSidebarColor;
            orderButton.BackColor = LayoutUnits.defaultSidebarColor;
            customerButton.BackColor = LayoutUnits.defaultSidebarColor;
            employeeButton.BackColor = LayoutUnits.defaultSidebarColor;

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
                case Pages.orderListPage:
                    orderButton.BackColor = LayoutUnits.primaryColor;
                    orderListPage.Visible = true;
                    break;
                case Pages.customerListPage:
                    customerButton.BackColor = LayoutUnits.primaryColor;
                    customerListPage.Visible = true;
                    break;
                case Pages.employeeListPage:
                    employeeButton.BackColor = LayoutUnits.primaryColor;
                    employeeListPage.Visible = true;
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

        private void sideBarOrderButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.orderListPage);
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            createOrderForm.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.customerListPage);
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            HandleChangePage(Pages.employeeListPage);
        }
    }
}
