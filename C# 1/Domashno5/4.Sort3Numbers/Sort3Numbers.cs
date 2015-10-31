/* Sort 3 real values in descending order using nested if statements. */

using System;

class Sort3Numbers
{
    static void Main()
    {
        // SOLUTION 1 - using an Array, For Loop and Foreach
        int[] myArr = new int[3]; // Initialize an array

        for (int index = 0; index < 3; index++)
        {
            Console.Write("number {0} = ", index + 1);
            myArr[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArr); // Sorting array in ascending order
        Array.Reverse(myArr); // Reverse an array to become sorted in descending order

        // Print the numbers in descending order
        Console.WriteLine("Given numbers in descending order are: ");
        foreach (var item in myArr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}