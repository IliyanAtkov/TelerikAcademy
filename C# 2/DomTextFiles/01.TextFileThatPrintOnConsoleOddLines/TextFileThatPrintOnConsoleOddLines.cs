// Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;
class TextFile
{
    static void ReadTextFile()
    {
        int row = 1;
        using (StreamReader str = new StreamReader("Text.txt"))
        {
            for (string l; (l = str.ReadLine()) != null; row++)
            {
                if (row % 2 == 1)
                {
                    Console.WriteLine(l);
                }
            }
        }
    }
    static void Main()
    {
        ReadTextFile();
    }
}

