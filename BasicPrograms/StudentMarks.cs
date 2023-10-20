using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentMarks : StudentDetails
    {
        /*
        public StudentMarks( int rollNo, string? studentName, string? city,
            int marks1, int marks2, int marks3, int total, double average):
            base(rollNo,studentName,city)
        {
            Marks1 = marks1;
            Marks2 = marks2;
            Marks3 = marks3;
            Total = total;
            Average = average;
            RollNo = rollNo;
            StudentName = studentName;
            City = city;
        }
        */

        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
        public int Total { get; set; }

        public double Average { get; set; }
         
        public int CalculateTotal()
        {
            Total=Marks1 + Marks2 + Marks3;
            return Total;
        }

        public double CalculateAverage()
        {
            Average =Total/3;
            return Average;
        }

    }
}
