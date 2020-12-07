using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Models
{
    class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ImagePath = "https://cdn.tgdd.vn/Products/Images/42/190325/iphone-xr-hopmoi-den-400x400-400x400.png";

        public Image ProductImage
        {
            get
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(ImagePath);
                Bitmap bitmap; bitmap = new Bitmap(stream);

                stream.Flush();
                stream.Close();
                client.Dispose();

                return bitmap;
            }
        }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public string IdString { get; set; }

        // Reference with Catalog
        public virtual Catalog Catalog { get; set; }

        public int CatalogId { get; set; }

        // Reference with ProductCombo list
        //public virtual ICollection<ProductCombo> ProductCombos { get; set; }

        // Refernce with OrderDetail list
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
