using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Employee : Person, IDisplayable
    {
        public int EmployeeId { get; set; }

        public Employee(string? firstName, string? lastName, int age,
            int employeeId)
            : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
    
        
        public  void DisplayInfo()
        {
            string name = FirstName + LastName;
            Console.WriteLine("Person Name: " + name + 
                " age: " + Age + " Employee Id: " + EmployeeId);
        }
    }
}
