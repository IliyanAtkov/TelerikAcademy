namespace Statistic
{
    using System;

    public class StatisticsInformation
    {
        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine(this.FindMaxNumber(numbers));
            Console.WriteLine(this.FindMinNumber(numbers));
            Console.WriteLine(this.FindAverageNumber(numbers));
        }

        private double FindMaxNumber(double[] numbers)
        {
            double biggestNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }
            }

            return biggestNumber;
        }

        private double FindMinNumber(double[] numbers)
        {
            double smallestNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }

            return smallestNumber;
        }

        private double FindAverageNumber(double[] numbers)
        {
            double sumOfNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfNumbers += numbers[i];
            }

            double averageNumber = sumOfNumbers / numbers.Length;
            return averageNumber;
        }
    }
}