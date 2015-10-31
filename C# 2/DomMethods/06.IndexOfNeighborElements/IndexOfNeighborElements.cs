// Write a method that returns the index of the first element in array that is bigger
// than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;



class IndexOfNeighborElements
{
    static void FindTwoNeighbors(int[] array)
    {
        int rightNumber = 0;
        int leftNumber = 0;
        int findNeighbor = 0;
      
        for (int i = 0; i < array.Length - 1; i++)
        {



            if (CheckIfInArray(array, i + 1))
            {
                rightNumber = array[i + 1];
            }
            if (CheckIfInArray(array, i - 1))
            {
                leftNumber = array[i - 1];
            }
            
           
            if (array[i] > rightNumber && array[i] > leftNumber)
            {
                findNeighbor = 1;
                Console.WriteLine("Index position: {0}  Number at that position: {1}", i, array[i]);
                break;
            }
            

            
            
        }

        if (findNeighbor == 0)
        {
            Console.WriteLine("-1");
        }
    }
    static bool CheckIfInArray(int[] array, int index)
    {
        return 0 <= index && index < array.Length;
    }

   //// static int[] EnterArray()
   //// {
   ////     Console.Write("Enter the size of array: ");
   ////     int size = int.Parse(Console.ReadLine());
   ////     Console.WriteLine("Enter the array");
   ////     int[] array = new int[size];
   ////     for (int i = 0; i < array.Length; i++)
   ////     {
   ////         array[i] = int.Parse(Console.ReadLine());
   ////     }
   ////     return array;
   //// }
    static void Main()
    {
        
       // int[] array = EnterArray();
        int[] array = { 1, 1, 1, 19, 342, 23, 43, 123, 32, 76, 123, 856, 34, 96, 34, 89, 45, 12, 9, 19, 36, 18, 23, 74, 98, 786, 123};
        FindTwoNeighbors(array);
    }
}

