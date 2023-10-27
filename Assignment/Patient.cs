using Assignment.UserException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Patient
    {
        public Patient(int patientId, string? patientName,
            int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }
        
        public int PatientId { get; set; }
        public string? PatientName { get; set;}
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
        List<Patient> Patients { get; set; } = new List<Patient>();

       public void AddPatientToFile(Patient patient) 
        {
            FileStream fileStream = new FileStream("D:\\SDET Training\\BasicSolution\\Files\\Patient.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            Patients.Add(patient);
            Console.WriteLine("Patient data added");
            
            streamWriter.Write("Patient Id : " + patient.PatientId + " Patient Name :" + patient.PatientName +
        " Age: " + patient.Age + " Diagnosis: " + patient.Diagnosis);
            
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadPatientDetailsFromFile()
        {
            FileStream fileStream = new FileStream("D:\\\\SDET Training\\\\BasicSolution\\\\Files\\\\Patient.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = streamReader.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = streamReader.ReadLine();
            }
            streamReader.Close();
            fileStream.Close();
        }

        public void AddPatient(Patient patient)
        {
            if (patient.Age >= 0 && patient.Age <= 120)
            {

                
                Patients.Add(patient);
                Console.WriteLine("Patient Added");
                Console.WriteLine("Patient Id : " + patient.PatientId + " Patient Name :" + patient.PatientName +
        " Age: " + patient.Age + " Diagnosis: " + patient.Diagnosis);


            }
            else
            {
                throw new AgeException(CustomException.customMessageList[1]);
            }
            
        }
    }
}
