namespace MyStack
{
    using System;
    using MyStack;

    public class Startup
    {
        static void Main()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(15);
            stack.Push(23);
            stack.Push(81);
            stack.Push(100);
            var poped = stack.Pop();
            Console.WriteLine("Pop element {0}", poped);
            Console.WriteLine("Peek element {0}", stack.Peek());

            foreach (var number in stack)
            {
                Console.WriteLine(number);
            }

        }
    }
}
