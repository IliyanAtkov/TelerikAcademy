//Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the division
// by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TwoNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = number1; i <= number2; i++)
        {
            if (i % 5 == 0) //checking if the current number can be divided by 5 without a remainder
            {
                p = p + 1;
            }
        }
        Console.WriteLine(p);

    }
}