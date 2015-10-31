// Write a program that reads 3 integer numbers from the console and prints their sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class AddAndPrintThreeNumbersOnConsole
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers");
        Console.Write("The first one: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("The second one: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("The third one: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the tree numbers is {0}", num1 + num2 + num3);
    }
}

