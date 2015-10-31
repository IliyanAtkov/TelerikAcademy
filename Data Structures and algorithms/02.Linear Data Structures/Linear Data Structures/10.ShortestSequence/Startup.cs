namespace ShortestSequenceQueue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m");
            int m = int.Parse(Console.ReadLine());
            var shortestSequence = FindShortestSequence(n, m);
            while (shortestSequence.Count != 0)
            {
                Console.WriteLine(shortestSequence.Pop());
            }
        }

        private static Stack<int> FindShortestSequence(int n, int m)
        {
            var queue = new Stack<int>();
            int current = m;
            queue.Push(current);
            while (current != n)
            {
                if (current / 2 >= n)
                {
                    current /= 2;
                }
                else if (current - 2 >= n)
                {
                    current -= 2;
                }
                else if (current - 1 >= n)
                {
                    current -= 1;
                }

                queue.Push(current);
            }

            return queue;
        }
    }
}