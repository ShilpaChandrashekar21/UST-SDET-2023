using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : Shape , IDrawable
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override double CalculateArea()
        {
            return Length * Breadth;
        }

        public override double CalculatePerimeter()
        {
            return 2*(Length+Breadth);
        }

        public void Draw()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
}
