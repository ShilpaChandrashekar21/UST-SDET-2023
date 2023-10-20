using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class StudentArray
    {
        private string? name;
        private int[] marks = new int[3];
        private string? grades;

        public StudentArray(string? name, int[] marks, string? grades)
        {
            Name = name;
            Marks = marks;
            Grades = grades;
        }

        public string? Name { get => name; set => name = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public string? Grades { get => grades; set => grades = value; }

        public int CalculateAverage()
        {
            int average = 0;
            foreach (int i in Marks)
            {
                average += i;
            }
            
            return average / Marks.Length;

        }

        public void GetMarksSummary()
        {
            int highestMarks = marks[0];
            int lowestMarks = marks[0];
            foreach (int i in marks)
            {
                if (i > highestMarks)
                {
                    highestMarks = i;
                }
                if (i < lowestMarks)
                {
                    lowestMarks = i;
                }

            }
            Console.WriteLine("Highest Marks : " + highestMarks + " Lowest Marks : "
                + lowestMarks);
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student name: " + Name 
                + " Grades: " + Grades);
            foreach (int i in Marks)
            {
                Console.WriteLine("Marks : " + i);
            }
            
        }
    }
}
