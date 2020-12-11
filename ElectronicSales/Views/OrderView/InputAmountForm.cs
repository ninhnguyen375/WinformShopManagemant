using ElectronicSales.Helpers;
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
    public partial class InputAmountForm : Form
    {
        private Action<int> _callback;

        public InputAmountForm(Action<int> callback)
        {
            _callback = callback;

            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(amount.Value <= 0)
            {
                Notification.Error("Amount >= 0");
                return;
            }

            _callback((int)amount.Value);
            Close();
        }
    }
}
