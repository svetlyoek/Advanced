using System;
using System.Linq;

namespace Square_with_maximum_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSizes[0];
            int cols = matrixSizes[1];
            int maxSum = int.MinValue;
            int sum = 0;
            int[,] arr = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowInArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = rowInArr[col];

                }

            }
            var currentFirstFirst = 0;
            var currentFirstSecond = 0;
            var currentSecondFirst = 0;
            var currentSecondSecond = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    currentFirstFirst = arr[i, j];
                    currentFirstSecond = arr[i, j + 1];
                    currentSecondFirst = arr[i + 1, j];
                    currentSecondSecond = arr[i + 1, j + 1];
                    sum = currentFirstFirst + currentFirstSecond + currentSecondFirst + currentSecondSecond;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }
            for (int row=maxRowIndex;row<=maxRowIndex+1;row++)
            {
                for(int col=maxColIndex;col<=maxColIndex+1;col++)
                {
                    Console.Write($"{arr[row,col]} ");
                }
                Console.WriteLine();
            }
                Console.WriteLine(maxSum);
        }
    }
}
