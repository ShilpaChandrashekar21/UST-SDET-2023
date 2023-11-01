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

TouristDestination tourist = new TouristDestination();

 List<TouristDestination> tours = new List<TouristDestination>()
 {
            new("Manali","Himachal Pradesh",5,2500),
            new("Kashmir","Jammu & Kashmir",4.5,4000),
            new("Paris","France",4.8,500000),
            new("Nandi Hills","Bangalore",4.2,1000),

        };

Console.WriteLine("Top-Rated");
tourist.TopRated(tours);
Console.WriteLine("List of Destination from low to high");
tourist.PriceAscending(tours);
Console.WriteLine("Enter the destination name");
string? resp = Console.ReadLine();
tourist.FilterDestination(resp, tours);

/*int ch, res;
List<TourismDestination> destinations = new List<TourismDestination>()
{
    new("Manali","India",5),
    new("Kashmir","India",4),
    new("Paris","France",5),
    new("Nandi Hills","India",5),
    new("AA","BB",2)
};
//TourismDestination.tourismDestinations = destinations;
do
{
    Console.WriteLine("1-> Add Tourism Details\n2->View Destination list based on rating" +
       "\n3->exit");
    ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Enter the Name of destination");
            string? n = Console.ReadLine();
            Console.WriteLine("Enter the Name of Country");
            string? c = Console.ReadLine();
            Console.WriteLine("Rate your experience");
            int r = Convert.ToInt32(Console.ReadLine());
            if  (r>5 || r<1)
            {
                Console.WriteLine("Please enter the rating between 1 to 5");
            }
            destinations.Add(new(n,c,r));
            break;
        case 2:
            Console.WriteLine("Ratings");
            TourismDestination.SortOnRating(destinations);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;


    }
    Console.WriteLine("Do you wish to continue\n1->yes\n2->no");
    res = Convert.ToInt32(Console.ReadLine());

} while (res == 1);
*/
/*using Assignment;
using Assignment.UserException;

public delegate void EDelegate();
public delegate void NDelegate(string name);
class Program
{
    
    public static void Main(string[] args)
    {
        HotelEvents hotelEvents = new HotelEvents();
        EDelegate del1 = hotelEvents.RegisterToEvent;
        del1.Invoke();
        NDelegate del2 = hotelEvents.EventNotification;
        del2.Invoke("music");

    }
}*/

/*class Program
{
    public delegate double Delegate1(EmployeeD employeeD);

    public static void Main(string[] args)
    {
        EmployeeD employee = new EmployeeD(199,"jack",4);
        Delegate1 del =EmployeeD.BonusCalculation;

        Console.WriteLine("Employee Id: " + employee.EmployeeId +
            " Employee Name: " + employee.EmployeeName + " Performance Rating: " +
            employee.PerformanceRating + " Bonus: " + del.Invoke(employee));
    }
}*/

/*  
List<HotelRoom> roomList = new List<HotelRoom>()
      {
          new(101,"Single",true),
          new(102,"Double",false),
          new(103,"Suite",true)
      };

RoomReservation<HotelRoom> roomReservation = 
  new RoomReservation<HotelRoom>(roomList);
roomReservation.Booking(102);
roomReservation.Cancelation(102);
*/

/*int op;
 List<Products<string>> inventory = new List<Products<string>>();
do
{
    Console.WriteLine("1-> Add Products\n 2-> View Product\n 3->Update Product\n " +
        "4-> Delete Product\n 5-> search product by name\n 6->  search product by id" +
        "7-> Exit");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("enter the ProductID");
            int proID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Product name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Stock Quantity");
            int stock = Convert.ToInt32(Console.ReadLine());
            AddProduct(new Products<string>(proID,name,price,stock));
            Console.WriteLine("Products Added");
            break;
        case 2:
            foreach (var product in inventory)
            {
                Console.WriteLine("Product Id: " + product.ProductId +
                    " Product Name: " + product.ProductName +
                    " Price: " + product.Price + " Stock: " + product.QuantityInStock);
            }
            break;
        case 3:Console.WriteLine("Enter the product Id you want to update");
            
            UpdateProduct(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Updated");
            break;
        case 4:
            Console.WriteLine("Enter the product Id you want to delete");
            RemoveProduct(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Deleted");
            break;
        case 5:
            Console.WriteLine("Enter the product name");
            FindBy(Console.ReadLine());
            break;
        case 6:
            Console.WriteLine("Enter the product Id ");
            FindById(Convert.ToInt32(Console.ReadLine()));
            break;
        case 7:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid");
            break;

    }
    Console.WriteLine("do you need to continue\n 1-> yes \n 2-> no");
    op = Convert.ToInt32(Console.ReadLine());

} while (op == 1);

 void AddProduct(Products<string> prod)
{
   
    inventory.Add(prod);

}

 void UpdateProduct(int prodId)
{
    foreach(var product in inventory)
    {
        if (inventory.Count > 0 & product.ProductId == prodId)
        {
            Console.WriteLine("enter Product ID");
            product.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the price");
            product.Price = Convert.ToInt64(Console.ReadLine());
            

        }
        else
        {
            Console.WriteLine(prodId + " doesn't exit");
            break;
        }
    }
    

}

 void RemoveProduct(int prodId)
{
    foreach (var product in inventory)
    {
        if (inventory.Count > 0 && product.ProductId == prodId)
        {
            inventory.Remove(product);
        }
        else
        {
            Console.WriteLine(prodId + "doesn't exist");
            break;
        }
    }
    
}

 void FindBy(string productName)
{
    foreach (var product in inventory)
    {
        if (productName.Equals(product.ProductName))
        {
            Console.WriteLine("ProductName" + product.ProductName +
                " Product ID: " + product.ProductId +
                " Price: " + product.Price + " Stock: " + product.QuantityInStock);
        }
        else
        {
            Console.WriteLine(productName + "doesn't exist");
            break;
        }
    }
        
}

 void FindById(int productId)
{
    foreach (var product in inventory)
    {
        if (product.ProductId==productId)
        {
            Console.WriteLine("ProductName" + product.ProductName +
                " Product ID: " + product.ProductId +
                " Price: " + product.Price + " Stock: " + product.QuantityInStock);
        }
        else
        {
            Console.WriteLine(productId + "doesn't exist");
            break;
        }
    }
        
}
*/




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


Console.WriteLine("Customer Details");
Console.WriteLine();
foreach (Customer cust in customerArray)
{
Console.WriteLine("Customer Name: "+cust.Name+
" Customer ID : "+cust.CustomerId+" Phone Number: "+
cust.PhoneNumber+" Balance : "+cust.Balance);
}
Console.WriteLine();
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


List<CallRecord> callRecords = new List<CallRecord>()
{
    new(123,"123456","4 min"),
    new(456,"123456","6 min"),
    new(789,"1234","8 min")

};
Console.WriteLine("The Call Records Details");

foreach(CallRecord call in callRecords)
{
    Console.WriteLine("Call Id: "+call.CallID+" Phone Number: "+call.PhoneNumber+
        " CallTime: "+call.CallTime);
    
}
Console.WriteLine();
Console.WriteLine("Calls with the specific Phone Number");
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

Console.WriteLine();
Console.WriteLine("Total Calls with the specific Phone Number");
foreach(var i in callCount)
{
    Console.WriteLine(" Phone Number: "+i.Key+ " - Total Calls: "+ i.Value);
}
Console.WriteLine();

try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
    Console.WriteLine();
}
catch(AgeException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
    Console.WriteLine();
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}

try
{
    MedicalRecord medicalRecord = new MedicalRecord(11, "Sam", 25, "HeadAche", 101, 5000);
    medicalRecord.AddMedicalRecord(medicalRecord);
}
catch(InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch(InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}

try
{
    MedicalRecord medicalRecord1 = new MedicalRecord(100, "", 25, "", 101, 5000);
    medicalRecord1.AddMedicalRecord(medicalRecord1);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}

try
{
    MedicalRecord medicalRecord2 = new MedicalRecord(10, "Sil", 25, "Fever", 101, -5000);
    medicalRecord2.AddMedicalRecord(medicalRecord2);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Choose");
Console.WriteLine("1->Add Patient\n2->View Patient\n 3-> exit");
int ch = Convert.ToInt32(Console.ReadLine());
Patient patient = new Patient(12, "aa", 24, "diabetics");
switch (ch)
{
    case 1:
        
        patient.AddPatientToFile(patient);
        break;
    case 2:
        patient.ReadPatientDetailsFromFile();
        break;
    case 3:
        Console.WriteLine("You got exited from execution");
        break;
    default:
        Console.WriteLine("Please check the number");
        break;
}
*/

/*MedicalHistory medicalHistory = new MedicalHistory();
medicalHistory.RecordId = 11;
medicalHistory.PatientId = 102;
medicalHistory.Description = " Paracetamol for 2 days";
medicalHistory.Date = DateTime.UtcNow;


    Console.WriteLine("Choose");
    Console.WriteLine("1->Add Medical History\n2->View Medical History\n 3-> exit");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:

            medicalHistory.AddMedicalHistoryToFile(medicalHistory);
            break;

        case 2:
            Console.WriteLine("Enter the Patient Id to read");
            medicalHistory.ReadMedicalHistoryFromFile(Convert.ToInt32(Console.ReadLine()));
            break;
        case 3:
            Console.WriteLine("You got exited from execution");
            break;
        default:
            Console.WriteLine("Please check the number");
            break;
    }
    */














