using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Surgen : Doctor
    {
        public string? SurgenName { get; set; }

        public void DisplaySurgenDetails(string? sname)
        {
            Console.WriteLine("Surgen Name : " + sname);
        }

    }
}
