using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonTeachingStaff : StaffDetails
    {
        public string? Responsibity { get; set; }
        public int Experience { get; set; }

        public void DisplayNonTeachingStaffDetails()
        {
            Console.WriteLine("Responsibity: " + Responsibity +
                "Experience : " + Experience);
        }
    }
}
