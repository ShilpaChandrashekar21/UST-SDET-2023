using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Doctor : IDoctor,IAppointment
    {
        public int DoctorId { get; set; }
        public string? DoctorName { get; set;}

        public void AddNewDoctor(int dId,string? dname)
        {
            DoctorId = dId;
            DoctorName = dname;
        }

        public void ModifyDoctor(int dId, string? dname)
        {
            DoctorId = dId;
            DoctorName = dname;
        }

        public void DisplayDoctorDetails()
        {
            Console.WriteLine("Doctor Id : " + DoctorId + " Doctor Name: "
                + DoctorName);
        }

        public void BookAppointment(int did, string? pname)
        {
            Console.WriteLine("Booked Appointment for " + pname +
                " with Doctor " + did);
        }

        public void DeleteAppointment(string? pname)
        {
            Console.WriteLine("Appointment Deleted for " + pname);
        }
    }
}
