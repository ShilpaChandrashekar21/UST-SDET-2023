using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Electricity
    {
        public int consumer_number, previous_reading, current_reading;
        public string? consumer_name;

        public Electricity(int consumer_number, int previous_reading, int current_reading, string? consumer_name)
        {
            this.consumer_number = consumer_number;
            this.previous_reading = previous_reading;
            this.current_reading = current_reading;
            this.consumer_name = consumer_name;


        }

        public double CalculationOfBill()
        {
            int reading = current_reading - previous_reading;
            double billAmount;
            if (reading <= 100)
            {
                billAmount = reading * 2;
            }
            else if (reading >= 101 && reading <= 200)
            {
                billAmount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if (reading >= 201 && reading <= 400)
            {
                billAmount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3);
            }
            else
            {
                billAmount = (100 * 2) + (100 * 2.5) + (100 * 3) + ((reading - 400) * 3.5);
            }
            return billAmount;
        }
    
}
}
