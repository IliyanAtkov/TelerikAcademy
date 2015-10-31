// Write a program that reads a text file containing a square matrix of
// numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of
// its elements. The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space. The output
// should be a single number in a separate text file. Example:
// 4
// 2 3 3 4
// 0 2 3 4		>>	17
// 3 7 1 2
// 4 3 3 2


using System;
using System.IO;

class MatrixFromTextFile
{

    static void TextMatrix()
    {
        using (StreamReader text = new StreamReader("matrix.txt"))
        {

            string size = text.ReadLine();
            string numbersMatrix;
            int sizeOfMatrix = int.Parse(size);
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int currentRow = 0;
            while ((numbersMatrix = text.ReadLine()) != null)
            {

                string[] doneMatrix = numbersMatrix.Split(' ');
                for (int i = 0; i < doneMatrix.Length; i++)
                {
                    matrix[currentRow, i] = int.Parse(doneMatrix[i]);
                }
                currentRow++;
            }

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }

                }

            }
            using (StreamWriter write = new StreamWriter("result.txt"))
            {
                write.WriteLine(bestSum);
            }
            Console.WriteLine(bestSum);
            Console.WriteLine("Text file with result is in Debug folder in the project folder!!!");

        }
    }
    static void Main()
    {
        TextMatrix();
    }
}
