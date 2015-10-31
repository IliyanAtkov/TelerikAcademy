// Write a program that reads an integer number and calculates and
// prints its square root. If the number is invalid or negative, print
// "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


using System;



    class SquareRoot
{
    static void CalculateSqureRoot()
    {
        Console.Write("Enter a integer: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArithmeticException("Invalid number! The square root is only for non-negative numbers!");
            }
            double square = Math.Sqrt(number);
            Console.WriteLine("The square root  is {0}.", square);
        }
       
        catch (FormatException formatException)
        {
            throw new FormatException("Invalid number " + formatException.Message);
        }
            
        catch (OverflowException)
        {
            Console.WriteLine("The input number is too big or too small!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }

    static void Main()
    {
        CalculateSqureRoot();
    }
}

