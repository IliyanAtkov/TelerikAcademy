// Write a program that reads the radius r of a circle and prints its perimeter and area.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class RadiosOfTheCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of a circle: ");
        int r = int.Parse(Console.ReadLine());
        float pi = 3.14159f;
        float perimeter = (2 * pi) * r;
        float area = pi * (r * r);
        Console.WriteLine("The perimeter is {0:0.00},  and Area is {1:0.00}", perimeter, area);
    }
}

