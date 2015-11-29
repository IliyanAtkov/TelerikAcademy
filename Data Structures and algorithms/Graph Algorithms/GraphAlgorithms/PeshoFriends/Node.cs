namespace PeshoFriends
{
    using System;
    using System.Collections.Generic;

    public class Node<T> : IComparable
    {
        private readonly IList<Edge<T>> connections;

        public Node(T value, bool isHospital = false)
        {
            this.Value = value;
            this.connections = new List<Edge<T>>();
            this.IsHospital = isHospital;
        }

        public T Value { get; private set; }

        public IEnumerable<Edge<T>> Collection
        {
            get { return this.connections; }
        }

        public bool IsHospital { get; set; }

        public double DijkstraDistance { get; set; }

        public void AddConnection(Node<T> targetNode, double distance, bool twoWay)
        {
            if (targetNode == null)
            {
                throw new ArgumentNullException("Target node cannot be null");
            }

            if (targetNode == this)
            {
                throw new ArgumentException("Node cannot connect to itself");
            }

            if (distance <= 0)
            {
                throw new ArgumentException("Distance must be positive");
            }

       //     this.DijkstraDistance = distance;
            this.connections.Add(new Edge<T>(targetNode, distance));
            if (twoWay)
            {
                targetNode.AddConnection(this, distance, false);
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Node<T>))
            {
                return -1;
            }

            return this.DijkstraDistance.CompareTo((obj as Node<T>).DijkstraDistance);
        }
    }
}