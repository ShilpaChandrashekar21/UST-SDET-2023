using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StaffDetails : College
    {
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Dept { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Staff id : " + StaffId + " Staff Name : " + StaffName
                + " Department : " + Dept);
        }

    }
}
