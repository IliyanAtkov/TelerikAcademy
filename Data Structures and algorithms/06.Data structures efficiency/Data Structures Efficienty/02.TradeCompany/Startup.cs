namespace TradeCompany
{
    using Common;
    using System;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static RandomGenerator random = new RandomGenerator();

        public static void Main()
        {
            var articles = GenerateArticles();
            Console.WriteLine(FindArticlesInGivenPriceRange(1, 30000, articles));
        }

        private static OrderedMultiDictionary<decimal, Article> GenerateArticles()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(true);
            
            for (int i = 0; i < 100000; i++)
            {
                decimal randomPrice = random.GenerateRandomNumber(1, 1000000);
                string randomTitle = random.GenerateRandomString(1, 5);
                string randomVendor = random.GenerateRandomString(1, 5);
                string randomBarcode = random.GenerateRandomString(1, 5);
                var article = new Article(randomBarcode, randomVendor, randomTitle, randomPrice);
                articles.Add(article.Price, article);        
            }

            return articles;
        }

        private static string FindArticlesInGivenPriceRange(decimal firstRange, decimal secondRange, OrderedMultiDictionary<decimal, Article> articles)
        {
            var articlesInRange = articles.Range(firstRange, true, secondRange, true);
            StringBuilder sb = new StringBuilder();
            foreach (var art in articlesInRange)
            {
                sb.AppendLine(string.Format("books with price {0} -->  ", art.Key));
                foreach (var article in art.Value)
                {
                    sb.Append("    ");
                    sb.AppendLine(string.Format("{0} title, {1} vendor, {2} barcode",
                  article.Title, article.Vendor, article.Barcode));
                }
            }

            return sb.ToString();
        }
    }
}