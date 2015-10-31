using System;
using System.Numerics;
using System.Collections.Generic;


class SequenceOfFibonnaci
{
    static void Main()
    {
        //Write a program that reads a number N and calculates the sum of the first N members
        //of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

        Console.Write("Insert the number of members which you want to sum up: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger sum = 0;
        List<BigInteger> listOfNumbers = new List<BigInteger>();
        listOfNumbers.Add(a);
        listOfNumbers.Add(b);

        for (int i = 0; i < n; i++)
        {
            a = a + b;
            b = b + a;
            listOfNumbers.Add(a);
            listOfNumbers.Add(b);
        }
        for (int i = 0; i < n; i++)
        {
            sum += listOfNumbers[i];

        }
        Console.WriteLine("The sum of the first {0} members of the Fibonacci sequance is: {1}", n, sum);
    }
}