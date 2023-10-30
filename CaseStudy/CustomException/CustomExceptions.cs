using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class CustomExceptions
    {
         public static Dictionary<string, string> messageList = new Dictionary<string, string>()

        {
            {"NA", "Out of Stock"},
            {"CE","Add Products to cart to place order" },
             {"DO","Could not deliver the order, because of" +
                 " details mismatch" },
             {"PS","Could not Process payment" }


        };

        

    }

    internal class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string? message) : base(message)
        {
        }
    }

    internal class PlaceOrderException : Exception
    {
        public PlaceOrderException(string? message) : base(message)
        {
        }
    }

    internal class DeliverOrderException : Exception
    {
        public DeliverOrderException(string? message) : base(message)
        {
        }
    }

    internal class ProcessPaymentException : Exception
    {
        public ProcessPaymentException(string? message) : base(message)
        {
        }
    }

}
