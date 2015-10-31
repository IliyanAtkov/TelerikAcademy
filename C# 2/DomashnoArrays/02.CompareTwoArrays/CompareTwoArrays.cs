// Write a program that reads two arrays from the console and compares them element by element.


using System;


class CompareTwoArrays
{
   
    static void Main()
    {
        Console.Write("What size you want for the both arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] firstArray = new int[size];
        int[] secondArray = new int[size];

       

        Console.WriteLine("Enter first array: ");
        for (int i = 0; i < size; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("Enter the second array: ");
        for (int i = 0; i < size; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
            
        }
        for (int i = 0; i < size; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Both elements are equal {0} == {1}", firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("The number of the first array is bigger {0} > {1}", firstArray[i], secondArray[i]);

            }
            else
            {
                Console.WriteLine("The number of the second array is bigger {0} < {1}", firstArray[i], secondArray[i]);

            }


        }
       
    }
}

