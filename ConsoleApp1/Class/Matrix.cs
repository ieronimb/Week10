using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Classses
{
    /*Problem 4. Matrix
    Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).*/
    public class Matrix<T> where T : IComparable
    {
        // Campuri
        private int row;
        private int col;
        private T[,] matrix;

        // Proprietati
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }

        // Constructor
        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException("Negative value!");
            }
            else
            {
                this.row = row;
                this.col = col;
                this.matrix = new T[row, col];
            }
        }

        /*Problem 5. Matrix indexer
    Implement an indexer this[row, col] to access the inner matrix cells.*/
      
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || col < 0) || (row > Row || col > Col))
                {
                    throw new ArgumentOutOfRangeException("Index out of range!");
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range!");
                }
                else
                {
                    matrix[row, col] = value;
                }
            }
        }
        public void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}
