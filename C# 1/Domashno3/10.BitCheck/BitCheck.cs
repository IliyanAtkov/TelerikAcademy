// Write a boolean expression that returns if the bit at position p (counting from 0)
// in a given integer number v has value of 1. Example: v=5; p=1  false.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BitCheck
{
    static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("What position of the number in binary do you want: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        Console.WriteLine(bit);

    }
}

