namespace ConsumingJsonPlaceHolderApi
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net.Http;
    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");
            Console.WriteLine("Enter how many albums do you want 1-100");
            int count = int.Parse(Console.ReadLine());
            if (count < 1 || count > 100)
            {
                throw new ArgumentException("You should have entered number in range 1-100");
            }

            PrintAlbums(httpClient, count);
        }

        public static void PrintAlbums(HttpClient client, int count)
        {
            var response = client.GetAsync("albums").Result;
            var text = response.Content.ReadAsStringAsync().Result;

            var albums = JsonConvert.DeserializeObject<List<Albums>>(text).Take(count);

            foreach (var album in albums)
            {
                Console.WriteLine("{0} id -> {1}", album.Id, album.Title);
            }
        }
    }
}
