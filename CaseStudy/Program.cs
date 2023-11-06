// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using CaseStudy;
using CaseStudy.CustomException;
using static CaseStudy.CustomException.EnrollmentExceptions;

class Program
{
    public delegate void Delegate1(int coId, int stId);
    public delegate void Delegate2(int couId);

    public static void Main(string[] args)
    {
        try
        {
            int ch, op;


            do
            {
               
                Console.WriteLine("Choose The Option \n 1->Admin \n2->Student");
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    int choice, choice1;
                    do
                    {
                        Console.WriteLine("Choose The option:\n1.Add Course\n2.View Report");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Course courses = new Course();
                                Console.WriteLine("Enter The Course Code");
                                courses.CourseCode = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Title");
                                courses.Title = Console.ReadLine();
                                Console.WriteLine("Enter the instructor");
                                courses.Instructor = Console.ReadLine();
                                Console.WriteLine("Enter the no of seats");
                                courses.SeatsAvailable = Convert.ToInt32(Console.ReadLine());

                                Course.courses.Add(courses);
                                Console.WriteLine("Course Added Successfully");
                                break;
                            case 2:
                                Course cc = new Course();
                                Console.WriteLine("---------Course---------");
                                foreach (var d in Course.courses)
                                {
                                    if (d != null)
                                    {
                                        Console.WriteLine($"Course Code:{d.CourseCode}\t Course Title:{d.Title}\tInstructor:{d.Instructor}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("No Courses Found !!!!");
                                    }
                                }

                                Console.WriteLine("**** Enrolled Student Details****");
                                foreach (var s in cc.Enrollments)
                                {
                                    if (s != null)
                                    {
                                        Console.WriteLine($"Course Code:{cc.CourseCode}\t Course Title:{cc.Title}\tInstructor:{cc.Instructor}\t Student Id:{s.StudentId}" +
                                            $"student Name:{s.Name}\tEmail:{s.Email}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Enrollment found!!!");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid Option try again Later!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue Press\n1.Yes\n2.No");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                    } while (choice1 == 1);

                }
                else if (ch == 2)
                {
                    int soption, soption1;
                    do
                    {


                        Console.WriteLine("Choose The Menu You Want: \n 1.New Registration" +
                            "\n2.Enroll Course\n3.View Enrolled Course\n4.Withdraw Course \n 5.Exit");
                        soption = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student();
                        Course courses = new Course();

                        switch (soption)
                        {

                            case 1:
                                Console.WriteLine("Enter The Student Id/User Id");
                                student.StudentId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Name");
                                student.Name = Console.ReadLine();
                                Console.WriteLine("Enter The Email");
                                student.Email = Console.ReadLine();

                                Student.students.Add(student);
                                Console.WriteLine("Successfully Register!!!");
                                break;
                            case 2:


                                int cid;
                                if (Course.courses.Count != 0)
                                {
                                    Console.WriteLine("***List Of Course Availble In India School***");
                                    foreach (var course in Course.courses)
                                    {

                                        Console.WriteLine($"Course Code:{course.CourseCode}\tCourse Title:{course.Title}" +
                                            $"\tInstructor:{course.Instructor}\tNo:Of Seat:{course.SeatsAvailable}\t");




                                    }
                                    Console.WriteLine("Enter  the Student Id");
                                    int sssid = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the course code You Want enroll");
                                    cid = Convert.ToInt32(Console.ReadLine());
                                    Enrollasync(sssid, cid);
                                }
                                else
                                {
                                    Console.WriteLine("No Courses Available!!!");

                                }


                                break;
                            case 3:

                                Console.WriteLine("Enter the Stude Id");
                                int esid = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Course Id");
                                int ccid = Convert.ToInt32(Console.ReadLine());

                                var courseObj = Course.courses.Find(x => x.CourseCode == ccid);
                                var EnrolObj = courseObj.Enrollments.Find(x => x.StudentId == esid);

                                if (EnrolObj != null)
                                {



                                    Console.WriteLine($"Course Code:{courseObj.CourseCode}\tTitle:{courseObj.Title}" +
                                        $"\tInstructor:{courseObj.Instructor}\tStudent Id:{EnrolObj.StudentId}\tStudent Name:{EnrolObj.Name}\tEmail:{EnrolObj.Email}");


                                }
                                break;
                            case 4:
                                Console.WriteLine("Enter Your Course Code You Want Withdraw");
                                int eid = Convert.ToInt32(Console.ReadLine());
                                Withdraw(eid);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid option try again!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue press \n 1.Yes \n 2.No");
                        soption1 = Convert.ToInt32(Console.ReadLine());

                    } while (soption1 == 1);
                }

            } while (true);
        }
        catch (FullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DuplicateException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static async Task Enrollasync(int sssid, int cid)
    {
        Course c = new Course();
        await Task.Delay(1000);
        Delegate1 d1 = new Delegate1(c.CourseRegistration);
        d1.Invoke(sssid, cid);

    }
    public static async Task Withdraw(int cid)
    {
        Course cou = new();
        await Task.Delay(1000);
        Delegate2 d2 = new Delegate2(cou.Withdrawal);
        d2.Invoke(cid);
    }
}


/*
public delegate void Delegate1(string cname, Student s);
public delegate void Delegate2(string sname);
class Program
{

    public static void Main(string[] args)
    {
        List<Course> courses = new List<Course>();
        List<Student> students = new List<Student>();
        Course course = new Course();
        int w, v;

        Console.WriteLine("1->Admin\n2->Student");
        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 1)
        {

            do
            {
                Console.WriteLine("1-> Add Course\n2->View All courses\n3->Enroll a student\n" +
                "4-> View Enrolled Student\n5->Remove student\n6->Exit");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Enter the Course Id");
                        int cId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the course name");
                        string cName = Console.ReadLine();
                        Console.WriteLine("Enter the name of Instructor");
                        string cIns = Console.ReadLine();
                        Console.WriteLine("Enter the total seats for this course");
                        int sA = Convert.ToInt32(Console.ReadLine());
                        courses.Add(new(cId, cName, cIns,sA));
                        Console.WriteLine("Course added");
                        break;
                    case 2:Console.WriteLine("---All Courses---");
                        foreach(var c in courses)
                        {
                            Console.WriteLine("Course code: " + c.CourseCode +
                                " Course Name" + c.Title + " Instructor:" + c.Instructor +
                                " No of seats:" + c.SeatsAvailable);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of Student");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the course name");
                        string cname = Console.ReadLine();
                        foreach (Course c in courses)
                        {
                            try
                            {
                                foreach (Student s in students)
                                {
                                    if (name.Equals(s.Name))
                                    {
                                        c.CourseRegistration(cname, s);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Student " + name + "doesn't exist");
                                    }

                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case 4:
                        course.DisplayEnrolledStudents();
                        break;
                    case 5:
                        Console.WriteLine("Enter the student name ");
                        string sn = Console.ReadLine();
                        Console.WriteLine("Enter the course name");
                        string cn = Console.ReadLine();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                Console.WriteLine("1-> yes\n2->no");
                 w = Convert.ToInt32(Console.ReadLine());
            } while (w == 1);
        }
        else
        {
            do
            {
                Console.WriteLine("1->Enroll for a course\n" +
               "2-> View Enrolled Student\n3->Withdraw course registration\n4->Exit");
                int res1 = Convert.ToInt32(Console.ReadLine());
                switch (res1)
                {

                    case 1:
                        Console.WriteLine("Enter the name of Student");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the course name");
                        string cname = Console.ReadLine();
                        foreach (Course c in courses)
                        {
                            try
                            {
                                foreach (Student s in students)
                                {
                                    if (name.Equals(s.Name))
                                    {
                                        c.CourseRegistration(cname, s);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Student " + name + "doesn't exist");
                                    }

                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case 2:
                        course.DisplayEnrolledStudents();
                        break;
                    case 3:
                        Console.WriteLine("Enter the student name ");
                        string sn = Console.ReadLine();
                        Console.WriteLine("Enter the course name");
                        string cn = Console.ReadLine();


                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                Console.WriteLine("1-> yes\n2->no");
                v = Convert.ToInt32(Console.ReadLine());
            } while (v==1);

        }


    }
}

*/

           
/*Console.WriteLine("Choose");
Console.WriteLine("1-> Book\n 2-> Fiction\n 3-> NonFiction \n " +
    "4-> Get Customer Details\n 5-> To Order" );
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Book book = new Book();
        Console.WriteLine("Enter the title");
        book.Title=Console.ReadLine();
        Console.WriteLine("Enter the Author");
        book.Author=Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        book.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        book.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        book.Availability= Console.ReadLine();
        book.DisplayBook();
        book.SearchBook();
        break;
        case 2:
        Fiction fiction = new Fiction();
        Console.WriteLine("Enter the title");
        fiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        fiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        fiction.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        fiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        fiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the Category");
        fiction.Category = Console.ReadLine();
        fiction.DisplayBook();
        fiction.DisplayFictionDetails();
        fiction.SearchFictionBook();
        break;
        case 3:
         NonFiction nonfiction = new NonFiction();
        Console.WriteLine("Enter the title");
        nonfiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        nonfiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        nonfiction.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Price");
        nonfiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availabity");
        nonfiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the Edition");
        nonfiction.Edition = Convert.ToInt32(Console.ReadLine());
        nonfiction.DisplayBook();
        nonfiction.DisplayNonFictionDetails();
        nonfiction.SearchNonFictionBook();
        break;
        case 4:
            Customer customer = new Customer();
        Console.WriteLine("Enter the Customer Id");
        customer.CustomerId1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Customer Name");
        customer.CustomerName1 = Console.ReadLine();
        Console.WriteLine("Enter the Phone Number");
        customer.PhoneNumber1 = Console.ReadLine();
        customer.DisplayCustomerDetails();
        customer.AddCustomerDetails("64646");
        Console.WriteLine("After modification");
        customer.DisplayCustomerDetails();
        break;
        case 5:
            Order order = new Order();
        Book book1 = new Book();
        
        Console.WriteLine("Enter the Customer Id");
        order.CustomerId1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Customer Name");
        order.CustomerName1 = Console.ReadLine();
        Console.WriteLine("Enter the Customer Phone Number");
        order.PhoneNumber1 = Console.ReadLine();
        Console.WriteLine("Enter the Book Details Title And Author Name");
        book1.Title = Console.ReadLine();
        book1.Author = Console.ReadLine();
        Console.WriteLine("enter the cost of book");
        book1.Price=Convert.ToInt32(Console.ReadLine());
        order.DisplayCustomerDetails();
        order.PlaceOrder(book1);
       Console.WriteLine("Total cost: "+ order.CalculateCost(book1));
        break;

    default:    
        Console.WriteLine("please check the number you have entered");
        break;

}*/






/*string? pro, phNumber, response;
int quan, cusId;


PhysicalProduct product = new PhysicalProduct();
product.Name = "soap";
product.ProductID = 10;
product.Price = 20;
product.StockQuantity = 20;
product.Weight = 2;
product.Dimension = "2x2";



Product.Products.Add(product);


DigitalProduct digitalProduct = new DigitalProduct();
digitalProduct.Name = "photo";
digitalProduct.ProductID = 110;
digitalProduct.Price = 2000;
digitalProduct.StockQuantity = 20;
digitalProduct.DownloadLink = "https://photo.com";
digitalProduct.FileFormat = "jpeg";

Product.Products.Add(digitalProduct);

Order order = new Order();
Console.WriteLine("Welcome");
Console.WriteLine("Enter your details");
Console.WriteLine("Enter the customer Id");
order.CustomerId1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the phone number");
order.PhoneNumber1 = Console.ReadLine();

while (true)
    {

        Console.WriteLine("1->To Shop\n2-> To view cart\n" +
            "3->for Payment\n 4-> Delivery details\n5->exit");
        int ch=Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                Console.WriteLine("Choose\n1->Physical Product\n 2-> Digital Product");
                int ch1 = Convert.ToInt32(Console.ReadLine());
                if (ch1 == 1)
                {
                try
                {
                    Console.WriteLine("enter the product name you wish to buy");
                    pro = Console.ReadLine();
                    

                    product.PhysicalCart(pro, Product.Products);
                    Console.WriteLine("enter the product quantity");
                    quan = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Do you want to order");
                    string? res = Console.ReadLine();
                    if (res.Equals("yes"))
                    {
                        try
                        {
                            product.PlaceOrders(quan, 
                                Product.Products);
                        }

                        catch (PlaceOrderException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                catch (ProductNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                
                
            }
                else
                {
                    try
                    {
                        Console.WriteLine("enter the product name " +
                            "you wish to buy");
                        pro = Console.ReadLine();
                    Console.WriteLine("enter the product quantity");
                    quan = Convert.ToInt32(Console.ReadLine());

                    digitalProduct.DigitalCart(pro, 
                        Product.Products);
                    Console.WriteLine("Do you want to order");
                    string? res = Console.ReadLine();
                    if (res.Equals("yes"))
                    {
                        try
                        {
                            digitalProduct.PlaceOrders(quan, 
                                Product.Products);
                        }

                        catch (PlaceOrderException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                }
                    catch (ProductNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                       

                    }
                }
                break;
            case 2:Console.WriteLine("Products in cart");
            if (product.AddToCartList.Count > 0)
            {
                
                    Console.WriteLine("Product Name: " + product.Name + " Product ID: "
                        + product.ProductID + " Price: " + product.Price);
                
            }
            else
            {
                Console.WriteLine("No Physical Product added");
            }
            if(digitalProduct.AddToCartList1.Count>0)
            {
                
                    Console.WriteLine("Product Name: " + digitalProduct.Name + " Product ID: "
                        + digitalProduct.ProductID + " Price: " + digitalProduct.Price);
                
            }
            else
            {
                Console.WriteLine("No digital Product Added");
            }
            
            break;
            case 3:
            if(product.AddToCartList.Count==0 && 
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No Products to process the payment");
            }
            else if(product.AddToCartList.Count > 0)
            {
                Console.WriteLine("---Payment------");
                try
                {
                    Console.WriteLine("enter the customerId to" +
                        " process the payment");
                    cusId = Convert.ToInt32(Console.ReadLine());
                    product.ProcessPayment(cusId, order);
                }
                catch (ProcessPaymentException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            else if(digitalProduct.AddToCartList1.Count > 0)
            {
                Console.WriteLine("---Payment------");
                try
                {
                    Console.WriteLine("enter the customerId to" +
                        " process the payment");
                    cusId = Convert.ToInt32(Console.ReadLine());
                    digitalProduct.ProcessPayment(cusId, order);
                }
                catch (ProcessPaymentException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            
            break;
            case 4:
            if (product.AddToCartList.Count == 0 &&
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No products to deliver");
            }
            else if (product.AddToCartList.Count > 0)
            {
                Console.WriteLine("---Delivery---");
                try
                {
                    Console.WriteLine("enter the Phone Number to receive your order");
                    phNumber = Console.ReadLine();
                    product.DeliverOrders(phNumber, order);
                }
                catch (DeliverOrderException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            else if (digitalProduct.AddToCartList1.Count > 0)
                {
                    Console.WriteLine("---Delivery---");
                    try
                    {
                        Console.WriteLine("enter the Phone Number to receive your order");
                        phNumber = Console.ReadLine();
                        digitalProduct.DeliverOrders(phNumber, order);
                    }
                    catch (DeliverOrderException e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
            
               
            break;
            case 5:Console.WriteLine("you exited");
            Environment.Exit(0);
            break;
        default: Console.WriteLine("check the number entered");
            break;
            
    }
    

    }

*/




/*Console.WriteLine("Please enter the below details");
Console.WriteLine("Order ID: ");
order.OrderId =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Customer Name: ");
order.CustomerName1 = Console.ReadLine();
Console.WriteLine("Phone Number: ");
order.PhoneNumber1 = Console.ReadLine();
Console.WriteLine("Customer ID:");
order.CustomerId1= Convert.ToInt32(Console.ReadLine());*/





/*foreach (var p in productList)
{
    

    
    try
    {
        Console.WriteLine("enter the product quantity");
        quan=Convert.ToInt32(Console.ReadLine());
        p.PlaceOrders(quan, p);
    }
    catch(PlaceOrderException e)
    {
        Console.WriteLine( e.Message);
    }
    try
    {
        Console.WriteLine("enter the order ID to process the payment");
        orId=Convert.ToInt32(Console.ReadLine());
        p.ProcessPayment(orId, order);
    }
    catch(ProcessPaymentException e)
    {
        Console.WriteLine( e.Message);
        break;
    }
    try
    {
        Console.WriteLine("enter the Phone Number to receive your order");
        phNumber=Console.ReadLine();
        p.DeliverOrders(phNumber, order);
    }
    catch(DeliverOrderException e)
    {
        Console.WriteLine(e.Message);
        break;
    }
    Console.WriteLine("Do you want to add more product");
    response = Console.ReadLine();
    if (response.Equals("yes"))
    {
        continue;
    }
    else
    {
        break;
    }
}*/




