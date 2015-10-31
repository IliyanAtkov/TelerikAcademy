namespace MyStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>, ICollection
    {
        private const int DefaultStackInitialCapacity = 4;
        private int count;
        private int capacity;
        private T[] collection;
        private int currentIndex;

        public MyStack(int initialCapacity)
        {
            this.Capacity = initialCapacity;
            this.collection = new T[this.Capacity];
            this.currentIndex = 0;
        }

        public MyStack()
        {
            this.Capacity = DefaultStackInitialCapacity;
            this.collection = new T[this.Capacity];
            this.currentIndex = 0;
        }
        
        
        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentException("Invalid value");
            }

            if (this.Count == this.Capacity)
            {
                collection = Resize();
            }

            collection[currentIndex++] = item;
            this.count++;
        }

        public T Pop()
        {
            if (collection.Length == 0)
            {
                throw new ArgumentNullException("Empty stack");
            }

            var element = collection[--currentIndex];
            collection[currentIndex--] = default(T);
            this.count--;
            return element;
        }

        public T Peek()
        {
            if (collection.Length == 0)
            {
                throw new ArgumentNullException("Empty stack");
            }

            return collection[currentIndex];
        }

        private T[] Resize()
        {
            var resized = new T[collection.Length * 2];
            this.Capacity = resized.Length;

            for (int i = 0; i < collection.Length; i++)
            {
                resized[i] = this.collection[i];
            }

            return resized;
        }


        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity cannot be zero or less");
                }

                this.capacity = value;
            }
        }

        public int Count
        {
            get { return this.count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

        public void CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }

            if (this.Count > array.Length - index + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }

            for (int i = this.Count - 1; i >= 0; i--)
            {
                array.SetValue(this.collection[i], i + index);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}