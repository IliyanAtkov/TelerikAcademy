using System;

class CatalanFormula
{
    static void Main()
    {
        // Catalan formula =  (2n)! / (n + 1)! * n!

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int middleProduct = 1;
        decimal product = 1;

        int nPlusOne = n + 1;
        for (int i = 2 * n; i > nPlusOne; i--)
        {
            middleProduct *= i;
        }
        product *= middleProduct;
        for (int i = 1; i <= n; i++)
        {
            product /= i;
        }

        Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", product);
    }
}