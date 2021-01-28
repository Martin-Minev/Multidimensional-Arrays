using System;
using System.Collections.Generic;
using System.Linq;

namespace Symbol_in_Matrix  // 80/100
{
    class Program
    {
        static void Main(string[] args) // 80/100
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<char> currentRow = new List<char>();
            bool exist = false;
            int rowTarget = 0;
            int columnTarget = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    currentRow.Add(input[i]);
                }
                for (int column = 0; column < n; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
                currentRow.Clear();
            }
            char target = char.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (matrix[row, column] == target)
                    {
                        exist = true;
                        rowTarget = row;
                        columnTarget = column;
                    }
                }
            }
            if (exist)
            {
                Console.WriteLine($"({rowTarget}, {columnTarget})");
            }
            else
            {
                Console.WriteLine($"{target} does not occur in the matrix ");
            }
        }
    }
}
