using System;
using System.Collections.Generic;

class MinAndMaxNumber
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of N integer numbers
        //and returns the minimal and maximal of them.

        Console.Write("Insert how many numbers you want to write: ");
        int n = int.Parse(Console.ReadLine());

        List<int> numberHolder = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numberHolder.Add(number);
        }
        int maxNum = int.MinValue;
        int minNum = int.MaxValue;
        foreach (int item in numberHolder)
        {
            if (item > maxNum)
            {
                maxNum = item;
            }
            if (item < minNum)
            {
                minNum = item;
            }
        }
        Console.WriteLine("The biggest number is {0}", maxNum);
        Console.WriteLine("The smallest2 number is {0}", minNum);
    }
}