// Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        int biggestNum = 0;

        if (firstNum == secondNum && secondNum == thirdNum)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else
        {
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                biggestNum = firstNum;
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                biggestNum = secondNum;
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                biggestNum = thirdNum;
            }

            Console.WriteLine("The biggest number is: {0}", biggestNum);
        }
    }
}