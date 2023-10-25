using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class LifeInsurance: InsurancePolicy
    {
        public int Age {  get; set; }
        public float PercentageOfPremium { get; set; }

        public LifeInsurance(string? policyName, int policyId,
            double premiumAmount,int age,float pop) :
            base(policyName, policyId, premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
            Age = age;
            PercentageOfPremium = pop;

        }

        
        public override void CalculatePremium()
        {
           Console.WriteLine("Do you need Health insurance");
            string? response =Console.ReadLine();
            if (response == "yes")
            {
                if(Age >=0 && Age <= 18)
                {
                    PremiumAmount += PercentageOfPremium*PremiumAmount;
                }
                else if (Age >= 19 && Age <= 40)
                {
                    PremiumAmount += ((PercentageOfPremium+2.6)*PremiumAmount);
                }
                else
                {
                    PremiumAmount += ((PercentageOfPremium + 3)*PremiumAmount);
                }
            }
        }
        public void DisplayLifeInsurancePolicyDetails()
        {
            Console.WriteLine("Policy Name: " + PolicyName + " Policy ID: " +
                PolicyId + " Premium amount : " + PremiumAmount+" Age: "+
                Age+" Percentage of Premium : "+PercentageOfPremium);
        }
    }

}
