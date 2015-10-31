//Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckGivenExpressionIsCorrectly
{
    static void BracketsCheck(string expression)
    {
        int openBracket = 0;
        int closeBracket = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openBracket++;
            }
            if (expression[i] == ')')
            {
                closeBracket++;
                if (openBracket - closeBracket != 0)
                {
                    break;
                }
                
            }
        }
        if (openBracket == closeBracket)
        {
            Console.WriteLine("Correct expression");
        }
        else
        {
            Console.WriteLine("Incorrect expression!");
        }
        
    }
    static void Main()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();
        BracketsCheck(expression);
    }
}

