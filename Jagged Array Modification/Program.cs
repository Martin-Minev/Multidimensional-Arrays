using System;
using System.Linq;

namespace Jagged_Array_Modification
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
                for (int column = 0; column < currentRow.Length; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split();
                
                int row = int.Parse(cmdArgs[1]);
                int column = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                if (row >= 0 && column >= 0 && row < n && column < n)
                {
                    switch (cmdArgs[0])
                    {
                        case "Add":
                            matrix[row, column] += value;
                            break;
                        case "Subtract":
                            matrix[row, column] -= value;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }

            //int [][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[1];
            //jaggedArray[2] = new int[3];
            //for (int row = 0; row < jaggedArray.Length; row++)
            //{
            //    for (int column = 0; column < jaggedArray[row].Length; column++)
            //    {
            //        jaggedArray[row][column] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int row = 0; row < jaggedArray.Length; row++)
            //{
            //    for (int column = 0; column < jaggedArray[row].Length; column++)
            //    {
            //        Console.Write(jaggedArray[row][column] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
