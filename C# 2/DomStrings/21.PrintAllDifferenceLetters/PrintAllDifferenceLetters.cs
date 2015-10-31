// Write a program that reads a string from the console and prints all different
// letters in the string along with information how many times each letter is found. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PrintAllDifferenceLetters
{
    static string DifferenceLetters(string text)
    {
        int[] chars = new int[65536];
        for (int i = 0; i < text.Length; i++)
        {
            chars[text[i]]++;
        }
        StringBuilder lettersInformation = new StringBuilder();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 0 && char.IsLetter((char)i))
            {
                lettersInformation.Append(string.Format("Symbol {0} persist {1} counts.\n", (char)i, chars[i]));
            }
        }
        return lettersInformation.ToString();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        Console.WriteLine(DifferenceLetters(text));
    }
}
