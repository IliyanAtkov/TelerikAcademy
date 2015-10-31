// Write a program that converts a string to a sequence of C# Unicode
// character literals. Use format strings. Sample input:
// Hi
//Expected output:
//\u0048\u0069\u0021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ConvertStringToUnicode
{
    static void ConvertToUniCode()
    {
        string str = "Hi!";
    StringBuilder sb = new StringBuilder();
    foreach (char c in str)
    {
        sb.Append("\\u");
        sb.Append(String.Format("{0:x4}", (int)c));
    }
    Console.WriteLine(sb.ToString());
    }

    static void Main()
    {      
        ConvertToUniCode();
    }
}

