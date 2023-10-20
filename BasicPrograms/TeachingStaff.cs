using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class TeachingStaff : StaffDetails
    {
        public string? Specialization { get; set; }
        public int Sem {  get; set; }

        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine("Specialization: " + Specialization +
                "Semester : " + Sem);
        }
    }
}
