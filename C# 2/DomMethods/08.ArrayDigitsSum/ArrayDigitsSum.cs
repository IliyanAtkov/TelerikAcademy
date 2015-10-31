// Write a method that adds two positive integer numbers represented
// as arrays of digits (each array element arr[i] contains a digit; the
// last digit is kept in arr[0]). Each of the numbers that will be added
// could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class Program
{
    static void PrintNumber(List<int> array)
    {
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static List<int> Add(byte[] a, byte[] b)
    {
        List<int> result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;
        for (int i = 0; i < result.Capacity; i++)
        {
            int current = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;

            carry = current / 10;
            result.Add(current % 10);
        }
        if (carry == 1)
        {
            result.Add(1);
        }
        return result;
        
    }

    static void Main()
    {
        byte[] a = { 3, 4, 5 };                  
        byte[] b = {2,3,8,4,6};
                       
        List<int> result = Add(a, b);
        PrintNumber(result);
        
    }
    
}