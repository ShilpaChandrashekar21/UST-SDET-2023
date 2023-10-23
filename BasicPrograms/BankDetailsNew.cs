using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int customerId, 
            long accountNumber, string? name, string? status) : 
            base(customerId, accountNumber, name, status)
        {
        }

        public override void WelcomeMessage()
        {
            Console.WriteLine("WELCOME !!" + Name);
        }
    }
}
