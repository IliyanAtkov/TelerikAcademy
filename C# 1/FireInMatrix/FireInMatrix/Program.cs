using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int leftDots = (N / 2) - 1;
        int rightDots = (N / 2) - 1;
        int innerDots = 0;
        int middleline = N;
        int slash = N / 2;
        int backslash = N / 2;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write('#');
            Console.Write(new string('.', innerDots));
            Console.Write('#');
            Console.Write(new string('.', rightDots));
            leftDots--;
            rightDots--;
            innerDots += 2;
            Console.WriteLine();
        }
        innerDots = N - 2;
        leftDots = 0;
        rightDots = 0;
        for (int i = 0; i < N / 4; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write('#');
            Console.Write(new string('.', innerDots));
            Console.Write('#');
            Console.Write(new string('.', rightDots));
            innerDots -= 2;
            leftDots++;
            rightDots++;
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', middleline));

        leftDots = 0;
        rightDots = 0;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', leftDots));
            Console.Write(new string('\\', backslash));
            Console.Write(new string('/', slash));
            Console.Write(new string('.', rightDots));
            backslash--;
            slash--;
            rightDots++;
            leftDots++;
            Console.WriteLine();

        }

    }
}
