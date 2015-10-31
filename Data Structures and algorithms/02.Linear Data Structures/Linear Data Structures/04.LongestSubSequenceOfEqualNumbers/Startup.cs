namespace LongestSubSequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var numbers = ConsoleInput.TakeInput(new List<int>());
            LongestSubSequence((List<int>)numbers);

        }
        
        private static List<int> LongestSubSequence(List<int> numbers)
        {
            int longestSubSequenceCount = 0;
            int longestSubSequenceNumber = 0;
            var uniqueNumbers = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (uniqueNumbers.ContainsKey(currentNumber))
                {
                    int count = uniqueNumbers[currentNumber] += 1;
                    if (count > longestSubSequenceCount)
                    {
                        longestSubSequenceCount = count;
                        longestSubSequenceNumber = currentNumber;
                    }
                }
            }

            var longestSubSequence = new List<int>();

            for (int i = 0; i < longestSubSequenceCount; i++)
            {
                longestSubSequence.Add(longestSubSequenceNumber);
            }

            return longestSubSequence;
        }
    }
}
