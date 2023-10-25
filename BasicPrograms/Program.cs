

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
*/

GenericCollection genericCollection = new GenericCollection();
//genericCollection.ListHandling();
//genericCollection.QueueHandling();
//genericCollection.StackHandling();
//genericCollection.SortedListHandling();
genericCollection.DictionaryHandling();





