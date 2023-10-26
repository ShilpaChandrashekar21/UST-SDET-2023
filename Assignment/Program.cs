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
using Assignment.UserException;
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

InsurancePolicy policy = new("health", 123, 500000);
policy.RenewPolicy(Convert.ToDouble(Console.ReadLine()));
policy.DisplayPolicyDetails();
policy.RenewPolicy();
policy.DisplayPolicyDetails();


LifeInsurance lifeInsurance = new("aa", 12, 500000, 12, 0.3f);
lifeInsurance.CalculatePremium();
lifeInsurance.DisplayLifeInsurancePolicyDetails();

CarInsurance carInsurance = new("bb", 13, 600000,4);
carInsurance.CalculatePremium();
carInsurance.DisplayCarInsurancePolicyDetails();



Customer customer = new Customer();
List<Customer> customerArray = new List<Customer>
{
new(11, "john", "1234", 1000),
new(12, "jim", "12345", 2000),
new(13, "jam", "123456", 3000)
};

foreach(Customer cust in customerArray)
{
Console.WriteLine("Customer Name: "+cust.Name+
" Customer ID : "+cust.CustomerId+" Phone Number: "+
cust.PhoneNumber+" Balance : "+cust.Balance);
}
bool IsCustAvail = false;

foreach (Customer cust in customerArray)
{
if (customer.SearchCustomer("12346", cust))
{
IsCustAvail=true;
Console.WriteLine("Customer Name: " + cust.Name + " Balance: " +
cust.Balance);
break;
}
}

if (!IsCustAvail)
{
Console.WriteLine("Customer not found");
}
*/

List<CallRecord> callRecords = new List<CallRecord>()
{
    new(123,"123456","4 min"),
    new(456,"123456","6 min"),
    new(789,"1234","8 min")

};

/*foreach(CallRecord call in callRecords)
{
    Console.WriteLine("Call Id: "+call.CallID+" Phone Number: "+call.PhoneNumber+
        " CallTime: "+call.CallTime);
    
}
foreach(CallRecord calls in callRecords)
{
    calls.CallHistory(calls);
       
}

Dictionary<string, int> callCount = new Dictionary<string, int>();
foreach(CallRecord calls in callRecords)
{
    if (callCount.ContainsKey(calls.PhoneNumber))
    {
        callCount[calls.PhoneNumber]++;
    }
    else
    {
        callCount[calls.PhoneNumber] = 1;
    }
}
foreach(var i in callCount)
{
    Console.WriteLine(" Phone Number: "+i.Key+ " - Total Calls: "+ i.Value);
}
*/


try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
}
catch(AgeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}







