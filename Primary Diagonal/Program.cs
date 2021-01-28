using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int column = 0; column < n; column++)
                {
                    matrix[row, column] = currentRow[column];
                }

            }
            int diagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int column = row; column < n; column++)
                {
                    diagonalSum += matrix[row, column];
                    break;
                }
                
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
