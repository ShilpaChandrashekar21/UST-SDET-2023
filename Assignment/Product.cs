using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Product
    {
        private string? productName;
        private double price;
        private int quantity;



        public Product(string? productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public void SetPrice(double newPrice)
        {

            price = newPrice;

        }

        public double ProductValue()
        {

            return price * quantity;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Product Name :" + productName + " Price : "
                + price + " Quantity :" + quantity);
        }
    }
}
