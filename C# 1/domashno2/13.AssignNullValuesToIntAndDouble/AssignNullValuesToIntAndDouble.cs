// Create a program that assigns null values to an integer and to double variables.
// Try to print them on the console, try to add some values or the null literal to them and see the result.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class AssignNullValuesToIntAndDouble
{
    static void Main(string[] args)
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Integer: {0}", nullInt);
        Console.WriteLine("Double: {0}", nullDouble);
        Console.WriteLine(nullInt + 20); // Prints emtry row
        nullInt = 5;
        nullDouble = 10;
        Console.WriteLine("Integer : {0} and Double: {1}", nullInt, nullDouble);
    }
}

