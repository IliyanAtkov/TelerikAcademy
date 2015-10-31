// Write a method that return the maximal element
// in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;

class SortMethodInOrder
{
    static void Print(int[] array, int maxElement)
    {
        Console.WriteLine("The biggest integer number is {0}", maxElement);
        Console.WriteLine();
    }
    static void MaximumElement(int[] array, int index)
    {
        int maxElement = int.MinValue;
        if (index < array.Length)
        {
            for (int i = index; i < array.Length; i++)
            {
                int temp = array[i];
                if (temp > maxElement)
                {
                    maxElement = temp;
                }
            }
            Print(array, maxElement);
        }
        else
        {
            Console.WriteLine("Index was outside the boundary of array");
            Console.WriteLine();
        }

    }
    static void AscendingOrder(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine("In Ascending order: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();
        
 
    }
    static void DescendingOrder(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine("In Descending order: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        
        
    }

    static void Main()
    {
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());

        int[] array = { 4, 3, 634, 23, 53, 7, 32, 
                          5, 7, 1, 5, 3, 423, 53,
                          86, 34, 8, 12, 789, 212,
                          756, 34, 645, 144, 987,
                          34, 3, 45, 865, 32, 21,
                          43, 32, 76, 645, 34, 98,
                          34, 13, 18, 324, 433, 12};

        MaximumElement(array, index);
        AscendingOrder(array);
        DescendingOrder(array);
        
    }
}

