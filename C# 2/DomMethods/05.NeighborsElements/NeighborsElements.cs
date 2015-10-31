// Write a method that checks if the element at given position in given array of
// integers is bigger than its two neighbors (when such exist).


using System;

class NeighborsElements
{
    static void FindTwoNeighbors(int[] array, int index)
    {
        int rightNumber = 0;
        int leftNumber = 0;
        bool check = CheckIfInArray(array, index);
        if (check == false)
        {
            Console.WriteLine("Index was outside the boundary of array!");
        }
        else
        {
            
                if (CheckIfInArray(array, index + 1))
                {
                    rightNumber = array[index + 1];
                }
                else
                {
                    Console.WriteLine("There is no rightNeighbor");
                }

                if (CheckIfInArray(array, index - 1))
                {
                    leftNumber = array[index - 1];
                }
                else
                {
                    Console.WriteLine("There is no leftNeigbhor");
                }

                if (rightNumber > array[index] && rightNumber > leftNumber)
                {
                    Console.WriteLine("The right number is bigger it is: {0}", rightNumber);
                }
                else if (leftNumber > array[index] && leftNumber > rightNumber)
                {
                    Console.WriteLine("The left number si bigger it is: {0}", leftNumber);
                }
                else
                {
                    Console.WriteLine("The number in the index position is bigger than his two neighbors it is:{0}", array[index]);
                }
            
        }
        
    }
    static bool CheckIfInArray(int[] array, int index)
    {
        return 0 <= index && index < array.Length;
    }
    static void Main()
    {
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        int[] array = {3,5,1,19,342,23,43,123,32,76,123,856,34,96,34,89,45,12,9,19,36,18,23,74,98,786,123};
        FindTwoNeighbors(array, index);

    }
}