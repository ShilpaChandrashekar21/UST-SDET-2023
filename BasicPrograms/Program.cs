﻿

/*
Electricity electricity = new Electricity(12345, 9000, 9300, "YY");
Console.WriteLine(electricity.CalculationOfBill());
Console.WriteLine(electricity.consumer_number);
Console.WriteLine(electricity.consumer_name);


Employee employee = new(123, "ABC", "testing", 100000);
Console.WriteLine("EMP_ID = {0}\n Name = {1} \n Department = {2} \n Salary = {3} \n",employee.Emp_id,
employee.Ename,
employee.Dept,
employee.Basic_pay);

Console.WriteLine("net salary = " + employee.CalculateSalary());


ArrayExample arrayExample = new ArrayExample();
arrayExample.OneDim();
arrayExample.TwoDim();
arrayExample.JaggedArray();
*/

using BasicPrograms;
using BasicPrograms.ExceptionMessage;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

//StudentMarks studentMarks = new(3, "ww", "bal", 34, 56, 55, 67, 5);
/*
StudentMarks studentMarks = new StudentMarks();
studentMarks.RollNo = 1;
studentMarks.StudentName = "Test";
studentMarks.Marks1 = 30;
studentMarks.Marks2 = 40;
studentMarks.Marks3 = 50;
Console.WriteLine(" total : "+studentMarks.CalculateTotal());
Console.WriteLine("average : "+studentMarks.CalculateAverage());

StudentGrade grade = new StudentGrade();
grade.RollNo = 1;
grade.StudentName = "Test";
grade.Marks1 = 40;
grade.Marks2 = 50;
grade.Marks3 = 60;
grade.DisplayStudentDetails();
Console.WriteLine("Total : "+grade.CalculateTotal());
Console.WriteLine("Average : "+grade.CalculateAverage());
Console.WriteLine("Grade : "+grade.CalculateGrade());


Console.WriteLine("Choose");
Console.WriteLine("1 -> Teaching Staff\n 2 -> Non-Teaching Staff \n 3 -> Student Details" +
    " 4 -> Staff Details\n 5 -> Student Marks \n 6 -> Student Grade");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff teachingStaff = new TeachingStaff();
        Console.WriteLine("Enter the Staff id");
        teachingStaff.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Staff name");
        teachingStaff.StaffName = Console.ReadLine();
        Console.WriteLine("Enter the Staff Department");
        teachingStaff.Dept= Console.ReadLine();
        Console.WriteLine("Enter the Staff Specialization");
        teachingStaff.Specialization = Console.ReadLine();
        Console.WriteLine("Enter the Staff Sem");
        teachingStaff.Sem= Convert.ToInt32(Console.ReadLine());
        teachingStaff.DisplayStaffDetails();
        teachingStaff.DisplayTeachingStaffDetails();
        break;
        case 2:
        NonTeachingStaff nonteachingStaff = new NonTeachingStaff();
        Console.WriteLine("Enter the Staff id");
        nonteachingStaff.StaffId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Staff Name");
        nonteachingStaff.StaffName = Console.ReadLine();
        Console.WriteLine("Enter the Staff Dept");
        nonteachingStaff.Dept = Console.ReadLine();
        Console.WriteLine("Enter the Staff Responsibility");
        nonteachingStaff.Responsibity = Console.ReadLine();
        Console.WriteLine("Enter the Staff Experience");
        nonteachingStaff.Experience = Convert.ToInt32(Console.ReadLine());
        nonteachingStaff.DisplayStaffDetails();
        nonteachingStaff.DisplayNonTeachingStaffDetails();
        break;
        case 3:
        StudentDetails studentDetails = new StudentDetails();
        Console.WriteLine(" Enter the Student name");
        studentDetails.StudentName = Console.ReadLine();
        Console.WriteLine(" Enter the Student Rollno");
        studentDetails.RollNo=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter the Student city");
        studentDetails.City = Console.ReadLine();
        Console.WriteLine(" Enter the college name");
        studentDetails.CollegeName = Console.ReadLine();
        Console.WriteLine(" Enter the college Id");
        studentDetails.CollegeId= Convert.ToInt32(Console.ReadLine());
        studentDetails.DisplayCollegeDetails();
        studentDetails.DisplayStudentDetails();
        break;
        case 4:
        StaffDetails staffDetails = new StaffDetails();
        staffDetails.StaffName = Console.ReadLine();
        staffDetails.StaffId = Convert.ToInt32(Console.ReadLine());
        staffDetails.Dept= Console.ReadLine();
        staffDetails.CollegeId= Convert.ToInt32(Console.ReadLine());
        staffDetails.CollegeName= Console.ReadLine();
        staffDetails.DisplayCollegeDetails();
        staffDetails.DisplayStaffDetails();
        break;
        case 5:
        StudentMarks studentMarks = new StudentMarks();
        studentMarks.RollNo = 1;
        studentMarks.StudentName = "Test";
        studentMarks.Marks1 = 30;
        studentMarks.Marks2 = 40;
        studentMarks.Marks3 = 50;
        Console.WriteLine(" total : " + studentMarks.CalculateTotal());
        Console.WriteLine("average : " + studentMarks.CalculateAverage());
        break;
        case 6:
        StudentGrade grade = new StudentGrade();
        grade.RollNo = 1;
        grade.StudentName = "Test";
        grade.Marks1 = 40;
        grade.Marks2 = 50;
        grade.Marks3 = 60;
        grade.DisplayStudentDetails();
        Console.WriteLine("Total : " + grade.CalculateTotal());
        Console.WriteLine("Average : " + grade.CalculateAverage());
        Console.WriteLine("Grade : " + grade.CalculateGrade());
        break;
        default: Console.WriteLine("You have entered a wrong number");
        break;



}


EV eV = new();
eV.VehicleNum = 9339;
eV.Brand = "TATA";
eV.Model = "2022";
eV.Display();
Console.WriteLine(eV.setTypeForVeh());

PV pV = new();
pV.VehicleNum = 899;
pV.Brand = "Suzuki";
pV.Model = "2023";
pV.Display();
Console.WriteLine(pV.setTypeForVeh());


Doctor doctor = new Doctor();
doctor.AddNewDoctor(23,"AAD");
doctor.DisplayDoctorDetails();
doctor.ModifyDoctor(24,"AAE");
doctor.DisplayDoctorDetails();
doctor.BookAppointment(23, "AS");
doctor.DeleteAppointment("AS");


Surgeon surgeon = new Surgeon();
surgeon.AddNewDoctor(23, "AA");
surgeon.DisplayDoctorDetails();
surgeon.ModifyDoctor(24, "BB");
surgeon.DisplayDoctorDetails();
surgeon.BookAppointment(23, "AA");
surgeon.DeleteAppointment("AA");
surgeon.DisplaySurgeonDetails("SR");


//BankDetails bankDetails=new BankDetails(123,123456789L,"ASD","Active");
//BankDetails bank = new(12, 12344L, "AA");
//BankDetails bank = new( 12344L, "AA");

BankDetailsNew bank = new(22, 2344L, "Shilpa", "active");
bank.WelcomeMessage();
Console.WriteLine("How do you want to get your Bank details");
Console.WriteLine("Select \n 1-> Customer id\n 2-> Account number\n " +
    "3-> name");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Console.WriteLine("enter the customer ID");
        bank.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        
        break;
    case 2:
        Console.WriteLine("enter the  Account Number");
        bank.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("enter the  Name");
        bank.GetAccountDetails(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Please check the number you have entered");
        break;

}


NonGenericCollection non = new NonGenericCollection();
//non.ArrayListHandling();
//non.StackHandling();
//non.QueueHandling();
//non.HashTableHandling();
//non.SortedListHandling();


GenericCollection genericCollection = new GenericCollection();
//genericCollection.ListHandling();
//genericCollection.QueueHandling();
//genericCollection.StackHandling();
//genericCollection.SortedListHandling();
genericCollection.DictionaryHandling();
*/

/*ExceptionHandling exception = new(12, 101);
try
{
    
    exception.NumCheck1();

}
catch (Num1Exception ex) 
{
    Console.WriteLine(ex.Message);
}

try
{
    
    exception.NumCheck2();

}
catch (Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

/*try
{
   // exception.Divide();
    exception.NumCheck();
    
}
catch(ArgumentException ex) 
{
    Console.WriteLine(ex.Message);
}
try
{
    
    exception.NumCheck2();

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}*/
/*catch (ArithmeticException)
{
    Console.WriteLine(myException.exMessageList[1]);

}
catch (IndexOutOfRangeException)
{
    Console.WriteLine(myException.exMessageList[2]);
}
catch (ArgumentException)
{
    Console.WriteLine(myException.exMessageList[4]);
}
catch (Exception )
{
    Console.WriteLine(myException.exMessageList[3]);
}

finally
{
    Console.WriteLine("Done");
}*/

/*FileOperations file=new FileOperations();
//file.CreateFile();
//file.WriteFile();

//file.ReadFile();
//file.CopyMoveTo();

//file.DeleteFile();

file.FileProperties();
*/

/*GenericsExample<int> g1 = new GenericsExample<int>(10, 20);
Console.WriteLine(g1.Val1 + " " +g1.Val2);

GenericsExample<double> g2 = new GenericsExample<double>(10.99, 20.80);
Console.WriteLine(g2.Val1 + " " + g2.Val2);

GenericsExample<string> g3 = new GenericsExample<string>("hi", "welcome");
Console.WriteLine(g3.Val1 +" "+ g3.Val2);

GenericsExample<bool> g4 = new GenericsExample<bool>(true, false);
Console.WriteLine(g4.Val1 +" "+ g4.Val2);

*/


/*GenericsExample<int> genericsExample= 
    new GenericsExample<int>(new int[3] {10,20,30});
genericsExample.Display();*/

/*int n1=10, n2=20;
GenericsExample<int>.Swap(ref n1,ref n2);
Console.WriteLine("n1: "+n1+" n2: " +n2);*/

public delegate void MyDelegate(string text);
public delegate void MyDelegate2(int num1,int num2);

public delegate int MyDelegate3(int num1, int num2);
//public delegate void MyDelegate();
class Program
{


    //with parameter 
    /* public static void DelCall()
     {

         MyDelegate del = DelegateExample.Display;
         del.Invoke("Hello !!");
     }*/

    // non static method
    
    public static void DelCall()
    {
        DelegateExample delegateExample = new DelegateExample();
        MyDelegate del = delegateExample.Display;
        del.Invoke("Hello !!");

        MyDelegate2 del1 = delegateExample.Add;
       // del1(10, 20);

        MyDelegate2 del2 = delegateExample.Sub;
        //del2(20, 20);

        MyDelegate2 delobj = del1 + del2;
        delobj(30, 20);

        MyDelegate3 del3 = delegateExample.AddR;
        Console.WriteLine(del3(10, 20));
    }


    /*public static void DelCall()
    {
        MyDelegate del = DelegateExample.Display;
        del.Invoke();
    }*/
    
    public static void Main(string[] args)
    {
        /*MyDelegate del = DelegateExample.Display;
        del.Invoke();*/
        DelCall();

        
        
    }
}





