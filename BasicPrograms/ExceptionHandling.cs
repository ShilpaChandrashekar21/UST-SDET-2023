using BasicPrograms.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class ExceptionHandling 
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }


        public void Divide()
        {



            int ans = Num1 / Num2;
            Console.WriteLine(ans);

            int[] num = { 10, 20, 30 };

            for (int i = 0; i <= 3; i++)
            {
                int ans1 = num[i] / Num2;
                Console.WriteLine(ans1);
            }
        }

        public void NumCheck1()
        {
           
            if (Num1 >= 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exMessageList[4]);
            }
            
        }

        public void NumCheck2()
        {
            MyExceptions myException = new();
            if (Num2 < 100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new Num2Exception(MyExceptions.exMessageList[5]);
            }
        }
        
            /*foreach (int i in num)
                {
                    
                   int ans = i / Num2;
                    Console.WriteLine(ans);
                }*/

            /*catch (ArithmeticException ) 
            {
                Console.WriteLine("Don't divide by zero \n");
               
            }
            catch (IndexOutOfRangeException )
            {
                Console.WriteLine("Array is out of Index");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally 
            {
                Console.WriteLine("Done");
            }*/


        
    }
}
