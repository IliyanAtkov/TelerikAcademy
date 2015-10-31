using System;

class CalucaltingSumXandN
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers N and X,
        //calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        Console.Write("Insert the number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert the number X: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double nFactoriel = 1;
        double poweredX;

        for (int i = 1; i <= n; i++)
        {
            poweredX = (int)Math.Pow(x, i);
            nFactoriel *= i;
            sum += nFactoriel / poweredX;
        }
        Console.WriteLine(sum);
    }
}