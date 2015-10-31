namespace Common
{
    using System;
    using System.Collections.Generic;

    public static class ConsoleInput
    {
        public static ICollection<int> TakeInput(ICollection<int> collection)
        {
            Console.WriteLine("Enter  numbers: ");
            int number = 0;

            while (true)
            {
                bool validParse = int.TryParse(Console.ReadLine(), out number);
                if (!validParse)
                {
                    if (collection.Count > 0)
                    {
                        return collection;
                    }

                    Console.WriteLine("Enter  numbers: ");
                    continue;
                }

                collection.Add(number);
            }
        }

        // Stack does not implement generic Icollection..
        public static Stack<int> TakeInput()
        {
            Console.WriteLine("Enter  numbers: ");
            var numbers = new Stack<int>();
            int number = 0;

            while (true)
            {
                bool validParse = int.TryParse(Console.ReadLine(), out number);
                if (!validParse)
                {
                    if (numbers.Count > 0)
                    {
                        return numbers;
                    }

                    Console.WriteLine("Enter  numbers: ");
                    continue;
                }

                numbers.Push(number);
            }
        }
    }
}
