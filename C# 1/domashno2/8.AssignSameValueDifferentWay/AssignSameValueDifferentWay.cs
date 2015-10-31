// Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AssignSameValueDifferentWay
{
    static void Main(string[] args)
    {
        string firstWay = "The \"use\" of quoations causes difficulties.";
        string secondWay = @"The ""use"" of quoations causes difficulties.";
        Console.Write("First way: ");
        Console.WriteLine(firstWay);
        Console.Write("Second way: ");
        Console.WriteLine(secondWay);
    }
}

