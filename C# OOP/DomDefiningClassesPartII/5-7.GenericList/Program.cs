namespace Generic
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>(5);
            test.Add(1);
           test.Add(2);
           test.Add(10);
           test.Add(20);
           test.Add(13);
           test.Add(15);
           test.Find(2);
           test.InsertAt(2, 100);
           test.Find(100);
           test.RemoveAt(2); // Removing 100
           test.Find(100); // Now 100 don't exist
           Console.WriteLine(test.ToString());
           Console.WriteLine(test.Min());
           Console.WriteLine(test.Max());
        }
    }
}
