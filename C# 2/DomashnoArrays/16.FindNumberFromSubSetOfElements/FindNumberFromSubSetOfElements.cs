// *We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array
// that has a sum S. Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;


class FindNumberFromSubSetOfElements
{
    static void FindNumbers(int[] array, int s)
    {
        bool sum = false;
        int PowTwo = (int)Math.Pow(2, array.Length) - 1;
         for (int i = 1; i <= PowTwo; i++)
        {
            int total = 0;
            for (int j = 1; j <= array.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    total += array[j - 1];
                }
            }
            if (total == s)
            {
                sum = true;
            }
        }
         if (sum)
         {
             Console.WriteLine("Yes.");
         }
         else
         {
             Console.WriteLine("No.");
         }
        
    }

    static void Main()
    {
        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }

        FindNumbers(array, s);
        



    }
}


