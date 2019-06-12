using System;
using System.Linq;

namespace Sum_matrix_columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int sum = 0;
            int[,] arr = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = numbers[col];
                  
                }

            }
           for(int col=0;col<cols;col++)
            {
               
                for(int row=0;row<rows;row++)
                {
                    sum += arr[row, col];
                   
                }
               
                Console.WriteLine(sum);
                sum = 0;
            }
          
        }
    }
}

