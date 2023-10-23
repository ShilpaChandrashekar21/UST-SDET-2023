using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : Shape, IDrawable
    {
        
        public int Radius { get; set; }
        public readonly double pi = 3.14;

        public override double CalculateArea()
        {
            return pi * Radius;
        }

       

        public override double CalculatePerimeter()
        {
            return 2*pi * Radius;
        }
        public void Draw()
        {
            Console.WriteLine("This is Circle");
        }
    }
}
