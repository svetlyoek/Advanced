using System;
using System.Linq;

namespace Sum_matrix_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsnAndCols = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsnAndCols[0];
            int cols = rowsnAndCols[1];
            int[,] arr = new int[rows, cols];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    arr[row, col] = numbers[col];
                    sum += arr[row, col];

                }

            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}

