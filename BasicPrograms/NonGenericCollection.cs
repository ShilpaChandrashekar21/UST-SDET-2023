using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonGenericCollection
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(23);
            arrayList.Add(24);
            arrayList.Add(25);

            /*for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }*/
            arrayList.Add("str");
            arrayList.Add(true);
            arrayList.Add(45.88);
            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Reverse();
            Console.WriteLine("after reversing");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.RemoveAt(0);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Clear();
            Console.WriteLine("empty array");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

        public void StackHandling()
        {
            Stack stack = new Stack();  
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5.7);
            stack.Push("asd");

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("pop "+stack.Pop());
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Peek "+stack.Peek());
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count "+stack.Count);
        }
        public void QueueHandling()
        {
            Queue queue = new Queue();
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
            Console.WriteLine("count " + queue.Count);
        }

        public void HashTableHandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 11);
            ht.Add(2, 12);
            ht.Add(3, 13);
            ht.Add("a", 14);

            foreach (var i in ht)
            {
                Console.WriteLine(i);
            }

            ht.Remove(1);
            Console.WriteLine("after removing");
            foreach (var i in ht)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("contains "+ht.Contains(4));
            Console.WriteLine("contains key "+ht.ContainsKey(3));

            foreach (var i in ht.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (var i in ht.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ht.Count);


        }

        public void SortedListHandling()
        {
            SortedList sl= new SortedList();
            
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
            Console.WriteLine("contains " + sl.Contains(4));
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
    }
}
