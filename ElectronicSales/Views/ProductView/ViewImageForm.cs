using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSales.Views.ProductView
{
    public partial class ViewImageForm : Form
    {
        public ViewImageForm(Image image)
        {
            InitializeComponent();
            CenterToScreen();

            if (image != null)
            {
                panel1.BackgroundImage = image;
            }
        }
    }
}
