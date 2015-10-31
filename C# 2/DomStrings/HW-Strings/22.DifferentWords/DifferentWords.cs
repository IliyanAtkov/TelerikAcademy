//  Write a program that reads a string from the console and lists all different 
// words in the string along with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DifferentWords
{
    static void WordsDifferent()
    {
        string text = "What do you want huh, I am talking to you do you understand me or not, i will kill you, are you understanding me what exactly i'm talking about, don't mess with the programmers or they will hack you.";
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string[] realText = text.Split(new char[] { ',', ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in realText)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] = dict[word] + 1;
            }
            else
            {
                dict.Add(word, 1);
            }
           
        }
        foreach (var item in dict)
        {
            Console.WriteLine("{0, -15} contains {1} times", item.Key, item.Value);
        }

    }
    static void Main()
    {
        WordsDifferent();
    }
}

