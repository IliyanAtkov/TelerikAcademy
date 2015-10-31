// Sorting an array means to arrange its elements in increasing order.
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position,etc.


using System;


class SortArrayWithSellectionSortAlgorithm
{
    static void SelectionSort(int[] numbers)
    {
        int swap = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int index = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[index])
                {
                    index = j;
                }
            }

            swap = numbers[i];
            numbers[i] = numbers[index];
            numbers[index] = swap;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("What size of the array do you want: ");
        int sizeOfArray = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array");
        int[] theArray = new int[sizeOfArray];
        for (int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = int.Parse(Console.ReadLine());
        }
        SelectionSort(theArray);

        // Printing Sorted array
        for (int i = 0; i < theArray.Length; i++)
        {
            Console.Write(" {0},", theArray[i]);
        }
        Console.WriteLine();
    }
}

