namespace PeshoFriends
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            string[] firstRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int housesAndHospitals = int.Parse(firstRow[0]);
            int streets = int.Parse(firstRow[1]);
            int hospitals = int.Parse(firstRow[2]);

            string[] secondRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         
            var graph = new Graph<int>();

            for (int i = 0; i < secondRow.Length; i++)
            {
                graph.AddNode(int.Parse(secondRow[i]), true);
            }

            for (int i = 1; i <= housesAndHospitals; i++)
            {
                if (!graph.ContainsKey(i))
                {
                    graph.AddNode(i);
                }
            }

            for (int i = 0; i < streets; i++)
            {
                string[] street = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int first = int.Parse(street[0]);
                int second = int.Parse(street[1]);
                int distance = int.Parse(street[2]);

                graph.AddConnection(first, second, distance, true);               
            }

 
            double minDistance = double.PositiveInfinity;
            for (int i = 0; i < secondRow.Length; i++)
            {
                double currentDistance = 0;
                var node = graph.NodesValues[int.Parse(secondRow[i])];
   
                Dijkstra(graph, node);

                for (int k = 1; k <= graph.NodesValues.Count; k++)
                {
                    if (graph.NodesValues[k].IsHospital == true)
                    {
                        continue;
                    }

                    currentDistance += graph.NodesValues[k].DijkstraDistance;
                }

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }

            }

            Console.WriteLine(minDistance);
        }

        private static void Dijkstra(Graph<int> graph, Node<int> source)
        {
            var queue = new PriorityQueue<Node<int>>();
            foreach (var node in graph.NodesCollection.Keys)
            {
                node.DijkstraDistance = double.PositiveInfinity;
            }

            source.DijkstraDistance = 0.0d;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();

                if (double.IsPositiveInfinity(currentNode.DijkstraDistance))
                {
                    break;
                }

                foreach (var neighbor in currentNode.Collection)
                {
                    var potDistance = currentNode.DijkstraDistance + neighbor.Distance;
                    if (potDistance < neighbor.Target.DijkstraDistance)
                    {
                        neighbor.Target.DijkstraDistance = potDistance;
                        queue.Enqueue(neighbor.Target);
                    }

                }
            }
        }
    }
}