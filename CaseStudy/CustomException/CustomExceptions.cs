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
            {"NA", "Product not available"},
            {"CE","Out of stock / check if your cart is empty"},
             {"DO","Could not deliver the order, because of" +
                 " details mismatch"},
             {"PS","Could not Process payment"},
             {"CNF","Course not found" },
             {"SNF","Student not found" },
             {"CF","No seats available for this course" }


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

    internal class EnrollmentException : Exception
    {
        public EnrollmentException(string? message) : base(message)
        {

        }

    }

}
