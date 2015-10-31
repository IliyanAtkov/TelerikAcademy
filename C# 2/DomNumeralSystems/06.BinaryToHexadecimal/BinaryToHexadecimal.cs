// Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;

class BinaryToHexadecimal
{
    static string BinToHex(string bin)
    {
        
        string hexadecimal = "";
        int remainder = bin.Length % 4;
        if (remainder != 0)
        {
            bin = bin.PadLeft(((bin.Length / 4) + 1) * 4, '0');
        }
        for (int i = 0; i < bin.Length; i += 4)
        {
            string fourByFour = bin.Substring(i, 4);
            hexadecimal += string.Format("{0:X}", Convert.ToByte(fourByFour, 2));
        }
        return hexadecimal.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Enter binary number");
        string bin = Console.ReadLine();
        string hex = BinToHex(bin);
        Console.WriteLine(hex);
    }
}