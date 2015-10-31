namespace PositiveIntegerNumbersUsingList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Common;

    public class Startup
    {
        static void Main()
        {
            var numbers = ConsoleInput.TakeInput(new List<int>());

            var averageNumber = numbers.Average();
            var sumOfNumbers = numbers.Sum();

            Console.WriteLine("Average number is {0:F0}", averageNumber);
            Console.WriteLine("Sum of Numbers is {0}", sumOfNumbers);
        }
    }
}