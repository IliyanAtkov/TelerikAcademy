// Write a program to convert decimal numbers to their binary representation.


using System;



class DecimalToBinary
{
    static void Main()
    {
        ConvertDecimalToBinary();
    }

    private static void ConvertDecimalToBinary()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(num, 2));
    }
}
