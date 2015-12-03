namespace _05.Sorting2014Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Number
    {
        public Number(int num, int position, bool isSorted)
        {
            this.Num = num;
            this.Position = position;
            this.IsSorted = isSorted; 
        }

        public int Num { get; set; }

        public int Position { get; set; }
        
        public bool IsSorted { get; set; }
    }

    public class Program
    {
        private static SortedDictionary<int, Number> NumberPositionInArray = new SortedDictionary<int, Number>();

        static void Main()
        {
            Console.ReadLine();
            string[] numbersAsString = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>(numbersAsString.Length);
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers.Add(int.Parse(numbersAsString[i]));
            }

            int allowedSwaps = int.Parse(Console.ReadLine());
            if (allowedSwaps == numbers.Count - 1)
            {
                Console.WriteLine(1);
                return;
            }
                
            Solve(numbers, allowedSwaps);

        }

        private static void Solve(List<int> numbers, int allowedSwaps)
        {
            if (IsSorted(numbers))
            {
                Console.WriteLine(0);
                return;
            }

            GetNumbersPosition(numbers);

            int startPosition = numbers.Count - 1;
            int endPosition = 0;
            int currentMinNumberIndex = 0;
            int swapTimes = 0;
            while (true)
            {
                var currentMinNumber = NumberPositionInArray.First().Value;
                if (currentMinNumber.IsSorted == true)
                {
                    NumberPositionInArray.Remove(0);
                    if (NumberPositionInArray.Count == 0)
                    {
                        Console.WriteLine(swapTimes);
                        return;
                    }

                    continue;
                }

                if (currentMinNumber.Position == 0)
                {
                    currentMinNumber.IsSorted = true;
                    continue;
                }

                for (int i = 0; i < swapTimes; i++)
                {
                    var currentNumber = NumberPositionInArray.Skip(i).Take(1).First().Value;
                    int previousNumber = numbers[currentNumber.Position - 1];
                    Swap(numbers, currentNumber.Position - 1, currentNumber.Position);
                    NumberPositionInArray[previousNumber].Position += 1;
                    NumberPositionInArray[currentNumber.Num].Position -= 1;
                }

                swapTimes++;


            }
        }
        private static void Swap(List<int> numbers, int first, int second)
        {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }

        private static void GetNumbersPosition(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = new Number(numbers[i], i, false);
                NumberPositionInArray.Add(numbers[i], number);
            }
        }

        private static bool IsSorted(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
