namespace PriorityQueue
{
    using System;

    public class PriorityQueueNode<T> where T : IComparable<T>
    {
        private T value;
        private T priority;

        public PriorityQueueNode(T value, T priority)
        {
            this.Value = value;
            this.Priority = priority;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null");
                }

                this.value = value;
            }
        }

        public T Priority
        {
            get
            {
                return this.priority;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Priority cannot be null");
                }

                this.priority = value;
            }
        }
    }
}