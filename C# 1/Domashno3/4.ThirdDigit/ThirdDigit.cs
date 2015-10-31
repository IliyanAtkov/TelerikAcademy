// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class ThirdDigit
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer number: ");
        int i = int.Parse(Console.ReadLine());
        int divideOneHundred = i / 100;
        bool check = ((Math.Abs(divideOneHundred) % 10) == 7);

        string right = "The third digit (right-to-left) of " + i + " is 7";
        string wrong = "The third digit (right-to-left) of " + i + " is not 7";
        Console.WriteLine(check ? right : wrong);
    }
}
