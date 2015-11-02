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
        }

        private static void FindRoot(Tree<int> tree)
        {
            Console.WriteLine("The root is {0}", tree.Root.Value);
        }

        private static void FindAllLeafes(Tree<int> tree)
        {
            while (true)
            {

            }
        }
    }
}

