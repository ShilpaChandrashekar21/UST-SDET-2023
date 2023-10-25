using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GenericCollection
    {

        public void ListHandling()
        {
            List<int> num = new List<int>();
            num.Add(3);
            num.Add(1);
            num.Add(2);
            num.Add(6);
            num.Add(5);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Removing 2");
            num.Remove(2);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Removing At 0");
            num.RemoveAt(0);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sorting");
            num.Sort();
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(num.Contains(1));
            Console.WriteLine(num.IndexOf(2));
            num.Clear();
            Console.WriteLine("clear");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }

            public void StackHandling()
            {
                Stack<string> stack = new Stack<string>();
                stack.Push("2");
                stack.Push("5");
                stack.Push("3");
                stack.Push("4");
                stack.Push("1");

                foreach (var i in stack)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("pop " + stack.Pop());
                foreach (var i in stack)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Peek " + stack.Peek());
                foreach (var i in stack)
                {
                    Console.WriteLine(i);
                }
                
                Console.WriteLine("count " + stack.Count);
            }
            public void QueueHandling()
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(4);

                foreach (var i in queue)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine("pop " + queue.Dequeue());
                foreach (var i in queue)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Peek " + queue.Peek());
                foreach (var i in queue)
                {
                    Console.WriteLine(i);
                }
           // Console.WriteLine("Sorting");
            //queue.Sort();
                Console.WriteLine("count " + queue.Count);
            }

            


            

            public void SortedListHandling()
            {
                SortedList<int,int> sl = new SortedList<int,int>();

                sl.Add(2, 12);
                sl.Add(1, 11);
                sl.Add(5, 12);
                sl.Add(3, 13);
                sl.Add(4, 14);

                foreach (var i in sl)
                {
                    Console.WriteLine(i);
                }

                sl.Remove(1);
                Console.WriteLine("after removing");
                foreach (var i in sl)
                {
                    Console.WriteLine(i);
                }
               // Console.WriteLine("contains " + sl.Contains(4));
                Console.WriteLine("contains key " + sl.ContainsKey(3));

                foreach (var i in sl.Keys)
                {
                    Console.WriteLine(i);
                }
                foreach (var i in sl.Values)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(sl.Count);

            }

        public void DictionaryHandling()
        {
            Dictionary<int,string> dic= new Dictionary<int,string>();
            dic.Add(1, "d");
            dic.Add(3, "a");
            dic.Add(2, "c");
            dic.Add(4, "b");
            foreach(var i in dic)
            {
                Console.WriteLine(i);
            }
            dic.Remove(1);
            Console.WriteLine("after removing");
            foreach (var i in dic)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine("contains " + dic.Contains(4));
            Console.WriteLine("contains key " + dic.ContainsKey(3));

            foreach (var i in dic.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (var i in dic.Values)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(dic.Count);
        }
        }
    }




