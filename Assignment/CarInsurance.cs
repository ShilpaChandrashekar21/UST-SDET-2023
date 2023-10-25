using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CarInsurance : InsurancePolicy
       
    {
            public int TypeOfCar { get; set; }
            public CarInsurance(string? policyName, int policyId,
                double premiumAmount, int typeOfCar) :
                base(policyName, policyId, premiumAmount)
            {
                PolicyName = policyName;
                PolicyId = policyId;
                PremiumAmount = premiumAmount;
                TypeOfCar = typeOfCar;

            }

            

            public override void CalculatePremium()
            {
                Console.WriteLine("Do you need Car insurance");
                string? response = Console.ReadLine();
                if (response == "yes")
                {
                    if (TypeOfCar<=4)
                    {
                        PremiumAmount +=(0.2*PremiumAmount);
                    }
                    else if (TypeOfCar >=5 && TypeOfCar<=7)
                    {
                        PremiumAmount += (0.3 * PremiumAmount);
                }
                    else
                    {
                        PremiumAmount += (0.5 * PremiumAmount);
                    }
                }
            }
            public void DisplayCarInsurancePolicyDetails()
            {
            Console.WriteLine("Policy Name: " + PolicyName + " Policy ID: " +
                PolicyId + " Premium amount : " + PremiumAmount
                + " Type Of Car: " + TypeOfCar);
                   
        }

    }

   
}
