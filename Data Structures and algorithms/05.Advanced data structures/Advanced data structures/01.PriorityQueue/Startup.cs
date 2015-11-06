namespace PriorityQueue
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var a = new PriorityQueue<int>();

            a.Enqueue(5, 1);
            a.Enqueue(1, 0);
            a.Enqueue(3, 5);
            a.Enqueue(10, 1);
            a.Enqueue(41, 2);

            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
            Console.WriteLine(a.Dequeue());
        }
    }
}
