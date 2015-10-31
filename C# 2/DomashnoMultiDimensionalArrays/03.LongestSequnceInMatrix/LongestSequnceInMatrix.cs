// We are given a matrix of strings of size N x M.
// Sequences in the matrix we define as sets of several neighbor elements located
// on the same line, column or diagonal. Write a program that finds the longest sequence
// of equal strings in the matrix

using System;


class LongestSequnceInMatrix
{
    static void Main()
    {
       // Console.Write("Enter N: ");
       // int n = int.Parse(Console.ReadLine());
      //  Console.Write("Enter M: ");
       // int m = int.Parse(Console.ReadLine());

        string[,] matrix = 
        {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"}
        };
    
     //   Console.WriteLine("Entet the matrix: ");
      //  for (int row = 0; row < matrix.GetLength(0); row++)
     //   {
     //       for (int col = 0; col < matrix.GetLength(1); col++)
      //      {
     //           Console.Write("row[{0}] col[{1}] = ", row, col);
       //         matrix[row, col] = Console.ReadLine();
      //      }

      //  }

        FindingLongestSequnceInMatrix(matrix);
    }
    static void PrintTheSequnce(string bestString, int maxStringRepeat)
    {
        for (int i = 0; i < maxStringRepeat; i++)
        {
            Console.Write("{0} ,", bestString);
        }
        Console.WriteLine();
    }
    static void FindingLongestSequnceInMatrix(string[,] matrix)
    {
        int maxStringRepeat = int.MinValue;
        string currentString;
        string bestString = "";
        int countTheString = 1;
        
        

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int counter = 1;
                
                currentString = matrix[row, col];
              
                if (col != matrix.GetLength(1) - 1)
                {
                    if (matrix[row, col + counter] == currentString)
                    {
                        countTheString++;
                        if (countTheString > maxStringRepeat)
                        {
                            bestString = currentString;
                            maxStringRepeat = countTheString;
                        }
                    }
                }
                if (row != matrix.GetLength(0) - 1)
                {
                    if (matrix[row + counter, col] == currentString)
                    {
                        countTheString++;
                        if (countTheString > maxStringRepeat)
                        {   
                            bestString = currentString;
                            maxStringRepeat = countTheString;
                        }
                    }
                }
                if (col != matrix.GetLength(1) - 1 && row != matrix.GetLength(0) - 1)
                {
                    if (matrix[row + counter, col + counter] == currentString)
                    {
                        countTheString++;
                        if (countTheString > maxStringRepeat)
                        {   
                            bestString = currentString;
                            maxStringRepeat = countTheString;
                        }
                    }
                }
            }
        }
        PrintTheSequnce(bestString, maxStringRepeat);
    }
}