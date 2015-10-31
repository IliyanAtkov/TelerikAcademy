// Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertHexToDec
{
    static void Main()
    {
        Console.WriteLine("Type Hexadecimal Number: ");
        string hexNum = Console.ReadLine();
        Console.WriteLine(HexToDec(hexNum));

    }
    static int StringToInt(string s, int i)
    {
        if (s[i] >= 'A') return s[i] - 'A' + 10;
        else return s[i] - '0';
    }

    static int HexToDec(string hex)
    {
        int dec = 0;

        for (int i = hex.Length - 1, p = 1; i >= 0; i--, p *= 16)
            dec += StringToInt(hex, i) * p;

        return dec;
    }
}
