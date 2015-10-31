using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatGoiko
{
    class Program
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine());
            int leftDots = h - 1;
            int rightDots = h - 1;
            int innerdots = 0;
            int dash = 0;

            for (int i = 0; i <= h; i++)
            {
                Console.Write(new string('.', leftDots));
                Console.Write('/');

                Console.WriteLine();
            }
            
        }
    }
}
