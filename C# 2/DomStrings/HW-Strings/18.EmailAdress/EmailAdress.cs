// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should
// be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class EmailAdress
{
    static void EmailExtraxt()
    {
        string text = " this is some text with emails supere@abv.bg, or xa_xa_XA@gmail.com or ziaax@debele.com  or wrong email as aALD.@a.bv.bg";
        string pattern = @"[A-Za-z\d_]+?@[A-Z-a-z\d_]+\.[a-zA-z]+";
        Match match = Regex.Match(text, pattern);
        while (match.Success)
        {
            Console.WriteLine(match);
            match = match.NextMatch();
        }
    }
    static void Main()
    {
        EmailExtraxt();

    }

}

