// Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter trapezoid side A: ");
        float a = int.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid side B: ");
        float b = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        float h = int.Parse(Console.ReadLine());
        float area = ((a + b) / 2) * h;
        Console.WriteLine("The Area of trapezoid is {0}", area);
        
    }

}

