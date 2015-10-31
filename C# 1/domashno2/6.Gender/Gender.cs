// Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Gender
{
    static void Main(string[] args)
    {
        Console.Write("Are you male or female? : ");
        string gender = (Console.ReadLine());        
        bool isFemale;
        if (gender == "female")
        {
            isFemale = true;
            Console.WriteLine("Are you female >> {0}", isFemale);
        }
        else if (gender == "male")
        {
           isFemale = false;
           Console.WriteLine("Are you female >> {0}", isFemale);
        }
        else
        {
            Console.WriteLine("You've entered something else");
        }
    }
}

