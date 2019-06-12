using System;

namespace Knight_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimensions, dimensions];
            int removedKnights = 0;
            int currentDangerKnights = 0;
            int maxDangerKnights = int.MinValue;
            int mostDangerousRow = -1;
            int mostDangerousCol = -1;


            for (int row = 0; row < dimensions; row++)
            {
                char[] lines = Console.ReadLine().ToCharArray();

                for (int col = 0; col < dimensions; col++)
                {
                    matrix[row, col] = lines[col];
                }
            }

            while(true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if(matrix[row,col]=='K')
                        {
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row - 2 >= 0 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row - 1 >= 0 && col + 2 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row + 1 <= matrix.GetLength(0) - 1 && col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row + 2 <= matrix.GetLength(0) - 1 && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row + 2 <= matrix.GetLength(0) - 1 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                            if (row + 1 <= matrix.GetLength(0) - 1 && col + 2 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    currentDangerKnights++;
                                }
                            }

                        }
                       
                        if (currentDangerKnights > maxDangerKnights)
                        {
                            maxDangerKnights = currentDangerKnights;
                            mostDangerousRow = row;
                            mostDangerousCol = col;
                        }

                        currentDangerKnights = 0;
                    }
                }

                if(maxDangerKnights!=0)
                {
                    matrix[mostDangerousRow, mostDangerousCol] ='O';
                    removedKnights++;
                    maxDangerKnights = 0;
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    return;
                }
            }
        }
    }
}
