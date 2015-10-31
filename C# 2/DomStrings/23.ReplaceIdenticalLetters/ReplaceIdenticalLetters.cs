// Write a program that reads a string from the console and replaces all
// series of consecutive identical letters with a single one.
// Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ReplaceIdenticalLetters
{
    static void ReplaceLettersIdentical()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != sb[sb.Length - 1]) 
            {
                sb.Append(input[i]);
            }
            
        }
        Console.WriteLine(sb.ToString());
    }
    static void Main()
    {
        ReplaceLettersIdentical();
    }
}

