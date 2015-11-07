namespace SetOfWords
{
    using System;
    using Common;

    public class Startup
    {
        public static RandomGenerator random = new RandomGenerator();

        static void Main()
        {
            string[] words = new string[]
            {
               "are", "you", "normal", "crazy", "no", "you", "shut", "up", "what", "the", "fuck", "system", "house", "flat",
               "bananas", "subway", "dinner", "lunch", "mother", "from", "another", "father", "some", "random", "guy",
               "is", "trying", "to", "kill", "Mr.", "Bon", "from", "France", "thats", "why", "he", "kills", "the",
               "passanger", "and" ,"throw" ,"granade", "after", "president" ,"of" ,"the" ,"United States Of America" ,
               "kill", "that", "morron", "was" ,"his", "last", "words",
            };

            var trie = GenerateTrie(words, 1000000);
            var randomSearchWords = GenerateSearchWords(words, 1000);
            FindWordsInText(trie, randomSearchWords);


        }

        private static void FindWordsInText(Trie trie, string[] randomSearchWords)
        {
            for (int i = 0; i < randomSearchWords.Length; i++)
            {
                Console.WriteLine("Word {0} appears {1}", randomSearchWords[i], trie.GetCount(randomSearchWords[i]));
            }
        }

        private static string[] GenerateSearchWords(string[] words, int count)
        {
            string[] randomWords = new string[count];
            for (int i = 0; i < randomWords.Length; i++)
            {
                randomWords[i] = (words[random.GenerateRandomNumber(0, words.Length - 1)]);
            }

            return randomWords;
        }

        private static Trie GenerateTrie(string[] words, int count)
        {
            var trie = new Trie();

            for (int i = 0; i < count; i++)
            {
                trie.AddWord(words[random.GenerateRandomNumber(0, words.Length - 1)]);
            }

            return trie;
        }
    }
}
