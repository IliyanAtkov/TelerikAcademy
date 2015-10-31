// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ReverseTheWords
{
    static void WordsReverse()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] words = text.Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
        string[] symbols = text.Split(words, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i] + symbols[i]);
        }
        
        Console.WriteLine(sb);
    }
    static void Main()
    {
        WordsReverse();
    }

}

