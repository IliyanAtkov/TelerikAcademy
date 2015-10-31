// We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ModifyN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number: ");

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Position: ");

        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Digit that you want (1 or 0)");

        int v = int.Parse(Console.ReadLine());

        int digit = (((1 << p) & n) >> p);

        if (digit == v) Console.WriteLine("The digit is already set at {0}", v);

        else if (digit == 0) n = (n | (1 << p));

        else if (digit == 1) n = ((~(1 << p) & n));

        Console.WriteLine(n);
    }
}

