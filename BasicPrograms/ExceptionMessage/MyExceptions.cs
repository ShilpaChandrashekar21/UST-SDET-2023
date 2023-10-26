using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms.ExceptionMessage
{
    internal class MyExceptions
    {
        /* public static List<string> exMessageList = new List<string>()
          {
              "Don't give 0 for denominator",
              "Index out of bound",
              "Unknown Exception"

          };*/

         public static Dictionary<int, string> exMessageList =
            new Dictionary<int, string>()
            {
                { 1, "Don't give 0 for denominator"},
                { 2, "Index out of bound"},
                {3, "Unknown Exception" },
                {4, "Age is less" },
                {5, "Age is more" }
            };

        /*public MyExceptions()
        {
            exMessageList.Add(1, "Don't give 0 for denominator");
            exMessageList.Add(2, "Index out of bound");
            exMessageList.Add(3, "Unknown Exception");
            exMessageList.Add(4, "Age is less");
            exMessageList.Add(5, "Age is more");
        }*/
    }

    internal class Num1Exception : Exception
    {
        public Num1Exception(string? message) : base(message)
        {
        }
    }

    internal class Num2Exception : Exception
    {
        public Num2Exception(string? message) : base(message)
        {
        }
    }
}
