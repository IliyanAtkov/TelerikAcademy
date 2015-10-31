// Modify the solution of the previous problem to
// replace only whole words (not substrings).


using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        ReplaceAllOccurencesOfWholeWorldOnly();
    }

    private static void ReplaceAllOccurencesOfWholeWorldOnly()
    {
        using (StreamReader input = new StreamReader("text.txt"))
        using (StreamWriter output = new StreamWriter("result.txt"))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
    }
}
