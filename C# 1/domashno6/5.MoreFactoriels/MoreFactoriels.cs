using System;

class MoreFactoriels
{
    static void Main()
    {
        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        Console.Write("Insert N (where N<K): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Insert K(where K>N): ");
        int k = int.Parse(Console.ReadLine());
        int product = 1;
        int middleProduct = 1;

        int kMinusN = k - n;
        if (k > n)
        {
            for (int i = k; i > kMinusN; i--)
            {
                middleProduct *= i;
            }
            product *= middleProduct;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            Console.WriteLine("(N!*K!) / (K-N)! = {0}", product);
        }
        else
        {
            Console.WriteLine("You have enter invalid valuabels! K should be bigged than N!");
        }

    }
}