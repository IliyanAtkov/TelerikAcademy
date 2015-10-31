// Write a program that reads two numbers N and K and generates all the combinations
// of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4},
// {3, 5}, {4, 5}


using System;


    class KDinstinctElements
    {
        static void AllTheVariations(int[] array, int index, int n, int numberAtTheMoment)
        {
            
            if (array.Length == index)   // This is the bottom of recursion without this recursion will be infinitive.
            {

                PrintVariations(array);
            }
            else
            {
                
                for (int i = numberAtTheMoment; i <= n; i++)
                {
                    array[index] = i;
                    AllTheVariations(array, index + 1, n, i + 1);
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
            AllTheVariations(array, 0, n, 1);

        }
    }

