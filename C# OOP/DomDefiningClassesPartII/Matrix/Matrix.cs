﻿namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Matrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>, new ()
    {
        private int row;
        private int col;
        private T[,] matrix;

        public Matrix()
        {
            matrix = new T[6, 6];
        }

        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0) throw new ArgumentOutOfRangeException("Negative row or col value");
            else
            {
                this.row = row;
                this.col = col;
                matrix = new T[row, col];
            }
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            row = matrix.GetLength(0);
            col = matrix.GetLength(1);
        }

        public T this[int row, int col]
        {
            get
            {
                if (Row < row || Col < col || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("The index was not inside boundaries of matrix!");
                }
                return matrix[row, col];

            }

            set
            {
                if (Row < row || Col < col || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("The index was not inside boundaries of matrix!");

                }
                matrix[row, col] = value;
            }
        }

        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The row cannot be less than zero!");
                }
                this.row = value;
            }
        }

        public int Col
        {
            get { return this.col; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The col cannot be less than zero!");
                }
                this.col = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.row == second.row && first.col == second.col)
            {
                Matrix<T> temp = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {                
                    for (int j = 0; j < first.col; j++)
                    {
                        checked
                        {

                            temp[i, j] = (dynamic)first[i, j] + second[i, j];
                        }
                    }
                }
                return temp;
            }
            else
            {
                throw new ArgumentException("Matrixes are not with same size!");
            }
           
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.row == second.row && first.col == second.col)
            {
                Matrix<T> temp = new Matrix<T>(first.row, first.col);
                for (int i = 0; i < first.row; i++)
                {
                    for (int j = 0; j < first.col; j++)
                    {
                        checked
                        {

                            temp[i, j] = (dynamic)first[i, j] - second[i, j];
                        }
                    }
                }
                return temp;
            }
            else
            {
                throw new ArgumentException("Matrixes are not with same size!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Row)
            {
                Matrix<T> result = new Matrix<T>(first.Row, second.Col);
                for (int i = 0; i < result.Row; i++)
                {
                    for (int j = 0; j < result.Col; j++)
                    {
                        result[i, j] = (dynamic)0;
                        for (int k = 0; k < first.Col; k++)
                        {
                            checked
                            {
                                result[i, j] = result[i, j] + (dynamic)first[i, k] * second[k, j];
                            }
                        }
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("Matrixes are not with same size!");
            }
        }

        public static Boolean operator true(Matrix<T> matrix)
        {
            int checker = 0;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == checker)
                    {
                        return false;
                       
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            int checker = 0;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] == checker)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    builder.Append(matrix[i, j] + " ");
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

    }
}
