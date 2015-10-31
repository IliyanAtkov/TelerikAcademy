//Write a program that fills and prints a matrix of size
// (n, n) as shown below: (examples for n = 4)


using System;



class FillAndPrintMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        FillMatrixD(matrix, n); // Change that to FillMatrixA, B, C or D!!!

    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    static void FillMatrixA(int[,] matrix, int sizeMatrix)
    {
        Console.WriteLine();
        Console.WriteLine("Matrix of type A:");
        Console.WriteLine();
        int currentNumber = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            currentNumber = row + 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentNumber;
                currentNumber += sizeMatrix;
            }
        }
        PrintMatrix(matrix);
    }
   static void FillMatrixB(int[,] matrix, int sizeMatrix)
    {
        Console.WriteLine();
        Console.WriteLine("Matrix of type B:");
        Console.WriteLine();
       
        int currentNumber = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {

            if (col % 2 == 0)
            {
                for (int row = 0; row < sizeMatrix; row++)
                {
                    matrix[row, col] = currentNumber++;
                }
            }
            else
            {
                for (int row = sizeMatrix - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentNumber++;
                }
            }
            
        }
        PrintMatrix(matrix);
    }
    static void FillMatrixC(int[,] matrix, int sizeMatrix)
   {
       Console.WriteLine();
       Console.WriteLine("Matrix of type C:");
       Console.WriteLine();
       int y = 0;
       int x = sizeMatrix - 1;
       for (int currentNumber = 1; currentNumber <= sizeMatrix * sizeMatrix; currentNumber++)
       {
           matrix[x++, y++] = currentNumber;

           if (x == sizeMatrix || y == sizeMatrix)
           {
               x--;
               if (y == sizeMatrix)
               {
                   x--;
                   y--;
               }
               while (x - 1 >= 0 && y - 1 >= 0)
               {
                   x--;
                   y--;
               }
           }
       }
       PrintMatrix(matrix);
   }
    public static void FillMatrixD(int[,] matrix, int sizeMatrix)
    {
        Console.WriteLine();
        Console.WriteLine("Matrix of type D:");
        Console.WriteLine();
        int x = 0;
        int y = 0;
        int direction = 0;
        int dx = 1;
        int dy = 0;
        for (int currentValue = 1; currentValue <= sizeMatrix * sizeMatrix; currentValue++)
        {
            matrix[x, y] = currentValue;

            if (!IsValidCell(sizeMatrix, x + dx, y + dy) || matrix[x + dx, y + dy] > 0)
            {
                direction = (++direction) % 4;
                if (direction == 0)
                {
                    dx = 1;
                    dy = 0;
                }
                else if (direction == 1)
                {
                    dx = 0;
                    dy = 1;
                }
                else if (direction == 2)
                {
                    dx = -1;
                    dy = 0;
                }
                else if (direction == 3)
                {
                    dx = 0;
                    dy = -1;
                }
                else
                {
                    Console.WriteLine("Invalid direction value: {0}", direction);
                }
            }

            x += dx;
            y += dy;
        }

        PrintMatrix(matrix);
    }

    public static bool IsValidCell(int n, int x, int y)
    {
        return x >= 0 && x < n && y >= 0 && y < n;
    }
    
    
}

