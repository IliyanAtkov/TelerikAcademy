//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        
        Console.Write("Enter number: ");
        int dec = int.Parse(Console.ReadLine());
        List<string> arrBin = new List<string>();
        ConvertDecimalToHex(dec, arrBin);
        PrintList(arrBin);
        Console.WriteLine();
    }
    static List<string> ConvertDecimalToHex(int num, List<string> arrB)
    {
        if (num == 0)
        {
            arrB.Add(Convert.ToString(0));
            return arrB;
        }
        if (num == 16)
        {
            arrB.Add(Convert.ToString(0));
            arrB.Add(Convert.ToString(1));
            return arrB;
        }
        if (num < 16)
        {
            arrB.Add(Convert.ToString(num % 16));
            return arrB;
        }

        if (num % 16 == 10)
        {
            arrB.Add("A");
        }
        if (num % 16 == 11)
        {
            arrB.Add("B");
        }
        if (num % 16 == 12)
        {
            arrB.Add("C");
        }
        if (num % 16 == 13)
        {
            arrB.Add("D");
        }
        if (num % 16 == 14)
        {
            arrB.Add("E");
        }
        if (num % 16 == 15)
        {
            arrB.Add("F");
        }
        if (num % 16 < 10)
        {
            arrB.Add(Convert.ToString(num % 16));
        }
        num /= 16;
        return ConvertDecimalToHex(num, arrB);
    }
    static void PrintList(List<string> arrBinar)
    {
        arrBinar.Reverse();
        foreach (var item in arrBinar)
        {
            Console.Write(item);
        }
    }
}