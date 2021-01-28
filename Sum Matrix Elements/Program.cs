using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];
            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);

            for (int row = 0; row < input[0]; row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int column = 0; column < input[1]; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
            }
            int sum = 0;
            for (int row = 0; row < input[0]; row++)
            {
                for (int column = 0; column < input[1]; column++)
                {
                    sum += matrix[row, column];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
