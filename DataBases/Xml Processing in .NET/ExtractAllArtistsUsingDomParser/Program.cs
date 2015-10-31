using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExtractAllArtistsUsingDomParser
{
    public class Program
    {
        static void Main()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load("../../catalog.xml");
            var root = xmlDocument.DocumentElement;
            var artists = ArtistAlbumsCount(root);
            foreach (var pair in artists)
            {
                Console.WriteLine("{0} - {1} albums", pair.Key, pair.Value);
            }
        }

         private static Dictionary<string, int> ArtistAlbumsCount(XmlElement root)
         {
             var dic = new Dictionary<string, int>();
             var artists = root.GetElementsByTagName("artist");

             foreach (XmlNode artist in artists)
             {
                 var artistName = artist.InnerText.Trim();
                 if (!dic.ContainsKey(artistName))
                 {
                     dic.Add(artistName, 1);
                 }

                 else
                 {
                     dic[artistName] += 1;
                 }
             }

             return dic;
         }
    }
}
