using System;
using System.Linq;

namespace Primary_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int sum = 0;
            int[,] arr = new int[rowsAndCols, rowsAndCols];

            for (int row = 0; row < rowsAndCols; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < rowsAndCols; col++)
                {


                    arr[row, col] = numbers[col];

                }

            }

            int currentRow = 0;
            int currentCol = 0;
            while (true)
            {
                sum += arr[currentRow, currentCol];
                if (currentRow < rowsAndCols - 1 && currentCol < rowsAndCols - 1)
                {
                    currentCol++;
                    currentRow++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
