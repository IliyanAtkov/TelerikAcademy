// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.
 

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void DeleteOnlyOddLines()
    {
        int row = 1;
        StringBuilder sb = new StringBuilder();
        using (StreamReader str = new StreamReader("Text.txt"))
        {
                for (string l; (l = str.ReadLine()) != null; row++)
                {

                    if (row % 2 == 0)
                    {
                        sb.AppendLine(l);
                        
                    }
                }
        }
        using (StreamWriter write = new StreamWriter("Text.txt"))
        {
            write.WriteLine(sb);
        }
    }
    static void Main()
    {
        DeleteOnlyOddLines();
    }
}

