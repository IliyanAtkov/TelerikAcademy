// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class NSum
{
    static void Main()
    {
        int sum = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            int input = int.Parse(Console.ReadLine());

            sum += input;
            
        }
        Console.WriteLine("The Sum is " + sum);

    }
}