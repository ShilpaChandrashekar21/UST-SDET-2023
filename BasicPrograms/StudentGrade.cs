using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentGrade : StudentMarks
    {
        public string? Grade { get; set; }
        public string CalculateGrade() 
        {
            string? grade;
            if (Average >= 90)
                grade = "A";
            else if (Average >=60)
                grade = "B";
            else
                grade = "C";
            
            return grade;
        }
    }
}
