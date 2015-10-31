// Write a program that compares two char arrays lexicographically (letter by letter).


using System;


class CompareCharArraysLexicographically
{
    static void Main()
    {
        Console.Write("Please enter the first char element: ");
        string firstChar = Console.ReadLine();

        //convert from string to first char array and convert letter to upper
        char[] firstArray = firstChar.ToUpper().ToCharArray();
        Console.Write("Please enter the second char elements: ");
        string secondChar = Console.ReadLine();
        char[] secondArray = secondChar.ToUpper().ToCharArray();
        int minLenght = Math.Min(secondArray.Length, firstArray.Length);

        bool areCharsEqual = true;

        for (int i = 0; i < minLenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areCharsEqual = false;
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first char  is lexicografically before the second.");
                }
                else
                {
                    Console.WriteLine("The second char  is lexicografically before the first.");
                }
                break;
            }
        }
        if (firstArray.Length < secondArray.Length  &&  areCharsEqual == true)
        {
            Console.WriteLine("The first char is lexicografically before the second");
        }
        else if (firstArray.Length > secondArray.Length && areCharsEqual == true)
        {
            Console.WriteLine("The second char is lexicografically before the first");
        }
        else if (firstArray.Length == secondArray.Length && areCharsEqual == true)
        {
            Console.WriteLine("The chars are equal");
        }
    }
}

