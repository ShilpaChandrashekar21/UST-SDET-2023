using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public Student(int studId, string? name, string? dept)
        {
            StudId = studId;
            Name = name;
            Dept = dept;
        }

        public int StudId { get; set; }
        public string? Name { get; set; }
        public string? Dept { get; set; }


    }
}
