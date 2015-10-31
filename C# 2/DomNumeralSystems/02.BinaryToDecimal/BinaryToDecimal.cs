// Write a program to convert binary numbers to their decimal representation.


using System;



class BinaryToDecimal
{
static void Main()
{
    ConvertBinaryToDecimal();
}

private static void ConvertBinaryToDecimal()
{
    Console.Write("Enter a binary number: ");
    string binary = Convert.ToString(Console.ReadLine());
    int decimalNumber = 0;
    for (int i = 0; i < binary.Length; i++)
    {

        if (binary[binary.Length - i - 1] == '0')
        {
            continue;
        }
        decimalNumber += (int)Math.Pow(2, i);

    }
    Console.WriteLine("The decimal representation of {0} is: {1}", binary, decimalNumber);
}
}

