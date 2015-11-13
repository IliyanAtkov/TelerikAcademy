namespace Zig_Zag
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        static int Count = 0;

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] arr = new int[k];
            bool[] used = new bool[n];

            GenerateVariationsNoRepetitions(0, n, k, used, arr);
            Console.WriteLine(Count);
        }

        static void GenerateVariationsNoRepetitions(int index, int n, int k, bool[] used, int[] arr)
        {
            if (index >= k)
            {
                bool isValid = Validate(arr);
                if (isValid)
                {
                    Count++;
                    return;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenerateVariationsNoRepetitions(index + 1, n, k, used, arr);
                        used[i] = false;
                    }
                }
            }
        }

        static bool Validate(int[] arr)
        {
            bool isValid = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 1 < arr.Length)
                    {
                        isValid = arr[i] > arr[i + 1];
                    }

                }
                else
                {
                    if (i + 1 < arr.Length)
                    {
                        isValid = arr[i] < arr[i + 1];
                    }
                }

                if (isValid == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}