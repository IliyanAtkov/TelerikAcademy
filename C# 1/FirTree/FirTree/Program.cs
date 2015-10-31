using System;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftDots = n - 2;
            int rightDots = n - 2;
            int star = 1;

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write(new string('*', star));
                Console.Write(new string('.', rightDots));
                leftDots--;
                rightDots--;
                star += 2;
                Console.WriteLine();
            }
            leftDots = n - 2;
            rightDots = n - 2;
            star = 1;
            Console.Write(new string('.', leftDots));
            Console.Write(new string('*', star));
            Console.Write(new string('.', rightDots));
            Console.WriteLine();

                
            
        }
    }
}
