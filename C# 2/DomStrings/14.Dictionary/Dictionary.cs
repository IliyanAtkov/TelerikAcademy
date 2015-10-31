// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.
// Sample dictionary:
// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Dictionary
{
    static void MakeDictionary()
    {
        string text = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";
        Console.WriteLine("Enter the word you want to find meaning: ");
        string enter = Console.ReadLine();
        string[] dictionaryWords = { ".NET", "CLR", "namespace" };
        string[] pattern = text.Split(new char[] { '\n' });
        for (int i = 0; i < pattern.Length; i++)
        {
            if (enter == dictionaryWords[i])
            {
                Console.WriteLine(pattern[i]);
            }
        }
    }
    static void Main()
    {
        MakeDictionary();
    }
}

