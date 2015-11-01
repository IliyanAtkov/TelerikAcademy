namespace MyQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyQueue<T> : IEnumerable<T>, ICollection
    {
        private int count;
        private LinkedList<T> linkedList;


        public MyQueue()
        {
            linkedList = new LinkedList<T>();
        }

        public int Count
        {
            get {return this.count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

        public void Enqueue(T value)
        {
            if (value == null)
            {
                throw new ArgumentException("value cannot be null");
            }

            linkedList.AddLast(value);
            this.count++;
        }

        public T Dequeue()
        {
            if (linkedList.Count == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            this.count--;
            var firstInQueue = linkedList.First;
            linkedList.RemoveFirst();
            return firstInQueue.Value;

        }

        public T Peek()
        {
            if (linkedList.Count == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            return linkedList.First.Value;
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

            var valueToInsert = this.linkedList.First;
            for (int i = 0; i < linkedList.Count; i++)
            {
                array.SetValue(valueToInsert.Value, i + index);
                valueToInsert = valueToInsert.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var firstElement = linkedList.First;
            for (int i = 0; i < linkedList.Count; i++)
            {
                yield return firstElement.Value;
                firstElement = firstElement.Next;  
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}