namespace FirstTwentyProductsInRange
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;
    using System.Diagnostics;
    using System.Linq;

    public class Startup
    {
        public static RandomGenerator random = new RandomGenerator();
        public static void Main()
        {
            var products = AddProducts(500000);
            Console.WriteLine();
            RandomSearch(products, 10000, false);

        }

        private static OrderedBag<Product> AddProducts(int count)
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            Console.Write("Adding {0} products", count);
            for (int i = 0; i < count; i++)
            {
                if (i % 5000 == 0)
                {
                    Console.Write(".");
                }
             
                string randomString = random.GenerateRandomString(1, 5);
                decimal price = random.GenerateRandomNumber(1, 2000000);
                var product = new Product(randomString, price);
                products.Add(product);
            }

            return products;
        }
        private static void RandomSearch(OrderedBag<Product> products, int count, bool toShowInConsole)
        {
            var firstRandomPriceProduct = new Product("", random.GenerateRandomNumber(1, 1000000));
            var secondRandomPriceProduct = new Product("", random.GenerateRandomNumber(1000000, 2000000));
            Console.Write("Searching {0} times", count);
            for (int i = 0; i < count; i++)
            {
                if (i % 500 == 0)
                {
                    Console.Write(".");
                }
               var findedProducts =  products.Range(firstRandomPriceProduct, true, secondRandomPriceProduct, true).Take(20);
                firstRandomPriceProduct.Price = random.GenerateRandomNumber(1, 1000000);
                secondRandomPriceProduct.Price = random.GenerateRandomNumber(1000000, 2000000);
           
           //    if (toShowInConsole)
           //    {
           //        foreach (var product in findedProducts)
           //        {
           //            Console.WriteLine(product.Name + " " + product.Price);
           //        }
           //    }
            }
        }
    }
}
