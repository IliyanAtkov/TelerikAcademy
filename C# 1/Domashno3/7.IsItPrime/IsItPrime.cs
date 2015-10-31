//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class IsItPrime
{
    static void Main(string[] args)
    {
        Console.Write("Enter number <= 100: ");
        int n = int.Parse(Console.ReadLine());      
        bool prime = (n <= 100 && n % 2 != 0);
        Console.WriteLine(prime ? "The number is prime!" : "The number is not prime");
    }
}

