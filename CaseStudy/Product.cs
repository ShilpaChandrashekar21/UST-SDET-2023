using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Product
    {
       
       public static List<Product> Products = new List<Product>();

        /*public Product(int productID, string? name, double price, int stockQuantity)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }*/

        public int ProductID { get; set; }
        public string? Name { get; set; }
        public double Price  { get; set; }
        public int StockQuantity { get; set; }

        
    }
}
