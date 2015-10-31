// Declare a character variable and assign it with the symbol that has Unicode code 72. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class VariableWithUnicode
{
    static void Main(string[] args)
    {
        char unicode = '\u0048';
        Console.WriteLine("The symbol unicode code 72(hex 48) is {0}", unicode);
    }

}

