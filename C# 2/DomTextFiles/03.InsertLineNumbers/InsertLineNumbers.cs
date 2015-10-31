// Write a program that reads a text file and inserts
// line numbers in front of each of its lines. The result should
// be written to another text file.


using System;
using System.IO;

class InsertLineNumbers
{
    static void InsertNumbersInFrontOfText()
    {
        using (StreamReader str = new StreamReader("text.txt"))
        {
            using (StreamWriter write = new StreamWriter("newTextFile.txt"))
            {
                string text;
                int countRow = 1;

                while ((text = str.ReadLine()) != null)
                {
                    write.WriteLine("{0}.{1}", countRow, text);
                    countRow++;
                }
            }
        }
      
    }
    static void Main()
    {
        InsertNumbersInFrontOfText();
    }
}

