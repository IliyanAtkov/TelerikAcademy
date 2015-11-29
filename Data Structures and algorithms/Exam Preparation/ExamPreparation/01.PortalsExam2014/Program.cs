namespace _01.PortalsExam2014
{
    using System;

    public class Program
    {
        static int[,] matrix;
        static int bestSum = 0;

        public static void Main()
        {
            string[] startPosition = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int startRow = int.Parse(startPosition[0]);
            int startCol = int.Parse(startPosition[1]);
            GetMatrix();
            Console.WriteLine(Calculate(startRow, startCol));

        }

        private static int Calculate(int row, int col)
        {
            int sum = 0;
            int currentNumber = matrix[row, col];

            matrix[row, col] = 5555;

            if (col - currentNumber >= 0 && matrix[row, col - currentNumber] != 5555)
            {
 
                sum += Calculate(row, col - currentNumber);
                sum += currentNumber;
            }

            else if (row + currentNumber < matrix.GetLength(0) && matrix[row + currentNumber, col] != 5555)
            {
                sum += Calculate(row + currentNumber, col);
                sum += currentNumber;
            }

            else if (col + currentNumber < matrix.GetLength(1) && matrix[row, col + currentNumber] != 5555)
            {
                sum += Calculate(row, col + currentNumber);
                sum += currentNumber;
            }

            else if (row - currentNumber >= 0 && matrix[row - currentNumber, col] != 5555)
            {
                sum += Calculate(row - currentNumber, col);
                sum += currentNumber;
            }

            if (sum > bestSum)
            {
                bestSum = sum;
            }

            return bestSum;
        }

        private static void GetMatrix()
        {

            string[] matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int matrixRowSize = int.Parse(matrixSize[0]);
            int matrixColSize = int.Parse(matrixSize[1]);
            matrix = new int[matrixRowSize, matrixColSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentNumber = rowNumbers[col];
                    if (currentNumber == "#")
                    {
                        matrix[row, col] = 5555;
                    }
                    else
                    {
                        matrix[row, col] = int.Parse(currentNumber);
                    }
                }
            }
        }
    }
}
