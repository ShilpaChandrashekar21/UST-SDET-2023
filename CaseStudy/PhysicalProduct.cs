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


        public int Weight { get; set; }
        public string? Dimension { get; set; }

        public List<Product> AddToCartList= new List<Product>();
        public List<Order> OrderList= new List<Order>();
       public static List<PhysicalProduct> PhysicalProductList = new List<PhysicalProduct>();

        public void PhysicalCart(string? pName,List<Product> p)
        {
            if(Name.Equals(pName))
            {
                
                AddToCartList.AddRange(p);
                Console.WriteLine("Product Added to cart");
            }
            else
            {
                throw new ProductNotFoundException
                    (CustomExceptions.messageList["NA"]);
            }
        }

        public void PlaceOrders(int quantity,List<Product>prod)
        {
            
            
            if (AddToCartList.Count != 0 && StockQuantity >= quantity)
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
