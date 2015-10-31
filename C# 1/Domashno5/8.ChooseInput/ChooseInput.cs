 //Write a program that, depending on the user's choice inputs int, double or string variable.
 //If the variable is integer or double, increases it with 1. If the variable is string,
 //appends "*" at its end. The program must show the value of that variable as a console output.
 //Use switch statement.

using System;

class ChooseInput
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Please choose type of the variable");
        Console.BackgroundColor = ConsoleColor.Black;

        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n For type \"Integer\" enter 1 \n For type \"Double\" enter 2 \n For type \"String\" enter 3 ");
        Console.BackgroundColor = ConsoleColor.Black;

        Console.Write("\nYour choosen option is: ");
        byte option = byte.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Please input your \"Integer\" type: ");
                int optionInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Your Integer type + 1 is: {0}", optionInt + 1);
                break;
            case 2:
                Console.Write("Please input your \"Double\" type: ");
                double optionDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Your Double type + 1 is: {0}", optionDouble + 1);
                break;
            case 3:
                Console.Write("Please input your \"String\" type: ");
                string optionString = Console.ReadLine();
                Console.WriteLine("Your String type + \"*\" is: {0}", optionString + "*");
                break;
            default:
                Console.WriteLine("Invalid Input! You can use ONLY option numbers 1, 2 or 3 \n Please try again!");
                break;
        }
    }
}