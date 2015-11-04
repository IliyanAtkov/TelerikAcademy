namespace StringOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] words = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var oddWordsOccurences = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (oddWordsOccurences.ContainsKey(word))
                {
                    oddWordsOccurences[word] += 1;

                    if (oddWordsOccurences[word] % 2 == 0)
                    {
                        oddWordsOccurences.Remove(word);
                    }
                }
                else
                {
                    oddWordsOccurences[word] = 1;
                }
            }

            Console.Write("Odd number of times occurs:");
            foreach (var occ in oddWordsOccurences)
            {
                Console.Write(" {0},", occ.Key);
            }
            Console.WriteLine();

            
        }
    }
}
