// Write a program that creates an array containing all letters from the alphabet (A-Z). 
// Read a word from the console and print the index of each of its letters in the array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AllLettersFromAlphaBet
{
    static void Main()
    {
        Console.Write("Enter the letter from the alphabet and I will tell you her position in the alphabet: ");
        string enteredLetter = Console.ReadLine();
        enteredLetter.ToLower();
        foreach (char letter in enteredLetter)
        {
            
            Console.WriteLine("The position is: {0}", letter + 1 - 'a');
        }
    }
}

