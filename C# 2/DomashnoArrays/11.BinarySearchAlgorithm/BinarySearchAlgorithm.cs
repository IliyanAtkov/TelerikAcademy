// Write a program that finds the index of given element
// in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        Array.Sort(array);
        Console.Write("What number you want to find position: ");
        int result = Array.BinarySearch(array, int.Parse(Console.ReadLine()));
        if (result < 0)
        {
            Console.WriteLine("That number doesn't exist in this array");
        }
        else
        {
            Console.WriteLine("The index is: {0}", result);
        }
        
    }
}

