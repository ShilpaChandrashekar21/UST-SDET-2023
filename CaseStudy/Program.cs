// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using CaseStudy;
using CaseStudy.CustomException;

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






string? pro, phNumber, response;
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
                            product.PlaceOrders(quan, Product.Products);
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

                    digitalProduct.DigitalCart(pro, Product.Products);
                    Console.WriteLine("Do you want to order");
                    string? res = Console.ReadLine();
                    if (res.Equals("yes"))
                    {
                        try
                        {
                            product.PlaceOrders(quan, Product.Products);
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
                foreach (var p in PhysicalProduct.PhysicalProductList)
                {
                    Console.WriteLine("Product Name: " + p.Name + " Product ID: "
                        + p.ProductID + " Price: " + p.Price);
                }
            }
            else
            {
                Console.WriteLine("No Physical Product added");
            }
            if(digitalProduct.AddToCartList1.Count>0)
            {
                foreach (var item in DigitalProduct.digitalProductsList)
                {
                    Console.WriteLine("Product Name: " + item.Name + " Product ID: "
                        + item.ProductID + " Price: " + item.Price);
                }
            }
            else
            {
                Console.WriteLine("No digital Product Added");
            }
            
            break;
            case 3:if(product.AddToCartList.Count==0 || 
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No Products to process the payment");
            }
            else
            {
                Console.WriteLine("Payment");
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
            
            break;
            case 4:
            if (product.AddToCartList.Count == 0 ||
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No products to deliver");
            }
            else
            {
                Console.WriteLine("Delivery");
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
               
            break;
            case 5:Console.WriteLine("you exited");
            Environment.Exit(0);
            break;
        default: Console.WriteLine("check the number entered");
            break;
            
    }
    

    }






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




