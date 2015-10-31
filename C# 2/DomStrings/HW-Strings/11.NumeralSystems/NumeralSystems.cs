// Write a program that reads a number and prints it as a decimal number,
// hexadecimal number, percentage and in scientific notation. Format
// the output aligned right in 15 symbols.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class NumeralSystems
{
    static void PrintNumberRepresentation(int number)
    {
        Console.WriteLine("Decimal : {0,15:d}", number);
        Console.WriteLine("Hexadecimal : {0,15:X4}", number);
        Console.WriteLine("Percent : {0,15:p}", number);
        Console.WriteLine("Scientific : {0,15:e}", number);
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        PrintNumberRepresentation(number);
    }
}

