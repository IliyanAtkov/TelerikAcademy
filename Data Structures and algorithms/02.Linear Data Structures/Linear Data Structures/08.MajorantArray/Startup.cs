namespace MajorantArray
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            int[] arr = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var timesOfOccOfNumber = new Dictionary<int, int>();
            var majorantNumbers = new HashSet<int>();

            int numberOfOcc = arr.Length / 2 + 1;

            foreach (var number in arr)
            {
                if (timesOfOccOfNumber.ContainsKey(number))
                {
                    timesOfOccOfNumber[number] += 1;
                    if (timesOfOccOfNumber[number] == numberOfOcc)
                    {
                        majorantNumbers.Add(number);
                    }
                    else if (timesOfOccOfNumber[number] > numberOfOcc)
                    {
                        majorantNumbers.Remove(number);
                    }
                }
                else
                {
                    timesOfOccOfNumber[number] = 1;
                }
            }

            foreach (var majorantNumber in majorantNumbers)
            {
                Console.WriteLine("Majorant number {0} ", majorantNumber);
            }
        }
    }
}