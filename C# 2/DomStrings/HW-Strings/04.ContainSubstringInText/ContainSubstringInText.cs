//Write a program that finds how many times a substring is contained in a given
// text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day. 
//We will move out of it in 5 days.
// 	The result is: 9.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


class ContainSubstringInText
{
    static void SubstringContain()
    {
        string pattern = "in";
        string text;
        using (StreamReader str = new StreamReader("text.txt"))
        {
            text = str.ReadToEnd();
        }
        MatchCollection match = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        int count = 0;
        foreach (var m in match)
        {
            count++;
        }
        Console.WriteLine("The result is: " + count);
    }

    static void Main()
    {
        SubstringContain();
    }
}

