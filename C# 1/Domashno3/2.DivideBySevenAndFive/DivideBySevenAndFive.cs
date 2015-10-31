// Write a boolean expression that checks for given integer
// if it can be divided (without remainder) by 7 and 5 in the same time.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number can be divided by 7 and 5 at the same time");
        }
        else
        {
            Console.WriteLine("The number cannot be divided by 7 and 5 at the same time");
        }
	
		 
	
    }
    
}
	
    


