namespace MyQueue       
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var queue = new MyQueue<int>();
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(15);
            queue.Enqueue(243);
            queue.Enqueue(13);
            Console.WriteLine("Deque element {0}", queue.Dequeue());
            Console.WriteLine("Peek element {0}", queue.Peek());

            foreach (var element in queue)
            {
                Console.WriteLine("{0} ", element);
            }
        }
    }
}