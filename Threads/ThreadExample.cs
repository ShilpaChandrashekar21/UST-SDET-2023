using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class ThreadExample
    {
        public int BoxCount { get; set; }

        public void AddBox(int workerId)
        {
            for(int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                BoxCount++;
                Console.WriteLine("Worker " + workerId + " added a box" + " Total count: "+GetTotalBox());
            }
        }
        public int GetTotalBox()
        {
            return BoxCount;
        }

    }
}
