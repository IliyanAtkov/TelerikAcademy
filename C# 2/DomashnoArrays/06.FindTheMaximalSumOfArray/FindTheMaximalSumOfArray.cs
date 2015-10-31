//Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.


using System;


class FindTheMaximalSumOfArray
{
    static void Main(string[] args)
    {
        int sum = 0;
        int max = int.MinValue;
        int pos = 0;

        Console.Write("Enter N number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K number: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the Array");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        for (int i = 0; i <= n - k; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
            }
            if (sum > max)
            {
                max = sum;
                pos = i;
            }
            sum = 0;
        }
        for (int i = pos; i < pos + k; i++)
        {
            Console.Write(array[i] + " ");
        }       
    }
}

