//using System;

//class UnsortedArray
//{
//    private int[] array;
//    private int size;
//    private int capacity;

//    public UnsortedArray(int capacity)
//    {
//        this.capacity = capacity;
//        array = new int[capacity];
//        size = 0;
//    }

//    // Insert an element into the array
//    public void Insert(int value)
//    {
//        if (size < capacity)
//        {
//            array[size] = value;
//            size++;
//        }
//        else
//        {
//            Console.WriteLine("Array is full. Cannot insert more elements.");
//        }
//    }

//    // Search for an element in the array
//    public int Search(int value)
//    {
//        for (int i = 0; i < size; i++)
//        {
//            if (array[i] == value)
//            {
//                return i; // Return the index of the found element
//            }
//        }
//        return -1; // Element not found
//    }

//    // Delete an element from the array
//    public void Delete(int value)
//    {
//        int index = Search(value);
//        if (index != -1)
//        {
//            // Shift elements to the left to remove the found element
//            for (int i = index; i < size - 1; i++)
//            {
//                array[i] = array[i + 1];
//            }
//            size--; // Decrease the size of the array
//            Console.WriteLine($"Element {value} deleted.");
//        }
//        else
//        {
//            Console.WriteLine($"Element {value} not found.");
//        }
//    }

//    // Display the array
//    public void Display()
//    {
//        Console.Write("Array: ");
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write(array[i] + " ");
//        }
//        Console.WriteLine();
//    }

//    static void Main(string[] args)
//    {
//        UnsortedArray unsortedArray = new UnsortedArray(10);

//        // Insert elements
//        unsortedArray.Insert(5);
//        unsortedArray.Insert(3);
//        unsortedArray.Insert(8);
//        unsortedArray.Insert(1);
//        unsortedArray.Display();

//        // Search for an element
//        int searchValue = 3;
//        int index = unsortedArray.Search(searchValue);
//        if (index != -1)
//        {
//            Console.WriteLine($"Element {searchValue} found at index {index}.");
//        }
//        else
//        {
//            Console.WriteLine($"Element {searchValue} not found.");
//        }

//        // Delete an element
//        unsortedArray.Delete(3);
//        unsortedArray.Display();

//        // Try to delete a non-existing element
//        unsortedArray.Delete(10);
//        unsortedArray.Display();
//    }
//}


using System;

class Program
{
    static void Main()
    {
        int n = 10; 
        int sum = SumFibonacci(n);
        Console.WriteLine($"Fibonachchi sonlarining {n}-gacha bo'lgan yig'indisi: {sum}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int SumFibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else
            return Fibonacci(n) + SumFibonacci(n - 1);
    }
}
