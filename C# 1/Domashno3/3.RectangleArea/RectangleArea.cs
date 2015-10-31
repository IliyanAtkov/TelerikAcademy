// Write an expression that calculates rectangle’s area by given width and height.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width of the rectangle: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("The area is {0}", area);


    }
}

