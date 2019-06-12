using System;
using System.Linq;

namespace Squares_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int equalPairCounter = 0;
           char [,] arr = new char[rows, cols];
            for(int row=0;row<rows;row++)
            {
                char[] characters = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for(int col=0;col<cols;col++)
                {
                    arr[row, col] = characters[col];
                }
            }

            for(int row=0;row<rows-1;row++)
            {
                for(int col=0;col<cols-1;col++)
                {
                    if (arr[row, col] == arr[row , col+1] && arr[row ,col]==arr[row+1,col]&&arr[row,col]==arr[row+1,col+1])
                    {
                        equalPairCounter++;
                    }
                }
            }
            Console.WriteLine(equalPairCounter);
        }
    }
}
