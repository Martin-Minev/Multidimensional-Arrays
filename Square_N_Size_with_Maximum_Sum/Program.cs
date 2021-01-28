using System;
using System.Linq;

namespace Square_N_Size_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3; // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < input[0]; row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int column = 0; column < input[1]; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColumnIndex = 0;
 
            for (int row = 0; row < input[0] - n + 1; row++)
            {
                for (int column = 0; column < input[1] - n + 1; column++)
                {
                    int squareSum = 0;
                    for (int squareRow = row; squareRow < row + n; squareRow++)
                    {
                        for (int squareColumn = column; squareColumn < column + n; squareColumn++)
                        {
                            squareSum += matrix[squareRow, squareColumn];
                        }
                    }
                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxRowIndex = row;
                        maxColumnIndex = column;
                    }
                }
            }

            for (int row = maxRowIndex; row < maxRowIndex + n; row++)
            {
                for (int column = maxColumnIndex; column < maxColumnIndex + n; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
