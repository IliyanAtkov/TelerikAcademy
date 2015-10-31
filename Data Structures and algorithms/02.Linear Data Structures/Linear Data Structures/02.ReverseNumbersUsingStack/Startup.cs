namespace ReverseNumbersUsingStack
{
    using Common;
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var numbers = ConsoleInput.TakeInput();

            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
        }
     }
}