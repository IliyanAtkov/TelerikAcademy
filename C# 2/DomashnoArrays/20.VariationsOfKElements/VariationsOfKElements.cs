// Write a program that reads two numbers N and K and generates all
// the variations of K elements from the set [1..N].
// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;


class VariationsOfKElements
{
       
    static void AllTheVariations(int[] array, int index, int n)
    {

        if (array.Length == index)
        {

            PrintVariations(array);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                AllTheVariations(array, index + 1, n);
            }
        }

    }

    static void PrintVariations(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            
            Console.Write(" {0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter  N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[k];
        AllTheVariations(array, 0, n);
        
    }
}

