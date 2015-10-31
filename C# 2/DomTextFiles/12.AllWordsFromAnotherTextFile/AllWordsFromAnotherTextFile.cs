// Write a program that removes from a text file all words 
// listed in given another text file. Handle all possible exceptions in your methods.


using System;
using System.IO;
using System.Text.RegularExpressions;

class AllWordsFromAnotherTextFile
{
    static void RemoveWords()
    {
        try
        {
            string allLines = String.Join(" ", File.ReadAllLines("words.txt"));
            string[] allWords = allLines.Split(' ');
            StreamReader start = new StreamReader("text.txt");
            using (start)
            {
                StreamWriter finish = new StreamWriter("finish.txt", false);
                string line = start.ReadLine();
                using (finish)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b";
                            line = Regex.Replace(line, word, "");
                        }

                        finish.WriteLine(line);

                        line = start.ReadLine();
                    }
                }
            }
            Console.WriteLine("Whole words only have been replaced!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path contains a directory that cannot be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
            

        
    }
    static void Main()
    {
        RemoveWords();
    }
}

