namespace _04.TownsExam2014
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine().Split(' ')[0]);
            }

            Solve(numbers);
        }

        private static void Solve(int[] numbers)
        {
            
            int biggestSum = 1;
            int[] longestPathAsc = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                longestPathAsc[i] = 1;
                for (int k = 0; k < i; k++)
                {
                    if (numbers[k] < numbers[i])
                    {
                        longestPathAsc[i] = Math.Max(longestPathAsc[i], longestPathAsc[k] + 1);
                    }

                }
            }

           int[] longestPathDesc = new int[numbers.Length];
           for (int i = numbers.Length - 1; i >= 0; i--)
           {
               longestPathDesc[i] = 1;
               for (int k = numbers.Length - 1; k > i; k--)
               {
                   if (numbers[k] < numbers[i])
                   {
                        longestPathDesc[i] = Math.Max(longestPathDesc[i], longestPathDesc[k] + 1);
                   }
          
               }
           }

            
            for (int i = 0; i < numbers.Length; i++)
            {
                longestPathAsc[i] += longestPathDesc[i];
                if (biggestSum < longestPathAsc[i])
                {
                    biggestSum = longestPathAsc[i];
                }
            }
            Console.WriteLine(biggestSum - 1);
        }
    }
}