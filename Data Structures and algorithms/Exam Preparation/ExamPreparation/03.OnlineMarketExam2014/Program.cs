namespace _03.OnlineMarketExam2014
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Product : IComparable<Product>
    {
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }


        public string Name { get; private set; }

        public double Price { get; private set; }

        public string Type { get; private set; }

        public int CompareTo(Product other)
        {
            var priceCompareResult = this.Price.CompareTo(other.Price);
            if (priceCompareResult == 0)
            {
                var namesCompareResult = this.Name.CompareTo(other.Name);
                if (namesCompareResult == 0)
                {
                    return this.Type.CompareTo(other.Type);
                }
                else
                {
                    return namesCompareResult;
                }
            }
            else
            {
                return priceCompareResult;
            }
        }
    }

    public class SuperMarket
    {
        private readonly Dictionary<string, SortedSet<Product>> byType;
        private readonly SortedSet<double> bySortedPrice;
        private readonly Dictionary<double, SortedSet<Product>> byPrice;
        private readonly HashSet<string> byName;
      //  private readonly SortedDictionary<double, SortedDictionary<string, SortedDictionary<string, Product>> byMany;

        public SuperMarket()
        {
            this.byType = new Dictionary<string, SortedSet<Product>>();
            this.bySortedPrice = new SortedSet<double>();
            this.byPrice = new Dictionary<double, SortedSet<Product>>();
            this.byName = new HashSet<string>();
        }

        public string AddProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();

            if (byName.Contains(product.Name))
            {
                sb.Append(string.Format("Error: Product {0} already exists", product.Name));
                return sb.ToString();
            }
            else
            {
                sb.Append(string.Format("Ok: Product {0} added successfully", product.Name));
            }

            if (!byType.ContainsKey(product.Type))
            {
                byType[product.Type] = new SortedSet<Product>();
            }

            if (!byPrice.ContainsKey(product.Price))
            {
                byPrice[product.Price] = new SortedSet<Product>();
            }

            byType[product.Type].Add(product);
            byPrice[product.Price].Add(product);
            bySortedPrice.Add(product.Price);
            byName.Add(product.Name);

            return sb.ToString();
        }

        public string FilterByType(string type)
        {
            StringBuilder sb = new StringBuilder();

            if (!byType.ContainsKey(type))
            {
                sb.Append(string.Format("Error: Type {0} does not exists", type));
            }
            else
            {

                var result = byType[type]
                    .Take(10)
                    .ToList();

                sb.Append("Ok: ");
                for (int i = 0; i < result.Count; i++)
                {
                    sb.Append(result[i].Name + "(" + result[i].Price + "), ");
                }

                sb.Remove(sb.Length - 2, 2);
            }
            
            return sb.ToString();
        }

        public string FilterByPrice(double from, double to)
        {
            List<Product> products = new List<Product>();

            var result = bySortedPrice.GetViewBetween(from, to).Take(10);
            foreach (var res in result)
            {
                if (products.Count >= 10)
                {
                    break;
                }

                foreach (var pro in byPrice[res])
                {
                    if (products.Count >= 10)
                    {
                        break;
                    }

                    products.Add(pro);
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Ok: ");
            for (int i = 0; i < products.Count; i++)
            {
                sb.Append(products[i].Name + "(" + products[i].Price + "), ");
            }
            if (products.Count > 0)
            {
                sb.Remove(sb.Length - 2, 2);
            }
    

            return sb.ToString();
        }
    }

    public class Program
    {
        static void Main()
        {
            var supermarket = new SuperMarket();
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "end")
                {
                    Console.WriteLine(sb.ToString());
                    break;
                }


                switch (input[0])
                {
                    case "add":
                        var product = new Product(input[1], double.Parse(input[2]), input[3]);
                        sb.AppendLine(supermarket.AddProduct(product));
                        break;
                    case "filter":
                        if (input[2] == "type")
                        {
                            sb.AppendLine(supermarket.FilterByType(input[3]));
                        }
                        else if (input[2] == "price")
                        {
                            if (input.Length > 5)
                            {
                                sb.AppendLine(supermarket.FilterByPrice(double.Parse(input[4]), double.Parse(input[6])));
                            }
                            else
                            {
                                if (input[3] == "from")
                                {
                                    sb.AppendLine(supermarket.FilterByPrice(double.Parse(input[4]), 9999999.0));
                                }
                                else
                                {
                                    sb.AppendLine(supermarket.FilterByPrice(0, double.Parse(input[4])));
                                }
                            }
                        }
                        break;
                    default:
                        throw new ArgumentException();
                        break;
                }

            }
        }

    }
}
