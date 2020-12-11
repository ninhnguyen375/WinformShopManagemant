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
    public partial class AcceptOrderForm : Form
    {
        private Action<int, bool, DateTime> _callback;
        private int _orderID;

        public AcceptOrderForm(Action<int, bool, DateTime> callback, int orderID)
        {
            _callback = callback;
            _orderID = orderID;

            CenterToScreen();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _callback(_orderID, true, dateTimePicker1.Value);
            Close();
        }
    }
}
