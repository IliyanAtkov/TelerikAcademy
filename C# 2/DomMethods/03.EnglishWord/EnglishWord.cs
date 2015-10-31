// Write a method that returns the last digit of given integer as an English word.
// Examples: 512  "two", 1024  "four", 12309  "nine".


using System;


class EnglishWord
{
    static void LastDigitName(int enteredNumber)
    {
        int lastDigit = Math.Abs(enteredNumber % 10);
        switch (lastDigit)
        {
            case 0: Console.WriteLine("{0}->zero", enteredNumber); break;
            case 1: Console.WriteLine("{0}->one", enteredNumber); break;
            case 2: Console.WriteLine("{0}->two", enteredNumber); break;
            case 3: Console.WriteLine("{0}->three", enteredNumber); break;
            case 4: Console.WriteLine("{0}->four", enteredNumber); break;
            case 5: Console.WriteLine("{0}->five", enteredNumber); break;
            case 6: Console.WriteLine("{0}->six", enteredNumber); break;
            case 7: Console.WriteLine("{0}->seven", enteredNumber); break;
            case 8: Console.WriteLine("{0}->eight", enteredNumber); break;
            case 9: Console.WriteLine("{0}->nine", enteredNumber); break;
        }
    }
    static void Main()
    {
        Console.Write("Enter integer: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        LastDigitName(enteredNumber);
    }
}
