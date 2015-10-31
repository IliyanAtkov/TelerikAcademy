// Write a program that concatenates two text files into another text file.


using System;
using System.IO;

class ConcatenatesTwoTextFilesIntoThird
{
    static void Concatenation()
    {
        StreamReader textOne = new StreamReader("text1.txt"); // .txt files are in debug folder
        StreamReader textTwo = new StreamReader("text2.txt");
        
        using (textOne)
        {
            StreamWriter write = new StreamWriter("twoTextInOne.txt");
            using (write)
            {
                string text;
                text = textOne.ReadToEnd();
                write.WriteLine(text);
            }
            
        }
        using (textTwo)
        {
            StreamWriter write = new StreamWriter("twoTextInOne.txt", true);
            using (write)
            {

                string text;
                text = textTwo.ReadToEnd();
                write.WriteLine(text);
            }
        }
    }
    static void Main()
    {
        Concatenation();
    }
}