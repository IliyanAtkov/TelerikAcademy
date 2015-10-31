// Write a program that reads a year from the console and checks whether it is a leap.
// Use DateTime.


using System;



class LeapYear
{
    static void leap()
    {
        Console.Write("Enter year that you wanna check if it is a leap year: ");
        int year = int.Parse(Console.ReadLine());
        bool result = DateTime.IsLeapYear(year);
        Console.WriteLine("Is the year Leap: {0}", result);
    }
    static void Main()
    {
        leap();
    }
}

