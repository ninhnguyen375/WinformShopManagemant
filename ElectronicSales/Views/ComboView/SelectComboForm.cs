using ElectronicSales.Controllers;
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

namespace ElectronicSales.Views.ComboView
{
    public partial class SelectComboForm : Form
    {
        private List<Combo> combos;
        private List<Combo> filteredCombos;
        private Action<object> _callback;
        private List<object> _excludes;

        public SelectComboForm(Action<object> callback, List<object> excludes)
        {
            _callback = callback;
            _excludes = excludes;

            InitializeComponent();
            CenterToScreen();
            comboList.Columns[4].DefaultCellStyle.Format = "N";

            renderCombos(true);
        }

        private async void renderCombos(bool hard)
        {
            if (hard)
            {
                await getCombos();

                comboList.DataSource = combos;
            }
            else
            {
                comboList.DataSource = filteredCombos == null ? combos : filteredCombos;
            }
        }

        private async Task getCombos()
        {
            var res = await ComboController.GetAllCombos();

            if (res == null || res.Data == null)
            {
                return;
            }

            List<int> exludeIDs = new List<int>();

            foreach (object item in _excludes)
            {
                exludeIDs.Add(((Combo)item).Id);
            }

            var result = res.Data.Where(item => !exludeIDs.Contains(item.Id)).ToList();

            combos = result.ToList<Combo>();
        }

        private void comboList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboList.Columns[e.ColumnIndex].Name == "choose" && e.RowIndex != -1)
            {
                _callback(combos.ElementAt(e.RowIndex));
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            filteredCombos = combos.ToList();

            if (string.IsNullOrWhiteSpace(value))
            {
                filteredCombos = null;
            }
            else
            {
                filteredCombos = filteredCombos
                    .Where(item =>
                        item.ComboName.ToLower().Contains(value.Trim().ToLower()))
                    .ToList();
            }

            renderCombos(false);
        }
    }
}
