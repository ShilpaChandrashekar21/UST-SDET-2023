using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GenericsExample<T>
    {
        /*private T val1,val2;

        public GenericsExample(T val1, T val2)
        {
            Val1 = val1;
            Val2 = val2;
        }

        public T Val1 { get => val1; set => val1 = value; }
        public T Val2 { get => val2; set => val2 = value; }

        */

        /*private T[] arr;

        public GenericsExample(T[] arr)
        {
            Arr = arr;
        }

        public T[] Arr { get => arr; set => arr = value; }

        public void Display()
        {
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
        }*/

        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;    
            num1 = num2;
            num2 = temp;
        }
    }
}
