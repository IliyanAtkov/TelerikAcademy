// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should
// be filled with '*'. Print the result string into the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Maximum20Characters
{
    class Maximum20Characters
    {
        static void Maximum()
        {
            Console.WriteLine("Enter maximum 20 characters: ");
            string enter = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(enter);
            int length = enter.Length;
            if (length > 20)
            {
                Console.WriteLine("You have entered more than 20 characters!!");
            }
            else
            {
                int remainCharacters = 20 - length;
                sb.Append(new string('*', remainCharacters));
                Console.WriteLine(sb);
            }
        }
        static void Main()
        {
            Maximum();
        }
    }
}
