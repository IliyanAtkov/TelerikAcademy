namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var numbers = ConsoleInput.TakeInput(new List<int>());
            var removedNegativeNumbers = RemoveNegativeNumbers(numbers);
            foreach (var number in removedNegativeNumbers)
            {
                Console.Write("{0} ", number);
            }
            
        }

        private static IEnumerable<int> RemoveNegativeNumbers(ICollection<int> numbers)
        {
            var removedNegativeNumbers = numbers.Where(x => x >= 0);

            return removedNegativeNumbers;
        }
    }
}
