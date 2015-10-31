// Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;



class Program
{

    static void Main()
    {
        Console.Write("What size of the array do you want: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] theArray = new int[arraySize];
        int bestStart = 0;
        int bestLen = 1;
        int start = 0;
        int len = 1;
        Console.WriteLine("Enter the numbers of array");
        for (int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = int.Parse(Console.ReadLine());
        }

        // Finding The Maximal Sequnce Of Array
        for (int i = 0; i < theArray.Length - 1; i++)
        {
            
            if (theArray[i] == theArray[i + 1])
            {
                
                len++;
                if (len == 2)
                {
                    start = i;
                    
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            else
            {
                 start = 0;
                 len = 1;
            }
        }

       // Print The Maximal Sequnce of Array
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write("{0},", theArray[i]);
        }
        Console.WriteLine();
      
    }

   
}

