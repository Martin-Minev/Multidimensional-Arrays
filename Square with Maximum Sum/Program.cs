using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
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
            for (int row = 0; row < input[0] - 1; row++)
            {
                for (int column = 0; column < input[1] - 1; column++)
                {
                    int squareSum = matrix[row, column] + matrix[row, column + 1]
                                    + matrix[row + 1, column] + matrix[row + 1, column + 1];
                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxRowIndex = row;
                        maxColumnIndex = column;
                    }
                }
            }
            
            for (int row = maxRowIndex; row < maxRowIndex + 2; row++)
            {
                for (int column = maxColumnIndex; column < maxColumnIndex + 2; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
