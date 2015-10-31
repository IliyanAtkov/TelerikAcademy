using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static long Pattern(int[] valley)
        {
            string[] rowPattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rowPattern.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rowPattern[i]);
            }
            long sum = 0;
            sum += valley[0];
            bool[] boolCheck = new bool[valley.Length];
            boolCheck[0] = true;
            int currentposition = 0;
            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextmove = currentposition + pattern[i];
                    if (nextmove >= 0 && nextmove < valley.Length && boolCheck[nextmove] == false)
                    {
                        sum += valley[nextmove];
                        currentposition = nextmove;
                        boolCheck[nextmove] = true;
                    }
                    else
                    {
                        return sum;
                    }
                }
            } 

        }
        static void Main()
        {
            string[] valley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[valley.Length];
            for (int i = 0; i < valley.Length; i++)
            {
                array[i] = int.Parse(valley[i]);
            }
            int m = int.Parse(Console.ReadLine());
            long bestSum = long.MinValue;
            for (int i = 0; i < m; i++)
			{
                long sum = Pattern(array);
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
			 
			}
            Console.WriteLine(bestSum);
        }
    }

