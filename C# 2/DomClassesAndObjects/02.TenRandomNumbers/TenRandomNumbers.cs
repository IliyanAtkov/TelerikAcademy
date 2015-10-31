// Write a program that generates and prints to the console 10
// random values in the range [100, 200].


using System;



class TenRandomNumbers
{
    static void GenerateTenRandomNumbers()
    {
        Random number = new Random();
        for (int i = 0; i <= 10; i++)
        {
            int random = number.Next(100, 201);
            Console.WriteLine(random);
        }
        
    }
    static void Main()
    {
        GenerateTenRandomNumbers();
    }
}
