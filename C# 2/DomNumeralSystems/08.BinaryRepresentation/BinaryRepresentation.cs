

using System;

class BinaryRepresentation
{
    static string GetBinary(short s)
        // Check every bit from 0 to 15 without to care
        // about extra code on binary representation of negative numbers 
    {
        string b = String.Empty;

        for (int i = 0; i < 16; i++) b = (s >> i & 1) + b;

        return b;
    }

    static void Main()
    {
        Console.WriteLine(GetBinary(253));
    }
}