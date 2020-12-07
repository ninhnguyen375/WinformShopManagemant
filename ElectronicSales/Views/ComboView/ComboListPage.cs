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
using ElectronicSales.Views.ComboView;
using ElectronicSales.Helpers;

namespace ElectronicSales.Views.ComboView
{
    public partial class ComboListPage : UserControl
    {
        private Combo currentEditingCombo;
        private List<Combo> combos;
        private List<Combo> filteredCombos;

        internal Combo CurrentEditingCombo
        {
            get
            {
                return currentEditingCombo;
            }

            set
            {
                currentEditingCombo = value;
            }
        }

        public ComboListPage()
        {
            InitializeComponent();
            comboGridView.Columns[2].DefaultCellStyle.Format = "N";
            comboGridView.Columns[4].DefaultCellStyle.Format = "N";

            renderCombos();
        }

        public async Task getCombos()
        {
            var res = await ComboController.GetAllCombos();

            if (res == null || res.Data == null)
            {
                return;
            }

            combos = res.Data;
            filteredCombos = res.Data;
        }

        public async void renderCombos()
        {
            await getCombos();

            filter();

            comboGridView.DataSource = filteredCombos;
        }

        private void addComboButton_Click(object sender, EventArgs e)
        {
            AddComboForm addComboForm = new AddComboForm(this);
            addComboForm.Show();
        }

        private void comboGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboGridView.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex != -1)
            {
                currentEditingCombo = filteredCombos.ElementAt(e.RowIndex);

                EditComboForm editForm = new EditComboForm(this);
                editForm.Show();
            }

            if (comboGridView.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex != -1)
            {
                if (Notification.Confirm("Are you sure?"))
                {
                    DeleteCombo(filteredCombos.ElementAt(e.RowIndex).Id);
                }
            }
        }

        public async void DeleteCombo(int id)
        {
            var res = await ComboController.DeleteCombo(id);

            if (res == null || !res.IsSuccess)
            {
                Notification.Error(HandleError<ComboErrorMessage>.GetErrorString(res.Messages));
            }
            else
            {
                Notification.Success("Success");
                renderCombos();
            }
        }

        private void filter()
        {
            string name = inputSearchName.Text;
            List<Combo> result = new List<Combo>();

            if (string.IsNullOrWhiteSpace(name))
            {
                filteredCombos = combos;
                return;
            }

            name = name.Trim().ToLower();

            foreach (Combo item in combos)
            {
                if (item.ComboName.ToLower().Contains(name))
                {
                    result.Add(item);
                }
            }

            filteredCombos = result;
        }

        private void inputSearchName_TextChanged(object sender, EventArgs e)
        {
            renderCombos();
        }
    }
}
