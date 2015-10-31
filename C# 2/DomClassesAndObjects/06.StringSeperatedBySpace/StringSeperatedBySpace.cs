// You are given a sequence of positive integer values written into a string, 
// separated by spaces. Write a function that reads these values from 
// given string and calculates their sum. Example:
// string = "43 68 9 23 318"  result = 461


using System;


class StringSeperatedBySpace
{
    static void CalculateSumOfSeperatedString(string input)
    {
        string[] removeSpace = input.Split(' ');
        int actualSum = 0;
        for (int i = 0; i < removeSpace.Length; i++)
        {
            actualSum += int.Parse(removeSpace[i]);
        }
        Console.WriteLine(actualSum);
    }
    static void Main()
    {
        Console.Write("Enter sequence of positive integer values seperated by space: ");
        string input = Console.ReadLine();
        CalculateSumOfSeperatedString(input);
    }
}

