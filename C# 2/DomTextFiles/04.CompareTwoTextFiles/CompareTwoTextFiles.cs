// Write a program that compares two text files line by line
// and prints the number of lines that are the same and the number
// of lines that are different. Assume the files have equal number of lines.


using System;
using System.IO;

class CompareTwoTextFiles
{
    static void EqualLines()
    {
        StreamReader textOne = new StreamReader("text1.txt");
        StreamReader textTwo = new StreamReader("text2.txt");
        int counter = 0;
        int same = 0;
        
        using(textOne)
	    {

            using (textTwo)
            {
                string firstText;
                string secondText;
                while ((firstText = textOne.ReadLine()) != null)
                {
                    secondText = textTwo.ReadLine();
                    counter++;
                    if (firstText == secondText)
                    {
                        same++;
                    }
                }
            }   
        }
        int result = counter - same; // Check how many lines are not the same
        Console.WriteLine("The same lines are: {0}", same);
        Console.WriteLine("The different lines are: {0}", result);
           
               
        
	    
        
    }
    static void Main()
    {
        EqualLines();
    }
}
