// Write an if statement that examines two integer variables and exchanges
  // their values if the first one is greater than the second one.

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("a = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int secondNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            int greaterNum = firstNum;
            firstNum = secondNum;
            secondNum = greaterNum;
            Console.WriteLine("a = {0} and b = {1} \n Exchange done!", firstNum, secondNum);
        }
        else if (secondNum > firstNum)
        {
            Console.WriteLine("a = {0} and b = {1} \n Exchange is not required!", firstNum, secondNum);
        }
        else
        {
            Console.WriteLine("The numbers are equal!");
        }
    }
}