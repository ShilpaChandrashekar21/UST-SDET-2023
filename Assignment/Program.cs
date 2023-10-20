// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

Student student = new Student("paul");
Console.WriteLine(student.CalculateAverage());



*/
using Assignment;
using System.Net.Http.Headers;

Product[] product = new Product[3];
product[0] = new Product("soap", 55, 10);
product[1] = new Product("oil", 500, 104);
product[2] = new Product("rice", 75, 100);


foreach (Product p in product)
{


    Console.WriteLine("Total Product value :" + p.ProductValue());
    p.DisplayProduct();
    p.SetPrice(67);
    p.DisplayProduct();
}



StudentArray[] studentArray = new StudentArray[]{

     new("Abc", new int[]{30, 40, 50}, "A"),
      new("Abc", new int[]{90, 40, 80}, "A"),
       new("Abc", new int[]{70, 60, 50}, "A")
};
foreach (var student in studentArray)
{
    double average = student.CalculateAverage();
    student.GetMarksSummary();
    Console.WriteLine("Average of Student: "+average);
    student.DisplayStudentDetails();
   
}

