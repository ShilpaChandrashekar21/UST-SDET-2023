using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class ArrayExample
    {
        //int[] arr = { 10, 20, 30 };
        //readonly
        int[] arr = new int[5];
        // int[,] arr1; //new int[2, 2];
        public void OneDim()
        {

            arr[0] = 1;
            arr[1] = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            // arr=new int[8];
            arr[1] = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Clear(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(arr[i]);
            }



        }
        public void TwoDim()
        {
            /*arr1[0, 0] = 100;
            arr1[0,1] = 200;
            arr1[1, 0] = 300;
            arr1[1, 1] = 400;
            */
            int[,] arr1 = { { 100, 200 }, { 300, 400 } };
            foreach (int arr in arr1)
            {
                // Console.WriteLine(arr);
            }

        }

        public void JaggedArray()
        {
            int[][,] arr2 = new int[][,]
            {
                new int[,] { { 100, 200 }, { 300,400} },
                new int[,] { { 20,30} ,{40,50} ,{60,70} },
                new int[,] { { 100,300} },
                new int[,] { { 100,400} }

            };
            /*
        foreach(var arr in arr2)
         {
             Console.WriteLine(arr);
         }
            */
            for (int i = 0; i < arr2.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr2[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr2[j].Rank; k++)
                    {
                        Console.Write(arr2[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;


                Console.WriteLine();
            }
        }
    }
}
