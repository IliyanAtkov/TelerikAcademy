namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : ICollection<T>, IEnumerable<T>
    {
        private int count;
        private ListItem<T> tailElement;

        public LinkedList()
        {
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public ListItem<T> FirstElement { get; set; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(T item)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(item);
                this.tailElement = this.FirstElement;
            }
            else
            {
                var newElement = new ListItem<T>(item, this.tailElement);
                this.tailElement = newElement;
            }

            this.count++;
        }

        public void Clear()
        {
            this.FirstElement = null;
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                return false;
            }

            var currentItem = this.FirstElement;
            while (currentItem != null)
            {
                if (currentItem.Value.Equals(item))
                {
                    return true;
                }

                currentItem = currentItem.NextItem;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }

            if (this.Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }

            var item = this.FirstElement;
            int index = 0;
            while (item != null)
            {
                array[index + arrayIndex] = item.Value;
                index++;
                item = item.NextItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;
            if (currentElement != null)
            {
                yield return currentElement.Value;
            }

            while (currentElement.NextItem != null)
            {
                currentElement = currentElement.NextItem;
                yield return currentElement.Value;
            }
        }

        public bool Remove(T item)
        {
            var current = this.FirstElement;
            var previous = this.FirstElement;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (current == this.FirstElement)
                    {
                        this.FirstElement = this.FirstElement.NextItem;
                        this.count--;
                        return true;
                    }

                    previous.NextItem = current.NextItem;
                    current = null;
                    this.count--;
                    return true;
                }

                previous = current;
                current = current.NextItem;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}