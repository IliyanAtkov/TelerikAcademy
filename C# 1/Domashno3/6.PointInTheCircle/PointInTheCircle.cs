// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PointInTheCircle
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the x coordinate of the point x = ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Please enter the y coordinate of the point y = ");
        float y = float.Parse(Console.ReadLine());
        bool check = ((x * x) + (y * y)) <= 25;
        Console.WriteLine("\"The point is inside or on the circle\" is: {0}", check);
    }
    
}

