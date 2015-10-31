namespace NumbersThatAreDivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DivisibleNumbers7And3
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 823, 16, 25, 15,72, 169, 150, 523, 43, 21, 7, 19, 35, 169, 263, 189, 325, 184, 65, 66 };
            
            // with lambda
            var wantedNumbersInLambda = numbers.Where(st => (st % 3) == 0 && (st % 7) == 0).ToArray();
            Console.WriteLine("With lambda");
            foreach (var number in wantedNumbersInLambda)
            {
                Console.WriteLine(number);
            }

            // with Linq
            var wantedNumbersInLinq =
                from number in numbers
                where number % 7 == 0 && number % 3 == 0
                select number;

            Console.WriteLine("With Linq");
            foreach (var number in wantedNumbersInLinq)
            {
                Console.WriteLine(number);
            }
            
        

        }
    }
}
