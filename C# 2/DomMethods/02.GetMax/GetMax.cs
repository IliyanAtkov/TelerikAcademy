// Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them
// using the method GetMax().


using System;


class GetMax
{
    public static int EnterNumber()
    {
        Console.Write("Enter number: ");
        return (int.Parse(Console.ReadLine()));
    }
    static int BiggestNumber(int num1, int num2)
    {
        int biggest = num1;
        if (num2 > biggest)
        {
            biggest = num2;
        }
        return biggest;
    }

    static void Main()
    {
        int numberOne = EnterNumber();
        int numberTwo = EnterNumber();
        int numberThree = EnterNumber();
        int big;

        big = BiggestNumber(numberOne, numberTwo);
        big = BiggestNumber(big, numberThree);
        Console.WriteLine(big);
    }
}
