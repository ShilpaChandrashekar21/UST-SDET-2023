using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class CourseRegistration
    {
        private List<string> registeredStudent = new List<string>();

        public void RegisterStudent(string student)
        {
            Thread.Sleep(1000);
            lock (registeredStudent)
            {
                registeredStudent.Add(student);
                Console.WriteLine(student + " has registered");
            }
        }
          
        public int GetRegisteredStudentCount()
        {
            lock (registeredStudent)
            {
                return registeredStudent.Count;

            }
        }
    }
}
