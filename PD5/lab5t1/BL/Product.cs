using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5t1.DL;

namespace lab5t1.BL
{
    public class Product
    {
        public string Productname;
        public string ProductCategory;
        public int Prices;
        public int threshold;

        public Product(string productname, string productCategory, int prices, int threshold)
        {
            this.Productname = productname;
            this.ProductCategory = productCategory;
            this.Prices = prices;
            this.threshold = threshold;
        }
        public void generateBill()
        {

        }
    }
}
