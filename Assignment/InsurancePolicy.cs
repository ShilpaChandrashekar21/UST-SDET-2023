using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal abstract class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId,
            double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get; set; }
        public int PolicyId { get; set; }
        public double PremiumAmount { get; set; }

        public abstract void CalculatePremium();

        public void RenewPolicy(double newPremium)
        {
            Console.WriteLine("Do you want to renew your Policy");
            string? answer=Console.ReadLine();
            if(answer != null&& answer=="yes") 
            { 
                PremiumAmount+=newPremium;
                Console.WriteLine("policy renewed");
            }
            else
            {
                Console.WriteLine("Policy remains the same");
            }
        }

        public void RenewPolicy()
        {
            double newPremium = 0.1 * PremiumAmount;
            PremiumAmount += newPremium;
            Console.WriteLine("Policy renewed ");

        }

        public void DisplayPolicyDetails()
        {
            Console.WriteLine("Policy Name: " + PolicyName + " Policy ID: " +
                PolicyId + " Premium amount : " + PremiumAmount);
        }

    }
}
