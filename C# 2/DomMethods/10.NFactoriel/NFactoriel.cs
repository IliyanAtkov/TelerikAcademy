// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented
// as array of digits by given integer number. 

using System;
using System.Numerics;

class NFactoriel
{
    

    private static void NFactorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.Write("{0} factorial = {1}", n, factorial);
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Whan n! do you want from 0-100, you can enter larger number if want, but if you enter too big number you will wait longer: ");
        int n = int.Parse(Console.ReadLine());
        NFactorial(n);

    }
}

