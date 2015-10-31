// Write a program, that reads from the console an array of N integers
//and an integer K, sorts the array and using the method Array.BinSearch()
//finds the largest number in the array which is ≤ K. 


using System;


class FindTheLargesSumInArray
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array: ");
        int[] array = new int[n];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            
        }
        FindTheLargestNumber(array, k);
        
    }
    static void FindTheLargestNumber(int[] array, int k)
    {
        Array.Sort(array);
        int index = 0;
        if (array[0] > k)
        {
            Console.WriteLine("No number that is less than or equal to k.");
        }
        else
        {
            int IndexElement = Array.BinarySearch(array, k);
            if (IndexElement >= 0)
            {
                index = array[IndexElement];
            }
            else
            {
                index = array[~IndexElement - 1];
            }
            Console.WriteLine(index);
        }
    }
}

