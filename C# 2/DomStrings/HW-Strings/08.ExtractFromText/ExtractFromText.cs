// Write a program that extracts from a given text all sentences containing 
// given word.
//		Example: The word is "in". The text is:
// We are living in a yellow submarine. We don't have anything else.
// Inside the submarine is very tight. So we are drinking all the day.
// We will move out of it in 5 days.
// The expected result is:
// We are living in a yellow submarine.
// We will move out of it in 5 days.
// Consider that the sentences are separated by "."
// and the words – by non-letter symbols.


using System;
using System.Text.RegularExpressions;
using System.Text;

class ExtractFromText
{
    static void Extract()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string pattern = @"[^.]*\bin[^.]+[.]";
        StringBuilder sb = new StringBuilder();
        MatchCollection match = Regex.Matches(text, pattern);
        foreach (var m in match)
        {
            sb.Append(m);
        }
        Console.WriteLine(sb);
    }

    static void Main()
    {
        Extract();
    }
}

