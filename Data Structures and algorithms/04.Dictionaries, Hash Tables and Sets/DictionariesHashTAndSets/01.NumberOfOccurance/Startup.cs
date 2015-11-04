namespace NumberOfOccurance
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var numberOfOccurances = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (numberOfOccurances.ContainsKey(number))
                {
                    numberOfOccurances[number] += 1;
                }
                else
                {
                    numberOfOccurances[number] = 1;
                }
            }

            foreach (var occ in numberOfOccurances)
            {
                Console.WriteLine("{0} -> {1} times", occ.Key, occ.Value);
            }

        }
    }
}
