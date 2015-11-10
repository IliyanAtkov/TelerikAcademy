namespace Triples
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var biDictionary = new BiDictionary<int, string, string>();
            biDictionary.Add(5, "da", "Value as value");
            biDictionary.Add(3, "ne", "Another value");
            biDictionary.Add(3, "da", "HAHAHAHA");

            Console.WriteLine(biDictionary.Find(3));
            Console.WriteLine(biDictionary.Find("da"));
            biDictionary.Find(3, "ne").ToList().ForEach(Console.WriteLine);

        }
    }
}
