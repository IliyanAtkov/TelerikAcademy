// Write an expression that extracts from a given integer i the value of a given bit number b. 
// Example: i=5; b=2  value=1.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class ExtractBit
{
    static void Main(string[] args)
    {

        Console.Write("Enter number i: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter position b: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int iAndMask = i & mask;
        if (iAndMask != 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
