using System;
using System.Linq;

namespace Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            long[,] arr = new long[rows, cols];
            long sum = 0;
            long maxSum = long.MinValue;

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = numbers[col];
                }
            }

            int lastRowIndex = (rows - 1);
            int stopRowIndex = (lastRowIndex - 3) + 1;
            int lastColIndex = cols - 1;
            int stopColIndex = (lastColIndex - 3) + 1;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row <= stopRowIndex; row++)
            {
                for (int col = 0; col <= stopColIndex; col++)
                {
                    sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] + arr[row + 1, col]
                        + arr[row + 1, col + 1] + arr[row + 1, col + 2] + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{arr[startRow, startCol]} {arr[startRow, startCol + 1]} {arr[startRow, startCol + 2]}");
            Console.WriteLine($"{arr[startRow + 1, startCol]} {arr[startRow + 1, startCol + 1]} {arr[startRow + 1, startCol + 2]}");
            Console.WriteLine($"{arr[startRow + 2, startCol]} {arr[startRow + 2, startCol + 1]} {arr[startRow + 2, startCol + 2]}");

        }
    }
}
