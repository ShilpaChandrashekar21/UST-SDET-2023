// See https://aka.ms/new-console-template for more information
using DSA;

class Program
{
    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        MergeSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
/*class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        InsertionSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}*/
/*class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        BubbleSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}*/
/*class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 6;

        int result = BinarySearch.Search(arr, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        int[] data = { 10, 25, 7, 42, 15, 30, 8, 50, 5 };

        int target = 42;
        int result = LinearSearch.Search(data, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        TBinaryTree binaryTree = new TBinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);
        binaryTree.Insert(7);

        binaryTree.InorderTraversal();
        binaryTree.PreorderTraversal();
        binaryTree.PostorderTraversal();
    }
}*/
/*class Program
{
    static void Main()
    {
        BinaryTreeExample<int> binaryTree = new BinaryTreeExample<int>();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);

        binaryTree.InorderTraversal();

        bool found = binaryTree.Search(15);
        Console.WriteLine("Search for 15: " + found);

        found = binaryTree.Search(7);
        Console.WriteLine("Search for 7: " + found);
    }
}*/
/*class Program
{
    static void Main()
    {
        LinkedListExample<int> linkedList = new LinkedListExample<int>();

        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);

        linkedList.RemoveNode(2);
        linkedList.RemoveNode(4); // Trying to remove a non-existent node

        linkedList.DisplayList();
    }
}*/

/*class Program
{
    static void Main()
    {
        QueueExample<int> queue = new QueueExample<int>(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue(); // Trying to dequeue from an empty queue

        queue.Enqueue(4);
        queue.Enqueue(5);
    }
}*/
/*class Program
{
    static void Main()
    {
        StackExample<int> stack = new StackExample<int>(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        var topItem = stack.Peek();
        Console.WriteLine($"Top item: {topItem}");

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop(); // Trying to pop from an empty stack

        stack.Push(4);
    }
}*/
