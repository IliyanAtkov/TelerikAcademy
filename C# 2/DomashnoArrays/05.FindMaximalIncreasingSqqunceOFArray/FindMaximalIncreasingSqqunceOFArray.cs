// Write a program that finds the maximal increasing sequence in an array.
// Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 
using System;



class FindMaximalIncreasingSqqunceOFArray
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
        int firstComparedNumber = 0;
        int secondComparedNumber = 0;
        
        Console.WriteLine("Enter the numbers of array");
        for (int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = int.Parse(Console.ReadLine());
        }

        // Finding The Maximal Increasing Sequnce Of Array
        for (int i = 0; i < theArray.Length - 1; i++)
        {
            firstComparedNumber = theArray[i];
            secondComparedNumber = theArray[i + 1];
            if (firstComparedNumber + 1 == secondComparedNumber)
	        {
                len++;
              
	        }
            if (len > 1)
            {
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
   

        }
        // Print The Maximal Increasing Sequnce of Array
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write("{0},", theArray[i]);
        }
        Console.WriteLine();

    }
}

