// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
	// Create appropriate methods.
	// Provide a simple text-based menu for the user to choose which task to solve.
	// Validate the input data:
// The decimal number should be non-negative
// The sequence should not be empty
// a should not be equal to 0

using System;


class SolvingMultipleTasks
{
    static void SolveLinearEquation()
    {
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = -b / a;
            Console.WriteLine();
            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x = {0}", x);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Input 'a' can't be zero!");
        }

    }
    static void AverageSequenceOfIntegers()
    {
        Console.WriteLine("You choose to calculate the average of sequence of integers!");
        Console.WriteLine("Enter the length of integers sequnce: ");
        string lenghtInString = Console.ReadLine();
        int length = 0;
        bool completeSuccessful = false;
        int[] sequnce;
        int sum = 0;
       
        do
        {
            if (int.TryParse(lenghtInString, out length))
            {
      
                completeSuccessful = true;
                
            }
            else
            {
                Console.WriteLine("You don't enter valid lenght enter again!");
                lenghtInString = Console.ReadLine();
            }
      
        } while (completeSuccessful == false);

        sequnce = new int[length];
        
        Console.WriteLine("Enter the elements of the sequnce");
        for (int i = 0; i < sequnce.Length; i++)
        {
            sequnce[i] = int.Parse(Console.ReadLine());
        }

        foreach (var element in sequnce)
        {
            sum += element;
        }
         sum = sum / sequnce.Length;
         Console.WriteLine("The average is: {0}", sum);
    }
    static int UserChoise()
    {
        Console.WriteLine("If you want to reverse number enter 1");
        Console.WriteLine("If you want the average of a sequnce of integers enter 2");
        Console.WriteLine("If you want to solve linear equation enter 3");
        string enteredChoise = Console.ReadLine();
        int choise;
        if (int.TryParse(enteredChoise, out choise))
        {
            return choise;
        }
        else
	    {
            while (true)
            {
                Console.Write("You don't enter the right choises from the menu enter again!: ");
                enteredChoise = Console.ReadLine();
                if (enteredChoise == "1" || enteredChoise == "2" || enteredChoise == "3")
                {
                    choise = int.Parse(enteredChoise);
                    return choise;
                }
            }
	    }
    }
    static void Main()
    {
        
        int choise = UserChoise();
        if (choise == 1)
        {
            Console.WriteLine("Enter the number you want to reverse");
            ReverseNumber.Reverse(); // Here I use the method from exercise 7
        }
        if (choise == 2)
	    {
            AverageSequenceOfIntegers();
	    }
        if (choise == 3)
        {
            SolveLinearEquation();
            
        }
        
    }
}

