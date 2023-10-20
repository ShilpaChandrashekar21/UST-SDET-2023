using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Student
    {
        private string? name;
        private char grades;

        public Student(string? name)
        {
            this.name = name;

        }

        public char CalculateAverage()
        {
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks <= 40)
            {
                grades = 'C';
            }
            else if (marks <= 70 && marks >= 41)
            {
                grades = 'B';
            }
            else
            {
                grades = 'A';
            }

            return grades;

        }
    }
}
