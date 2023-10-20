using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentMarks : StudentDetails
    {
        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
        public int Total { get; set; }

        public double Average { get; set; }


    }
}
