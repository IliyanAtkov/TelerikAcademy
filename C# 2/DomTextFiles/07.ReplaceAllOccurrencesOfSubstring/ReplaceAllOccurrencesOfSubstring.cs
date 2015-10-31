// Write a program that replaces all occurrences of the substring
// "start" with the substring "finish" in a text file. Ensure it will
// work with large files (e.g. 100 MB).


using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        ReplaceAllOccurancesofSubstring();        
    }

    private static void ReplaceAllOccurancesofSubstring()
    {
        using (StreamReader input = new StreamReader("text.txt"))
        using (StreamWriter output = new StreamWriter("result.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(line.Replace("start", "finish"));
    }
}