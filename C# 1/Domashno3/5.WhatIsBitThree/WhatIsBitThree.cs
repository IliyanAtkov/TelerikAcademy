// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class WhatIsBitThree
{
    static void Main(string[] args)
    {
        string inputInt;
        int numberToCheck;
        bool validInt;

        Console.WriteLine("Input number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
        inputInt = Console.ReadLine();
        validInt = Int32.TryParse(inputInt, out numberToCheck);
        if (validInt)
        {
            Console.WriteLine("The 3rd bit of your integer is {0}", ((numberToCheck >> 3) & 1) == 1 ? 1 : 0);
        }
        else
        {
            Console.WriteLine("This number is invalid!");
        }
       
    }
}

