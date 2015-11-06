namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private IList<PriorityQueueNode<T>> values;

        public PriorityQueue()
        {
            this.values = new List<PriorityQueueNode<T>>();
        }

        public void Enqueue(T value, T priority)
        {
            var node = new PriorityQueueNode<T>(value, priority);
            BubbleUp(node);
        }

        public T Peek()
        {
            if (values.Count == 0)
            {
                throw new InvalidOperationException("Empty queue");
            }

            return values[0].Value;
        }

        public T Dequeue()
        {
             var value = Peek();
            values[0] = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);

            BubbleDown();
            return value;
        }
        private void Swap(int firstIndex, int secondIndex)
        {
            PriorityQueueNode<T> tmp = values[firstIndex];
            values[firstIndex] = values[secondIndex];
            values[secondIndex] = tmp;
        }

        private void BubbleDown()
        {
            int index = 0;
            int leftChildIndex = (index * 2) + 1;
            while (leftChildIndex < values.Count)
            {
                leftChildIndex = (index * 2) + 1;
                int rightChildIndex = (index * 2) + 2;
                int smallerChild = leftChildIndex;

                if ((index * 2) + 2 < values.Count
                    && values[leftChildIndex].Priority.CompareTo(values[rightChildIndex].Priority) > 0)
                {
                    smallerChild = rightChildIndex;
                }

                if (values[index].Priority.CompareTo(values[smallerChild].Priority) > 0)
                {
                    Swap(index, smallerChild);
                }
                else
                {
                    break;
                }
               
                index = smallerChild;
                leftChildIndex = (index * 2) + 1;
            }
        }

        private void BubbleUp(PriorityQueueNode<T> node)
        {
            values.Add(node);
            
            int currentIndex = values.Count - 1;
            if (currentIndex <= 0)
            {
                return;
            }
            while (true)
            {
                int parentIndex = (int)Math.Floor((currentIndex - 1) / 2m);
                if (parentIndex < 0)
                {
                    return;
                }
                var parent = values[parentIndex];
                

                if (parent.Priority.CompareTo(node.Priority) > 0)
                {
                    values[currentIndex] = parent;
                    values[parentIndex] = node;
                    currentIndex = parentIndex;
                }
                else
                {
                    return;
                }
            }
        }
    }
}