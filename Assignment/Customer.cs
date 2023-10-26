using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Balance { get; set; }

        

        public Customer(int customerId, string name, string phoneNumber, int balance)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        List<Customer> customerArray = new List<Customer>();
       
    }
}
