namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Program
    {
        static void Main()
        {
            double[,] first = { { 3, 4, 5, 6 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            double[,] second = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 3, 4, 5, 6 }, {22.3, 5, 8, 12 } };

            Matrix<double> arrFirst = new Matrix<double>(first);
            Matrix<double> arrSecond = new Matrix<double>(second);

            //checking if contain zero, return true, if not, return false if there is zero
            if (arrFirst)
            {
                Console.WriteLine("No zero");
            }
            else
            {
                Console.WriteLine("There is at least one zero inside");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the two matrices");
            Console.WriteLine(arrFirst + arrSecond.ToString());
            Console.WriteLine("Substraction of the two matrices");
            Console.WriteLine(arrFirst - arrSecond);
            Console.WriteLine("Multiplication of the two matrices");
            Console.WriteLine(arrFirst * arrSecond);
        }
    }
}
