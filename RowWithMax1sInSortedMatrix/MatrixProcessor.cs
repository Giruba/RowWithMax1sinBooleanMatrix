using System;
using System.Collections.Generic;
using System.Text;

namespace RowWithMax1sInSortedMatrix
{
    class MatrixProcessor
    {
        int[,] matrix;

        public MatrixProcessor(int[,] incomingMatrix) {
            matrix = incomingMatrix;
        }

        public void GetRowWithMaximumOnes() {

            Console.WriteLine("-----The Input Matrix-----");
            PrintMatrix(matrix);

            if (isSortedMatrix())
            {
                int maxOneRow = FindRowWithMaxOnes();
                if (maxOneRow != -1)
                {
                    Console.WriteLine("Row with the maximum number of ones is " + maxOneRow);
                }
                else {
                    Console.WriteLine("None of the rows have maximum ones!");
                }
            }
            else {
                Console.WriteLine("Entered matrix is not sorted!");
            }

        }

        private bool isSortedMatrix() {

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    if (j + 1 < columns)
                    {
                        if ((matrix[i, j] == 1) &&(matrix[i, j + 1] == 0))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        
        private void PrintMatrix(int[,] inputMatrix) {
            for (int i = 0; i < inputMatrix.GetLength(0); i++) {
                for (int j = 0; j < inputMatrix.GetLength(1); j++) {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
        }

        private int FindRowWithMaxOnes() {
            int indexOfOne = 0;
            int rowWithMax1s = -1;
            int maxOnes = 0;
            for (int i = 0; i < matrix.GetLength(1); i++) {
                if (matrix[0, i] == 1) {
                    indexOfOne = i;
                    rowWithMax1s = 0;
                    maxOnes = matrix.GetLength(1) - indexOfOne;
                    break;
                }
            }

            if (rowWithMax1s == -1) {
                indexOfOne = matrix.GetLength(1) - 1;
            }

            for (int i = 1; i < matrix.GetLength(1); i++) {
                while (matrix[i, indexOfOne] == 1) {
                    indexOfOne--;
                }
                if ((matrix.GetLength(1) - indexOfOne) > maxOnes)
                {
                    rowWithMax1s = i;
                    maxOnes = (matrix.GetLength(1) - indexOfOne);
                }
            }

            return rowWithMax1s;
        }
    }
}
