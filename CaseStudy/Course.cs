using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Course :  IEnrollable
    {
        public Course(int courseCode, string? title, string? instructor, int seatsAvailable)
        {
            CourseCode = courseCode;
            Title = title;
            Instructor = instructor;
            EnrolledStudents = new List<Student>();
            SeatsAvailable = seatsAvailable;
        }
        public Course() { }



        public int CourseCode { get; set; }
        public string? Title { get; set;  }
        public string? Instructor { get; set; }
        public int SeatsAvailable { get; set; }
        //public static List<Course> courses = new List<Course>();
        List<Student> EnrolledStudents { get; set; }

        public void CourseRegistration(string courseName,Student student)
        {
            if(courseName.Equals(Title) && SeatsAvailable >= EnrolledStudents.Count)
            {
                try
                {
                    EnrolledStudents.Add(student);
                    Console.WriteLine("Registered");
                }
                catch 
                {
                    throw new EnrollmentException(CustomExceptions.messageList["CNF"]);
                }
               
            }
            else
            {
                throw new EnrollmentException(CustomExceptions.messageList["CF"]);
            }
           
            
        }

        public void Withdrawal(string name)
        {
            try
            {
                var res = EnrolledStudents.Where(x => x.Name == name);
                foreach (var st in res)
                {
                    if (res != null)
                    {
                        EnrolledStudents.Remove(st);
                        Console.WriteLine("Withdrawn");
                    }

                }
            }
            catch
            {
                throw new EnrollmentException(CustomExceptions.messageList["SNF"]);
            }
            
            
        }

        public void DisplayEnrolledStudents()
        {
            foreach(Student student in EnrolledStudents)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
