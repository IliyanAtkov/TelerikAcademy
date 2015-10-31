// Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOf5Nums
{
    static void Main()
    {
        // SOLUTION 1 - using an Array and For Loop
        int[] myArr = new int[5]; // Initialize an array

        for (int index = 0; index < 5; index++)
        {
            Console.Write("number {0} = ", index + 1);
            myArr[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArr); // Sorting array in ascending order
        Console.WriteLine("The greatest of given 5 variables is: {0}", myArr[4]);

    }
}