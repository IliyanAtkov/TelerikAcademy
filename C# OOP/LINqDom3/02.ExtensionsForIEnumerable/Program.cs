namespace ExtensionsForIEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program 
    {
        static void Main()
        {
            IEnumerable<int> valuesForTestPurposes = new int[] { 13, 3, 4, 5, 6, 7, 8, 10 };
            Console.WriteLine("The max number is " + valuesForTestPurposes.Max());
            Console.WriteLine("The min number is " + valuesForTestPurposes.Min());
            Console.WriteLine("The product is " + valuesForTestPurposes.Product());
            Console.WriteLine("The average number is " + valuesForTestPurposes.Average());
        }
    }
}
