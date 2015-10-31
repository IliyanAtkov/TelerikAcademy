// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of your number is: \n{0}", Convert.ToString(number, 2));
        int position1 = 3;
        int position2 = 24;
        int mask1 = 7 << position1;   
        int mask2 = 7 << position2;   
        int check1 = number & mask1; 
        int check2 = number & mask2;        
        int change = (number & ~mask1) & ~mask2;   
        int newMask1 = (check1 >> position1) << position2;        
        int newMask2 = (check2 >> position2) << position1;
        int finalResult = (change | newMask1) | newMask2;   
        Console.WriteLine("The result is {0} and it's binary representation is: \n{1}", finalResult, Convert.ToString(finalResult, 2));
    }
    
}

