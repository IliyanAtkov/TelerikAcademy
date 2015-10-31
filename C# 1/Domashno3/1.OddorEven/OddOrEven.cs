// Write an expression that checks if given integer is odd or even.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class OddOrEven
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
     
    }
}

