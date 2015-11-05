namespace WordsCount
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] spliters = new[] { ".", "?", "!", " ", ";", ":", "-", "_", "," };
            var file = File.ReadAllText("words.txt").Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            var countWords = new Dictionary<string, int>();
            var words = RemoveInvalidWords(file, spliters);
            foreach (var word in words)
            {
                var wordToLower = word.ToLower();
                if (countWords.ContainsKey(wordToLower))
                {
                    countWords[wordToLower] += 1;
                }
                else
                {
                    countWords[wordToLower] = 1;
                }
            }

            foreach (var word in countWords)
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }

        private static List<string> RemoveInvalidWords(string[] text, string[] invalidWords)
        {
            List<string> validWords = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                for (int k = 0; k < invalidWords.Length; k++)
                {
                    if (invalidWords[k] == text[i])
                    {
                        break;
                    }
                }

                validWords.Add(text[i]);
            }

            return validWords;
        }
    }
}
