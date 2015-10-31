namespace HowManyTimeEachOfThemOcc
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] numbers = { 3, 412, 13, 5, 1, 53, 23, 75, 4, 3, 3, 3, 3, 3, 3, 4, 5, 1, 6, 5, 53 };
            var occurences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (occurences.ContainsKey(number))
                {
                    occurences[number] += 1;
                }
                else
                {
                    occurences[number] = 1;
                }
            }


            foreach (var occurs in occurences)
            {
                Console.WriteLine("{0} > {1} times", occurs.Key, occurs.Value);
            }

        }

    }
}