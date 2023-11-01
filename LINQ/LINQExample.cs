using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void Example1()
        {
            List<string> courses= new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("C# Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("DBMS");
            courses.Add("UI");
            courses.Add("Angular");

            /*var result = from l in courses
                         where l.Contains("Tutorial")
                         select l;
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }*/

            //var result = courses.Where(c => c.Equals("DBMS"));
            var result = courses.Where(c => c.Contains("Tutorial"));

            foreach (var c in result)
            {
                Console.WriteLine(c);
            }

        }

        public void Example2()
        {
            List<Student> students = new List<Student>()
            {
                new(1,"AA","ECE"),
                new(2,"ZZ","Mech"),
                new(3,"CC","Aerospace"),
                new(4,"GG","ECE"),
                new(5,"VV","CSE"),
                new(6,"DD","ISE"),
                new(7,"EE","Aerospace")
            };

            var stud = students.Where(s => s.StudId == 6);

            foreach (var student in stud)
            {
                Console.WriteLine(student.StudId+" "+student.Name+
                    " "+student.Dept);
            }

            var stud1 = students.Where(s => s.Name == "AA");

            foreach (var student in stud1)
            {
                Console.WriteLine(student.StudId + " " + student.Name +
                    " " + student.Dept);
            }

            Student stud2 = students.FirstOrDefault(s => s.StudId == 9);
            if( stud2 != null)
            {
                Console.WriteLine(stud2.StudId + " " + stud2.Name +
                    " " + stud2.Dept);
            }
            else
            {
                Console.WriteLine("Not found");
            }
                

            List<Student> stud3 = students.FindAll(s => s.Name == "AA");

            foreach (var student in stud3)
            {
                Console.WriteLine(student.StudId + " " + student.Name +
                    " " + student.Dept);
            }
            Console.WriteLine("Order by");
            var student1= students.OrderBy(s => s.Name).ThenBy(s=>s.StudId);

            foreach(var s in student1)
            {
                Console.WriteLine(s.StudId + " " + s.Name +
                    " " + s.Dept);
            }
            Console.WriteLine("Descending");
            var student3 = students.OrderByDescending(s => s.Name);

            foreach (var s in student3)
            {
                Console.WriteLine(s.StudId + " " + s.Name +
                    " " + s.Dept);
            }

            Console.WriteLine("Grouping");
            var student4 = students.ToLookup(s => s.Dept);

            foreach (var s in student4)
            {
                Console.WriteLine(s.Key);

                foreach (var s2 in s)
                {
                    Console.WriteLine(s2.StudId + " " + s2.Name +
                    " " + s2.Dept);
                }
                
            }

        }

        public void Filter()
        {
            ArrayList elements= new ArrayList();
            elements.Add(1);
            elements.Add(2);
            elements.Add("AA");
            elements.Add("CC");
            elements.Add(3);

            var num = elements.OfType<int>();
            var str = elements.OfType<string>();

            foreach (var element in str)
            {
                Console.WriteLine(element);
            }

            foreach (var element in num)
            {
                Console.WriteLine(element);
            }
        }

    }
}
