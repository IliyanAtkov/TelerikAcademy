// Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FrequentNumber
{
    static void MostFrequentNumberInArray(int[] array)
    {
        int max = int.MinValue;
        int number = 0;
        int maxCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int counter = 0;
            number = array[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (number == array[j])
                {
                    counter++;
                }
                if (counter > maxCounter)
	            {
                    max = number;
		            maxCounter = counter;
	            }       
            }
            
            
            
        }
        Console.WriteLine("{0}, ({1}) times", max, maxCounter);
        
        
    }
    static void Main()
    {
        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        MostFrequentNumberInArray(array);
    }
}

