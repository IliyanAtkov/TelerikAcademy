namespace NumbersSortingUsingList
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

            var sortedNumbers = numbers.OrderBy(x => x);

            foreach (var number in sortedNumbers)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
