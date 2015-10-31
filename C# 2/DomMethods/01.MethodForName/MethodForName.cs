// Write a method that asks the user for his name and prints “Hello, <name>”
// (for example, “Hello, Peter!”). Write a program to test this method

using System;
using System.Text;



class MethodForName
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(EnterName());
        if (CheckIfNameIsValid(sb))
        {
            Console.WriteLine("Hello, {0}", sb.ToString());
        }
        else
            Console.WriteLine("Incorrect string name");
    }


    static bool CheckIfNameIsValid(StringBuilder sb)
    {
        bool result = true;

        for (int i = 0; i < sb.Length; i++)
        {
            result = (Char.IsLetter(sb[i]) || Char.IsWhiteSpace(sb[i]));
            if (result == false)
                break;
        }
        return result;
    }

    public static string EnterName()
    {
        Console.WriteLine("Write your name:"); ;
        return (Console.ReadLine());
    }
}
