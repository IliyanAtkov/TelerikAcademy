// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ReverseString
{
    static void Reverse()
    {      
        Console.Write("Enter the string: ");
        string word = Console.ReadLine();
        char[] chr = word.ToCharArray();
        Array.Reverse(chr);
        Console.WriteLine(chr);
        
    }

    static void Main()
    {
        Reverse();
    }
}

