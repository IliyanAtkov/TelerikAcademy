namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            var tree = new Tree<int>(3,
                        new Tree<int>(5,
                            new Tree<int>(0),
                            new Tree<int>(1),
                            new Tree<int>(6)),
                        new Tree<int>(2,
                            new Tree<int>(4)));

            FindRoot(tree);
            BFS(tree);
            Console.WriteLine();
            Console.WriteLine("Longest path {0} ", FindLongestPath(tree.Root));
        }

        private static void FindRoot(Tree<int> tree)
        {
            Console.WriteLine("The root is {0}", tree.Root.Value);
        }

        private static int FindLongestPath(TreeNode<int> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int longPathLength = 0;
            foreach (var child in node.Children)
            {
                int longChild = FindLongestPath(child);
                if (longChild > longPathLength)
                {
                    longPathLength = longChild;
                }
            }

            return longPathLength + 1;
        }

        private static void BFS(Tree<int> tree)
        {
            var middleNodes = new List<TreeNode<int>>();
            var leafNodes = new List<TreeNode<int>>();
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            queue.Enqueue(tree.Root);
            while (queue.Count > 0)
            {
                var currentItem = queue.Dequeue();
                if (currentItem.ChildrenCount > 0 && currentItem.HasParent == true)
                {
                    middleNodes.Add(currentItem);
                }
                else if (currentItem.ChildrenCount == 0 && currentItem.HasParent == true)
                {
                    leafNodes.Add(currentItem);
                }

                foreach (var item in currentItem.Children)
                {
                    queue.Enqueue(item);
                }
            }

            Console.Write("Middle nodes :");
            foreach (var middleNode in middleNodes)
            {
                Console.Write(" {0}", middleNode.Value);
            }
            Console.WriteLine();
            Console.Write("Leaf nodes :");
            foreach (var leafNode in leafNodes)
            {
                Console.Write(" {0}", leafNode.Value);
            }

        }
    }
}