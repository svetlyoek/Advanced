using System;
using System.Linq;

namespace Diagonal_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            int result = 0;

            int[,] squareArr = new int[rowsAndCols, rowsAndCols];

            for(int row=0;row<rowsAndCols;row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for(int col=0;col<rowsAndCols;col++)
                {
                    squareArr[row, col] = numbers[col];
                }
            }

            int firstDiagRow = 0;
            int firstDiagCol = 0;
            while(true)
            {
                firstDiagonalSum += squareArr[firstDiagRow, firstDiagCol];
                if(firstDiagRow<rowsAndCols-1&&firstDiagCol<rowsAndCols-1)
                {
                    firstDiagRow++;
                    firstDiagCol++;
                }
                else
                {
                    break;
                }
            }

            int secondDiagRow = 0;
            int secondDiagCol = rowsAndCols-1;
            while (true)
            {
               secondDiagonalSum += squareArr[secondDiagRow, secondDiagCol];
                if (secondDiagRow < rowsAndCols - 1 && secondDiagCol >0)
                {
                    secondDiagRow++;
                    secondDiagCol--;
                }
                else
                {
                    break;
                }
            }

            result = Math.Abs(firstDiagonalSum - secondDiagonalSum);
            Console.WriteLine(result);
        }
    }
}
