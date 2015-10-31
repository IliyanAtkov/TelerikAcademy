// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AssignAndExchangeValues
{
    static void Main(string[] args)
    {
        int value1 = 60;
        int value2 = 50;
        int result;
        result = value1 + value2;
        value1 = result - value2;
        value2 = result - value1;
        Console.WriteLine("First value is {0} and second is {1}", value1, value2);
        

    }

    
}
