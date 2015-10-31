// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SequnceOfGivenSum
{
    static void FindTheSum(int sum, int[] array)
    {

        
        for (int i = 0; i < array.Length; i++)
        {
            int momentSum = 0;
            int start = i;
            momentSum += array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                
                
                if (momentSum > sum)
                {
                    break;
                }
              
                 momentSum += array[j];
               

                if (momentSum == sum)
                {
                    Console.Write("For S = {0} the sum is ", sum);
                    for (int k = start; k <= j; k++)
                    {
                       
                        Console.Write("{0}, ", array[k]);
                    }
                    Console.WriteLine();
                    return;
                }
               
            }
           
            
        }
      
    }

    static void Main()
    {
        Console.Write("Enter the sum you are looking for: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        FindTheSum(sum, array);

    }
}

