// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
 //Example: 3, -2, 1, 1, 8  1+1-2=0. 

using System;

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 variables type integer:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("Subset that have zero sum is: ");

        if ((a + b) == 0) // a
        {
            Console.WriteLine("a + b = |{0}| + |{1}|", a, b);
        }
        if ((a + c) == 0)
        {
            Console.WriteLine("a + c = |{0}| + |{1}|", a, c);
        }
        if ((a + d) == 0)
        {
            Console.WriteLine("a + d = |{0}| + |{1}|", a, d);
        }
        if ((a + e) == 0)
        {
            Console.WriteLine("a + e = |{0}| + |{1}|", a, e);
        }
        if ((b + c) == 0) // b
        {
            Console.WriteLine("b + c = |{0}| + |{1}|", b, c);
        }
        if ((b + d) == 0)
        {
            Console.WriteLine("b + d = |{0}| + |{1}|", b, d);
        }
        if ((b + e) == 0)
        {
            Console.WriteLine("b + e = |{0}| + |{1}|", b, e);
        }
        if ((c + d) == 0) // c
        {
            Console.WriteLine("c + d = |{0}| + |{1}|", c, d);
        }
        if ((c + e) == 0)
        {
            Console.WriteLine("c + e = |{0}| + |{1}|", c, e);
        }
        if ((d + e) == 0) // d
        {
            Console.WriteLine("d + e = |{0}| + |{1}|", d, e);
        }
        if ((a + b + c) == 0)
        {
            Console.WriteLine("a + b + c = |{0}| + |{1}| + |{2}|", a, b, c);
        }
        if ((a + b + d) == 0)
        {
            Console.WriteLine("a + b + d = |{0}| + |{1}| + |{2}|", a, b, d);
        }
        if ((a + b + e) == 0)
        {
            Console.WriteLine("a + b + e = |{0}| + |{1}| + |{2}|", a, b, e);
        }
        if ((b + c + d) == 0)
        {
            Console.WriteLine("b + c + d = |{0}| + |{1}| + |{2}|", b, c, d);
        }
        if ((b + c + e) == 0)
        {
            Console.WriteLine("b + c + e = |{0}| + |{1}| + |{2}|", b, c, e);
        }
        if ((b + d + e) == 0)
        {
            Console.WriteLine("b + d + e = |{0}| + |{1}| + |{2}|", b, d, e);
        }
        if ((c + d + e) == 0)
        {
            Console.WriteLine("c + d + e = |{0}| + |{1}| + |{2}|", c, d, e);
        }
        if ((c + a + d) == 0)
        {
            Console.WriteLine("c + a + d = |{0}| + |{1}| + |{2}|", c, a, d);
        }
        if ((c + a + e) == 0)
        {
            Console.WriteLine("c + a + e = |{0}| + |{1}| + |{2}|", c, a, e);
        }
        if ((d + a + e) == 0)
        {
            Console.WriteLine("d + a + e = |{0}| + |{1}| + |{2}|", d, a, e);
        }
        if ((a + b + c + d) == 0)
        {
            Console.WriteLine("a + b + c + d = |{0}| + |{1}| + |{2}| + |{3}|", a, b, c, d);
        }
        if ((a + c + d + e) == 0)
        {
            Console.WriteLine("a + c + d + e = |{0}| + |{1}| + |{2}| + |{3}|", a, c, d, e);
        }
        if ((a + b + d + e) == 0)
        {
            Console.WriteLine("a + b + d + e = |{0}| + |{1}| + |{2}| + |{3}|", a, b, d, e);
        }
        if ((b + c + d + e) == 0)
        {
            Console.WriteLine("b + c + d + e = |{0}| + |{1}| + |{2}| + |{3}|", b, c, d, e);
        }
        if ((b + a + d + e) == 0)
        {
            Console.WriteLine("b + a + d + e = |{0}| + |{1}| + |{2}| + |{3}|", b, a, d, e);
        }
        if ((a + b + c + d + e) == 0)
        {
            Console.WriteLine("a + b + c + d + e = |{0}| + |{1}| + |{2}| + |{3}| + |{4}|", a, b, c, d, e);
        }
    }
}