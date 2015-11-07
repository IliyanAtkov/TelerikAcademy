namespace SetOfWords
{
    using System;

    public class Trie
    {
        private TrieNode head;

        public Trie()
        {
            head = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode curr = head;

            curr = curr.GetChild(word[0], true);

            for (int i = 1; i < word.Length; i++)
            {
                curr = curr.GetChild(word[i], true);
            }

            curr.AddCount();
        }

        public int GetCount(string word)
        {
            TrieNode curr = head;

            foreach (char c in word)
            {
                curr = curr.GetChild(c);

                if (curr == null)
                {
                    return 0;
                }
            }

            return curr.count;
        }
    }
}