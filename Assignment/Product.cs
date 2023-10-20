using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Product
    {
        public Product(string? productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        /*
private string? productName;
private double price;
private int quantity;



public Product(string? productName, double price, int quantity)
{
   this.productName = productName;
   this.price = price;
   this.quantity = quantity;
}
*/

        public string? ProductName { get; set; }
        public double  Price { get; set; }
        public int Quantity { get; set; }
       
        public void SetPrice(double newPrice)
        {

            Price = newPrice;

        }

        public double ProductValue()
        {

            return Price * Quantity;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product Name :" + ProductName + " Price : "
                + Price + " Quantity :" + Quantity);
        }
    }
}
