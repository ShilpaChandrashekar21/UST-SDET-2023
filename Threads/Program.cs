// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Threads;

class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>()
        {
            "https://www.amazon.com",
            "https://www.google.com",
            "https://www.microsoft.com"
        };

        Console.WriteLine("Downloading web pages asynchronously");

         List<Task<string>> downloadTasks = new List< Task<string>>();
        foreach (string url in urls)
        {
            downloadTasks.Add(DownloadWebPageAsync(url));
        }
        await Task.WhenAll(downloadTasks);

        foreach(Task<string> downloadTask in downloadTasks)
        {
            string content = await downloadTask;
            Console.WriteLine("Downloaded "+content.Length+" bytes from a web pages");
        }
        Console.WriteLine("All web pages downloaded");

    }

    static async Task<string> DownloadWebPageAsync(string url)
    {
        using(HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}

/*class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting the asynchronous operation");

        await PerformAsyncOperation();

        Console.WriteLine("Asynchronous operation completed");
    }

    static async Task PerformAsyncOperation()
    {
        await Task.Delay(1000);
        Console.WriteLine("Async operation is complete");
    }
}*/
/*CourseRegistration course = new CourseRegistration();

int numberOfStudents=Convert.ToInt32(Console.ReadLine());
List<Thread> StudentList = new List<Thread>();  

for (int i = 1; i < numberOfStudents; i++)
{
    string studentName = $"Student{i}";
    Thread thread = new Thread(() => course.RegisterStudent(studentName));
    StudentList.Add(thread);
    thread.Start();
}

foreach(Thread thread in StudentList)
{
    thread.Join();
}

Console.WriteLine("Registration Completed Total Registered students: " 
    + course.GetRegisteredStudentCount());*/

/*ThreadExample threadExample = new ThreadExample();

Thread thread1 = new Thread(()=>threadExample.AddBox(1));
Thread thread2 = new Thread(() => threadExample.AddBox(2));
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();
Console.WriteLine("Completed");*/
/*Thread thread1 = new Thread(ThreadFun);
Thread thread2 = new Thread(ThreadFun);
Thread thread3 = new Thread(ThreadFun);
Thread thread4 = new Thread(ThreadFun);



thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();

thread1.Join();
thread2.Join();

Console.WriteLine("Threads completed execution");
 void ThreadFun()
{
    for(int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId +" is working "+ i);
        Console.WriteLine();
        Thread.Sleep(1000);
    }
}*/
