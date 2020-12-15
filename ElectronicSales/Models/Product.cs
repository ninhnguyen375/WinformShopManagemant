using ElectronicSales.Constants;
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

        public string ImageUrl { get; set; }

        public Image ProductImage
        {
            get
            {
                try
                {
                    WebClient client = new WebClient();
                    Stream stream = client.OpenRead(Config.host + ImageUrl);
                    Bitmap bitmap; bitmap = new Bitmap(stream);

                    stream.Flush();
                    stream.Close();
                    client.Dispose();

                    return bitmap;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public string IdString { get; set; }

        public virtual Catalog Catalog { get; set; }

        public int CatalogId { get; set; }
    }
}
