using System;

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string direction = "right";
            int row = 0;
            int column = 0;
            for (int i = 0; i < n * n; i++)
            {
                matrix[row, column] = i + 1;
                if (direction == "right")
                {
                    column++;
                }
                if (direction == "left")
                {
                    column--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }
                if ((column == n || IsSpaceOccupied(matrix, row, column, n)) && direction == "right")
                {
                    column--;
                    row++;
                    direction = "down";
                }
                if ((row == n || IsSpaceOccupied(matrix, row, column, n)) && direction == "down")
                {
                    row--;
                    column--;
                    direction = "left";
                }
                if ((column == -1 || IsSpaceOccupied(matrix, row, column, n)) && direction == "left")
                {
                    column++;
                    row--;
                    direction = "up";
                }
                if ((row == -1 || IsSpaceOccupied(matrix, row, column, n)) && direction == "up")
                {
                    row++;
                    column++;
                    direction = "right";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(" " + matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static bool IsSpaceOccupied(int[,] matrix, int row, int column, int n)
        {
            return row >= 0 && column >= 0 && row < n && column < n && matrix[row, column] != 0;
        }
    }
}
