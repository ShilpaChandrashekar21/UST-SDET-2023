using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class DelegateExample
    {
        /*public static void Display() 
        {
            Console.WriteLine("Hello !!!!");
        }*/

        /*public static void Display(string text) 
        {
            Console.WriteLine(text);
        }*/

        public  void Display(string text)
        {
            Console.WriteLine(text);
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public void Add(int n1,int n2)
        {
            Num1 = n1;
            Num2 = n2;
            Console.WriteLine(Num1 + Num2);
        }

        public int AddR(int n1, int n2)
        {
            Num1 = n1;
            Num2 = n2;
            return(Num1 + Num2);
        }

        public void Sub(int n1, int n2)
        {
            Num1 = n1;
            Num2 = n2;
            Console.WriteLine(Num1 - Num2);
        }
    }
}
