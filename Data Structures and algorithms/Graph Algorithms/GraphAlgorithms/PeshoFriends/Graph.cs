namespace PeshoFriends
{
    using System;
    using System.Collections.Generic;

    public class Graph<T>
    {
        public Graph()
        {
            this.NodesValues = new Dictionary<T, Node<T>>();
            this.NodesCollection = new Dictionary<Node<T>, T>();

        }

        public void AddNode(T value, bool isHospital = false)
        {
            var node = new Node<T>(value, isHospital);
            this.NodesValues.Add(value, node);
            this.NodesCollection.Add(node, value);
        }

        public void AddConnection(T fromNode, T toNode, double distance, bool twoWay)
        {
            this.NodesValues[fromNode].AddConnection(this.NodesValues[toNode], distance, twoWay);
        }

        public bool ContainsKey(T key)
        {
           return this.NodesValues.ContainsKey(key);
        }

        internal IDictionary<T, Node<T>> NodesValues { get; private set; }

        public IDictionary<Node<T>, T> NodesCollection { get; private set; }
    }
}