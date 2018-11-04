using System;

namespace RowWithMax1sInSortedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Row with maximum ones in sorted boolean matrix!");
            Console.WriteLine("-----------------------------------------------");

            try
            {
                int[,] inputMatrix = GetInput();
                MatrixProcessor matrixProcessor = new MatrixProcessor(inputMatrix);
                matrixProcessor.GetRowWithMaximumOnes();
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();

        }

        private static int[,] GetInput() {

            int[,] matrix = null;

            Console.WriteLine("Enter the number of rows in the matrix");
            try
            {
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the columns of the matrix");
                int columns = int.Parse(Console.ReadLine());
                matrix = new int[rows, columns];
                for (int i = 0; i < rows; i++) {
                    Console.WriteLine("Enter the elements of row "+i+" separated by space");
                    String enteredElements = Console.ReadLine();
                    String[] elements = enteredElements.Split(' ');
                    for (int j = 0; j < elements.Length; j++) {
                        matrix[i, j] = int.Parse(elements[j]);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return matrix;
        }
    }
}
