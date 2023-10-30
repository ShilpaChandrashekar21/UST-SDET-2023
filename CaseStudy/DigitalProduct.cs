using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct : Product, IOrderable
    {
        /*public DigitalProduct(int productID, string? name,
            double price, int stockQuantity, string? downloadLink, string? fileFormat) : 
            base(productID, name, price, stockQuantity)
        {
            DownloadLink = downloadLink;
            FileFormat = fileFormat;
            ProductID = productID;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }*/

        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set;}
        public List<Product> AddToCartList1
        { get; set; } = new List<Product>();
        List<Order> OrderList = new List<Order>();

        public void DigitalCart(string? pName, Product dP)
        {
            if (Name.Equals(pName))
            {
                AddToCartList1.Add(dP);
                Console.WriteLine("Product Added to cart");
            }
            else
            {
                throw new ProductNotFoundException
                    (CustomExceptions.messageList["NA"]);
            }
        }

        public void PlaceOrders(int quantity, Product dProd)
        {
            if (AddToCartList1.Count != 0 && dProd.StockQuantity>=quantity)
            {
                Console.WriteLine("Order Placed");
            }
            else
            {
                throw new PlaceOrderException(CustomExceptions.messageList["CE"]);
            }

        }

        public void ProcessPayment(int orderId, Order order)
        {
            if (order.OrderId == orderId)
            {
                Console.WriteLine("Payment successful");
                OrderList.Add(order);
            }
            else
            {
                throw new ProcessPaymentException(CustomExceptions.messageList["PS"]);
            }
        }

        public void DeliverOrders(string? pNum, Order order)
        {
            if (order.PhoneNumber1.Equals(pNum))
            {
                Console.WriteLine("U can download the order");
            }
            else
            {
                throw new DeliverOrderException(CustomExceptions.messageList["DO"]);
            }
        }
    }
}
