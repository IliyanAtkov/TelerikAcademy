namespace RemoveNumbersOccuringOddNumTimes
{
    using System;
    using System.Collections.Generic;
    using Common;

    public class Startup
    {
        public static void Main()
        {
            var numbers = ConsoleInput.TakeInput(new List<int>());
            NumberThatOccurOddNumberOfTimes((List<int>)numbers);

        }

        private static void NumberThatOccurOddNumberOfTimes(List<int> numbers)
        {
            var num = new List<int>(numbers);
            num.Sort();
            int previousNumber = num[0];
            int currentNumber = 0;
            var numberOfOcc = 1;

            var oddNumbers = new List<int>();

            for (int i = 1; i < num.Count; i++)
            {
                currentNumber = num[i];
                if (currentNumber == previousNumber)
                {
                    numberOfOcc++;
                }
                else
                {
                    if (numberOfOcc % 2 == 0)
                    {
                        for (int x = 0; x < numberOfOcc; x++)
                        {
                            oddNumbers.Add(previousNumber);
                        }
                    }

                    numberOfOcc = 1;
                }

                previousNumber = currentNumber;
            }

            if (numberOfOcc % 2 == 0)
            {
                for (int x = 0; x < numberOfOcc; x++)
                {
                    oddNumbers.Add(previousNumber);
                }
            }

            Console.WriteLine("Numbers that occur odd times ");
            foreach (var oddNumber in oddNumbers)
            {
                Console.WriteLine("{0} ", oddNumber);
            }
        }
    }
}
