namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            int capacity = 10;
            int n = 6;
           
            Product[] products = new Product[]
            {
               
                new Product("beer",2,3),
                new Product("vodka ",12,8),
                new Product("cheese",5,4),
                new Product("nuts",4,1),
                 new Product("whiskey",13,8),
                new Product("ham",3,2),
                
            };

            int[,] table = new int[n + 1,capacity + 1];

            for (int row = 1; row <= products.Length; row++)
            {
                var item = products[row - 1];
                for (int col = 0; col <= capacity; col++)
                {
                    if (item.Weight > col)
                    {
                        table[row, col] = table[row - 1, col];
                    }
                    else
                    {
                        table[row, col] = Math.Max(
                            table[row - 1, col],
                            table[row - 1, col - item.Weight] + item.Cost);
                    }
                }
            }

            var productsToPrint = new List<Product>();
            for (int row = products.Length, col = capacity; row > 0; row--)
            {
                if (table[row, col] != table[row - 1, col])
                {
                    productsToPrint.Add(products[row - 1]);
                    col -= products[row - 1].Weight;
                }
            }

            productsToPrint.ForEach(p => Console.WriteLine(p.Name + " Cost " + p.Cost + " Weight " + p.Weight));
        }
    }
}