// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

Student student = new Student("paul");
Console.WriteLine(student.CalculateAverage());




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
*/

using Assignment;
/*
ElectronicsProduct electronicsProduct = new(5, "fan", 870, 8);
electronicsProduct.DisplayProduct();
electronicsProduct.ElectronicsProductDisplay();

DigitalProduct digitalProduct = new(5, "camera", 10000, 6, "MP4");
digitalProduct.DisplayProduct();
digitalProduct.ElectronicsProductDisplay();
digitalProduct.DisplayDigitalProduct();


Console.WriteLine("Choose");
Console.WriteLine("1 -> DigitalProduct\n 2->ElectronicsProduct\n " +
    "3-> ClothingProduct");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        DigitalProduct digitalProduct = new(5, "camera", 10000, 6, "MP4");
        digitalProduct.DisplayProduct();
        digitalProduct.ElectronicsProductDisplay();
        digitalProduct.DisplayDigitalProduct();
        break;
        case 2:
        ElectronicsProduct electronicsProduct = new(5, "fan", 870, 8);
        electronicsProduct.DisplayProduct();
        electronicsProduct.ElectronicsProductDisplay();
        break;
        case 3:
        ClothingProduct clothingProduct = new("Dress", 500, 4, "XL");
        clothingProduct.DisplayProduct();
        clothingProduct.DisplayClothing();
        break;
    default: Console.WriteLine("Please check the number you have entered");
        break;


}


Employee employee = new("ab", "cd", 23, 22);
employee.DisplayInfo();
*/

Circle circle = new Circle();
circle.Radius = 5;
circle.Draw();
Console.WriteLine("Area : "+circle.CalculateArea());
Console.WriteLine("Perimeter: "+circle.CalculatePerimeter());

Rectangle rectangle = new Rectangle();
rectangle.Length = 10;
rectangle.Breadth = 20;
rectangle.Draw();
Console.WriteLine("Area: "+rectangle.CalculateArea());
Console.WriteLine("Perimeter: "+rectangle.CalculatePerimeter());




