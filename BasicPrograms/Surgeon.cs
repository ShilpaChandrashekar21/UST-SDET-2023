using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Surgeon : Doctor
    {
        public string? SurgeonName { get; set; }

        public void DisplaySurgeonDetails(string? sname)
        {
            Console.WriteLine("Surgeon Name : " + sname);
        }

    }
}
