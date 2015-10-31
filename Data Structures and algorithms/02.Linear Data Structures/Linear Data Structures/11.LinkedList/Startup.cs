namespace LinkedList
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(5);
            linkedList.Add(10);
            linkedList.Add(42);
            linkedList.Add(45);
            linkedList.Add(5);
            linkedList.Remove(5);
            linkedList.Remove(45);
            Console.WriteLine(linkedList.Contains(42));

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
