// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.
using System;


class HowManyTimeNumberAppearsInArray
{
    static void WhatChoiseUserMade(string userChoise)
    {
        int repeat = 0;
        int find = 0;
        userChoise = userChoise.ToLower();
        while (userChoise != "yes" && userChoise != "no")
        {
            Console.WriteLine("Enter right answer yes or no !!!");
            userChoise = Console.ReadLine();
            userChoise = userChoise.ToLower();

        }
        if (userChoise == "yes")
        {
            Console.WriteLine();
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter integer array: ");
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.Write("What number you want to find in array: ");
            find = int.Parse(Console.ReadLine());
            repeat = FindHowManyTimesNumAppear(array, find);
        }
        else if (userChoise == "no")
        {
            int[] array = { 3, 4, 1, 2, 15, 16, 32, 5, 6, 7, 8, 99, 3, 6, 6, 1, 5, 8, 9, 15, 13, 23, 12, 11, 120, 25, 26, 27 };
            Console.WriteLine();
            Console.Write("What number you want to find in array: ");
            find = int.Parse(Console.ReadLine());
            repeat = FindHowManyTimesNumAppear(array, find);

        }
        Console.WriteLine("{0} repeat {1} times", find, repeat);




    }
    static int FindHowManyTimesNumAppear(int[] array, int num)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Do you want already set array, or you want to enter the array?");
        Console.WriteLine("Enter \"yes\" if you want to enter the array, or Enter \"no\" if you don't want to enter it.");
        string userChoise = Console.ReadLine();
        WhatChoiseUserMade(userChoise);
    }
}
