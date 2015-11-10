namespace Triples
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T>
        where K1 : IComparable<K1> 
        where K2 : IComparable<K2>
    {
        private OrderedMultiDictionary<K1, T> orderedCollectionByKey1;
        private OrderedMultiDictionary<K2, T> orderedCollectionByKey2;
        
        public BiDictionary()
        {
            this.orderedCollectionByKey1 = new OrderedMultiDictionary<K1, T>(true);
            this.orderedCollectionByKey2 = new OrderedMultiDictionary<K2, T>(true);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            this.orderedCollectionByKey1.Add(key1, value);
            this.orderedCollectionByKey2.Add(key2, value);
        }

        public ICollection<T> Find(K1 key)
        {
            if (orderedCollectionByKey1.ContainsKey(key))
            {
                return orderedCollectionByKey1[key];
            }

            return null;
        }

        public ICollection<T> Find(K2 key)
        {
            if (orderedCollectionByKey2.ContainsKey(key))
            {
                return orderedCollectionByKey2[key];
            }

            return null;
        }

       public IEnumerable<T> Find(K1 key1, K2 key2)
        {
            if (orderedCollectionByKey1.ContainsKey(key1) && orderedCollectionByKey2.ContainsKey(key2))
            {
                return orderedCollectionByKey1[key1].Intersect(orderedCollectionByKey2[key2]);
            }

            return null;
        }

        public ICollection<T> Remove(K1 key1, K2 key2, T value)
        {
            bool foundFirst = orderedCollectionByKey1.ContainsKey(key1);
            bool foundSecond = orderedCollectionByKey2.ContainsKey(key2);

            if (foundFirst && foundSecond)
            {
                orderedCollectionByKey1.Remove(key1);
                orderedCollectionByKey2.Remove(key2);
            }

            return null;
        }
    }
}