// Write methods to calculate minimum, maximum, average,
// sum and product of given set of integer numbers. Use variable number of arguments.

using System;

class CalculateSum
{
    static void Print(int numberToPrint)
    {
        Console.WriteLine(numberToPrint);
    }

    static int MinimumNumber(int[] array)
    {
        Array.Sort(array);
        int number = array[0];
        Print(number);
        return number;
 
    }
    static int MaximumNumber(int[] array)
    {
        Array.Sort(array); // I made the sort in every method  because i want methods to be extendable
        int number = array[array.Length - 1];
        Print(number);
        return number;
    }
    static int AverageNumber(int[] array, int sumOfAllNumbers)
    {
        int averageSum = sumOfAllNumbers / array.Length;
        Print(averageSum);
        return averageSum;

    }
    static int FindProduct(int[] array)
    {
        int product = 1;
        foreach (var number in array)
        {
            product *= number;
        }
        Print(product);

        return product;
    }
    static void Main()
    {
        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Enter the array: ");
        int[] array = new int[size];
        int sumOfAllNumbers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sumOfAllNumbers += array[i];
        }
        Console.WriteLine("Minimum number");
        MinimumNumber(array);
        Console.WriteLine();
        Console.WriteLine("Maximum number");
        MaximumNumber(array);
        Console.WriteLine();
        Console.WriteLine("Average number");
        AverageNumber(array, sumOfAllNumbers);
        Console.WriteLine();
        Console.WriteLine("The product");
        FindProduct(array);
        Console.WriteLine();
        
    }
}

