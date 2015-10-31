// Write a program that deletes from a text file all words that
// start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

class DeleteTest
{
    static void Main()
    {
        TestWordDelete();
    }

    private static void TestWordDelete()
    {
        StreamReader read = new StreamReader("text.txt");
        StreamWriter write = new StreamWriter("output.txt");
        string line = "";

        using (read)
        {
            using (write)
            {
                line = read.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                    write.WriteLine(line);
                    line = read.ReadLine();
                }
            }
        }
    }
}

