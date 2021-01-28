using System;
using System.Linq;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];
            for (int row = 0; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                for (int column = 0; column < row + 1; column++)
                {
                    long currentSum = 0;
                    if (row - 1 >= 0 && column < pascalTriangle[row - 1].Length)
                    {
                        currentSum += pascalTriangle[row - 1][column];
                    }
                    if (row - 1 >= 0 && column - 1 >= 0)
                    {
                        currentSum += pascalTriangle[row - 1][column - 1];
                    }
                    if (currentSum==0)
                    {
                        currentSum = 1;
                    }
                    pascalTriangle[row][column] = currentSum;
                }
            }
            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                for (int column = 0; column < pascalTriangle[row].Length; column++)
                {
                    Console.Write(pascalTriangle[row][column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
