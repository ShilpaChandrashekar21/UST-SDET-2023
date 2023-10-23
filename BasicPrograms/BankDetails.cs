using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BankDetails
    {
        /*
        public BankDetails() { }
        
        public BankDetails(int customerId, long accountNumber,
            string? name)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
           
        }

        public BankDetails( long accountNumber,
            string? name)
        {
           
            AccountNumber = accountNumber;
            Name = name;

        }
        */
        public BankDetails(int customerId, long accountNumber,
            string? name, string? status)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
            Status = status;
        }

        public int CustomerId { get; set; }
        public long AccountNumber { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

        public void GetAccountDetails(int customerId)
        {
            if (CustomerId == customerId)
            {
                Console.WriteLine("Account number : " + AccountNumber +
                    " Name: " + Name + " Status: " + Status);
            }
            else
            {
                Console.WriteLine("Customer Id doesn't exist");
            }
        }

        public void GetAccountDetails(long accountNum)
        {
            if (AccountNumber == accountNum)
            {
                Console.WriteLine("Customer ID : " + CustomerId +
                    " Name: " + Name + " Status: " + Status);
            }
            else
            {
                Console.WriteLine("Account Number doesn't exist");
            }
        }

        public virtual void WelcomeMessage()
        {
            Console.WriteLine("Welcome !!");
        }



        public void GetAccountDetails(string? name)
        {
            if (Name.Equals(name)) 
            {
                Console.WriteLine("Account number : " + AccountNumber +
                    " Customer ID: " + CustomerId + " Status: " + Status);
            }
            else
            {
                Console.WriteLine("Name doesn't exist");
            }
        }


    }
}
