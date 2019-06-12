using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] arr = new int[matrixSize, matrixSize];
            int aliveCellsSum = 0;
            int aliveCellsCounter = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    arr[row, col] = numbers[col];
                }
            }

            string[] bombCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int bombValue = 0;

            for (int i = 0; i < bombCoordinates.Length; i++)
            {

                string[] current = bombCoordinates[i].Split(",").ToArray();
                int bombRow = int.Parse(current[0]);
                int bombCol = int.Parse(current[1]);

                for (int row = 0; row < matrixSize; row++)
                {
                    for (int col = 0; col < matrixSize; col++)
                    {
                        if (row == bombRow && col == bombCol)
                        {
                            if (arr[bombRow, bombCol] > 0)
                            {
                                bombValue = arr[bombRow, bombCol];
                                arr[bombRow, bombCol] = 0;

                                if (bombRow - 1 >= 0 && bombRow - 1 < matrixSize && bombCol - 1 >= 0 && bombCol - 1 < matrixSize && arr[bombRow - 1, bombCol - 1] > 0)
                                {
                                    arr[bombRow - 1, bombCol - 1] -= bombValue;

                                }
                                if (bombRow - 1 >= 0 && bombRow - 1 < matrixSize && bombCol + 1 >= 0 && bombCol + 1 < matrixSize && arr[bombRow - 1, bombCol + 1] > 0)
                                {
                                    arr[bombRow - 1, bombCol + 1] -= bombValue;

                                }
                                if (bombRow >= 0 && bombRow < matrixSize && bombCol - 1 >= 0 && bombCol - 1 < matrixSize && arr[bombRow, bombCol - 1] > 0)
                                {
                                    arr[bombRow, bombCol - 1] -= bombValue;

                                }
                                if (bombRow + 1 >= 0 && bombRow + 1 < matrixSize && bombCol - 1 >= 0 && bombCol - 1 < matrixSize && arr[bombRow + 1, bombCol - 1] > 0)
                                {
                                    arr[bombRow + 1, bombCol - 1] -= bombValue;

                                }
                                if (bombRow + 1 >= 0 && bombRow + 1 < matrixSize && bombCol >= 0 && bombCol < matrixSize && arr[bombRow + 1, bombCol] > 0)
                                {
                                    arr[bombRow + 1, bombCol] -= bombValue;

                                }
                                if (bombRow + 1 >= 0 && bombRow + 1 < matrixSize && bombCol + 1 >= 0 && bombCol + 1 < matrixSize && arr[bombRow + 1, bombCol + 1] > 0)
                                {
                                    arr[bombRow + 1, bombCol + 1] -= bombValue;

                                }
                                if (bombRow >= 0 && bombRow < matrixSize && bombCol + 1 >= 0 && bombCol + 1 < matrixSize && arr[bombRow, bombCol + 1] > 0)
                                {
                                    arr[bombRow, bombCol + 1] -= bombValue;

                                }
                                if (bombRow - 1 >= 0 && bombRow - 1 < matrixSize && bombCol >= 0 && bombCol < matrixSize && arr[bombRow - 1, bombCol] > 0)
                                {
                                    arr[bombRow - 1, bombCol] -= bombValue;


                                }


                            }
                        }
                    }
                }
            }


            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (arr[row, col] > 0)
                    {
                        aliveCellsCounter++;
                        aliveCellsSum += arr[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCounter}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (col < matrixSize - 1)
                    {
                        Console.Write($"{arr[row, col]} ");
                    }
                    else if (col == matrixSize - 1)
                    {
                        Console.Write($"{arr[row, col]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
