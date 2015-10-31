namespace FirstFiftyMembersQueue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const int MembersToCalculate = 50;

        static void Main()
        {
            int n = TakeInput();

            var queue = new Queue<int>();
            queue.Enqueue(n);

            for (int i = 0; i < MembersToCalculate; i++)
            {
                var current = queue.Dequeue();
                Console.Write("{0}, ", current);

                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2);

            }
        }

        private static int TakeInput()
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter n: ");
                bool isValid = int.TryParse(Console.ReadLine(), out n);
                if (isValid == true)
                {
                    break;
                }
            }

            return n;
        }
    }
}