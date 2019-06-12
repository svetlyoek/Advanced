using System;
using System.Linq;

namespace Bomb_the_basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombRow = bombs[0];
            int bombCol = bombs[1];
            int bombRange = bombs[2];
            int[,] arr = new int[rows, cols];

            for (int row=0;row<rows;row++)
            {
                for(int col=0;col<cols;col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

                    if(distance<=bombRange)
                    {
                        arr[row, col] = 1;
                    }
                   
                }
               
            }
            int[][] secondArr = new int[cols][];

            for(int row=0;row<cols;row++)
            {
                secondArr[row] = new int[rows];
                for(int col=0;col<rows;col++)
                {
                    secondArr[row][col] = arr[col,row];
                }
             secondArr[row]= secondArr[row].OrderByDescending(x => x).ToArray();
            }

            for(int row=0;row<rows;row++)
            {
                for (int col = 0; col<cols;col++)
                {
                    arr[row, col] = secondArr[col][row];
                    Console.Write(arr[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
