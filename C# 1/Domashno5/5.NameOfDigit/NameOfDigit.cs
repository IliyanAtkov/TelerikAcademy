//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a
 //switch statement.

using System;

class NameOfDigit
{
    static void Main()
    {
        Console.Write("Please enter some digit: ");
        byte input = byte.Parse(Console.ReadLine());

        switch (input)
        {
            case 0: Console.WriteLine("The name of that digit is Zero");
                break;
            case 1: Console.WriteLine("The name of that digit is One");
                break;
            case 2: Console.WriteLine("The name of that digit is Two");
                break;
            case 3: Console.WriteLine("The name of that digit is Three");
                break;
            case 4: Console.WriteLine("The name of that digit is Four");
                break;
            case 5: Console.WriteLine("The name of that digit is Five");
                break;
            case 6: Console.WriteLine("The name of that digit is Six");
                break;
            case 7: Console.WriteLine("The name of that digit is Seven");
                break;
            case 8: Console.WriteLine("The name of that digit is Eight");
                break;
            case 9: Console.WriteLine("The name of that digit is Nine");
                break;
            default: Console.WriteLine("Incorrect input!");
                break;
        }
    }
}