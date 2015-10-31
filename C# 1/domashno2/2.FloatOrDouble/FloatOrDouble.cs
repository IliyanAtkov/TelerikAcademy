// Which of the following values can be assigned to a variable of type float and which to a variable
// of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FloatOrDouble
{
    static void Main(string[] args)
    {
        float number1 = 12.345f;
        float number2 = 3456.091f;
        double number3 = 8923.1234857;
        double number4 = 34.567839023;
        Console.WriteLine("There are two types of float first: {0}  and second: {1}", number1, number2);
        Console.WriteLine("There are two types of double first: {0} and second: {1}", number3, number4);

    }
}


