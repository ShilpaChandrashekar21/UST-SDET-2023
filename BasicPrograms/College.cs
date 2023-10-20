using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class College
    {
        public int CollegeId { get; set; }
        public string? CollegeName { get; set; }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name :" + CollegeName +
                "College Id : " + CollegeId);
        }
    }
}
