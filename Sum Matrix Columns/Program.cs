using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];
          
            for (int row = 0; row < input[0]; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int column = 0; column < input[1]; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
            }
            
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int columnSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    columnSum += matrix[row, column];
                }
                Console.WriteLine(columnSum);
            }
        }
    }
}
