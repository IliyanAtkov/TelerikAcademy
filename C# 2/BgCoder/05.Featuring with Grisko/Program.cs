using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        char[] OopS = word.ToCharArray();
        int count = word.Length;
        Array.Sort(OopS);
        for (int i = 0; i < OopS.Length - 1; i++)
        {
            if (OopS[i] == OopS[i + 1])
            {
                count--;
            }  

        }
  
        BigInteger factorial = 1;

        for (int i = 1; i <= count; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

