namespace SetOfWords
{
    using System;
    using System.Collections.Generic;

    internal class TrieNode
    {
        private LinkedList<TrieNode> children;

        public int count { get; private set; }
        public char data { get; private set; }

        public TrieNode(char data = ' ')
        {
            this.data = data;
            count = 0;
            children = new LinkedList<TrieNode>();
        }

        public TrieNode GetChild(char c, bool createIfNotExist = false)
        {
            foreach (var child in children)
            {
                if (child.data == c)
                {
                    return child;
                }
            }

            if (createIfNotExist)
            {
                return CreateChild(c);
            }

            return null;
        }

        public void AddCount()
        {
            count++;
        }

        public TrieNode CreateChild(char c)
        {
            var child = new TrieNode(c);
            children.AddLast(child);

            return child;
        }
    }

}