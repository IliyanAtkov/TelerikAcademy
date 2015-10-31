//  Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class AsciiTable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

