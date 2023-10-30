using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct : Product, IOrderable
    {
        /*public PhysicalProduct(int productID, string? name, 
            double price, int stockQuantity, int weight,string? dimension) :
            base(productID, name, price, stockQuantity)
        {
            Weight = weight;
            Dimension = dimension;
            ProductID = productID;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
         public PhysicalProduct() { }*/

        public int Weight { get; set; }
        public string? Dimension { get; set; }
        public List<Product> AddToCartList= new List<Product>();
        List<Order> OrderList= new List<Order>();
        
        public void PhysicalCart(string? pName,Product p)
        {
            if(Name.Equals(pName))
            {
                
                AddToCartList.Add(p);
                Console.WriteLine("Product Added to cart");
            }
            else
            {
                throw new ProductNotFoundException
                    (CustomExceptions.messageList["NA"]);
            }
        }

        public void PlaceOrders(int quantity,Product prod)
        {
            
            
            if (AddToCartList.Count != 0 && prod.StockQuantity>=quantity)
            {
                
                Console.WriteLine("Order Placed");
            }
            else
            {
                throw new PlaceOrderException(CustomExceptions.messageList["CE"]);
            }
        }

        public void ProcessPayment(int custId,Order order)
        {
            if(order.CustomerId1 == custId)
            {
                Console.WriteLine("Payment successful");
                OrderList.Add(order);
            }
            else
            {
                throw new ProcessPaymentException(CustomExceptions.messageList["PS"]);
            }
        }

        public void DeliverOrders(string? pNum,Order order)
        {
            if (order.PhoneNumber1.Equals(pNum))
            {
                Console.WriteLine("Order Delivered");
            }
            else
            {
                throw new DeliverOrderException(CustomExceptions.messageList["DO"]);
            }
        }

        
    }
}
