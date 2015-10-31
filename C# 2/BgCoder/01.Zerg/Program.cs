using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] message = {"Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh"};
        ulong decimalRepresentation = 0;
        for (int i = 0; i < input.Length; i += 4)
        {
            string digitIn15 = input.Substring(i, 4);
            int decimalNumber = Array.IndexOf(message, digitIn15);
            decimalRepresentation *= 15;
            decimalRepresentation += (ulong)decimalNumber;
        }
        Console.WriteLine(decimalRepresentation);
    }
}
