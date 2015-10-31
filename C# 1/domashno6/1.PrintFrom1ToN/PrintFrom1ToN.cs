// Write a program that prints all the numbers from 1 to N.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int enterNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= enterNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
