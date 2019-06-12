using System;
using System.Linq;

namespace Radioactive_mutant_vampire_bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            int playerRow = -1;
            int playerCol = -1;
            char[,] finalMatrix = new char[rows, cols];

            for(int row=0;row<rows;row++)
            {
                char[] lines = Console.ReadLine().ToCharArray();

                for (int col = 0;col<cols;col++)
                {
                    matrix[row, col] = lines[col];
                    finalMatrix[row, col] = '.';

                    if(matrix[row,col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }

            }

            char[] commands = Console.ReadLine().ToCharArray();

            for(int i=0;i<commands.Length;i++)
            {
                char command = (char)commands[i];

                if(command=='L')
                {
                    if(playerCol-1>=0)
                    {
                        matrix[playerRow, playerCol] = '.';

                        if(matrix[playerRow,playerCol-1]=='B')
                        {
                            playerCol = playerCol - 1;
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol-1] = 'P';
                            playerCol = playerCol - 1;
                        }
                    }

                    else 
                    {
                        return;
                    }
                }

                if (command == 'R')
                {
                    if (playerCol+1<=matrix.GetLength(1)-1)
                    {
                        matrix[playerRow, playerCol] = '.';

                        if (matrix[playerRow, playerCol + 1] == 'B')
                        {
                            playerCol = playerCol + 1;
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol + 1] = 'P';
                            playerCol = playerCol + 1;
                        }
                    }

                    else 
                    {
                        return;
                    }
                }

                if (command == 'U')
                {
                    if (playerRow - 1 >= 0)
                    {
                        matrix[playerRow, playerCol] = '.';

                        if (matrix[playerRow-1, playerCol ] == 'B')
                        {
                           playerRow=playerRow-1;
                            return;
                        }
                        else
                        {
                            matrix[playerRow-1, playerCol] = 'P';
                            playerRow = playerRow - 1;
                        }
                    }

                    else 
                    {
                        return;
                    }
                }

                if (command == 'D')
                {
                    if (playerRow +1<=matrix.GetLength(0)-1)
                    {
                        matrix[playerRow, playerCol] = '.';

                        if (matrix[playerRow + 1, playerCol] == 'B')
                        {
                            playerRow = playerRow + 1;
                            return;
                        }
                        else
                        {
                            matrix[playerRow + 1, playerCol] = 'P';
                            playerRow = playerRow + 1;
                        }
                    }

                    else
                    {
                        return;
                    }
                }


                for(int row=0;row<matrix.GetLength(0);row++)
                {
                    for(int col=0;col<matrix.GetLength(1);col++)
                    {

                        if(matrix[row,col]=='B')
                        {
                            finalMatrix[row, col] = 'B';

                            if(col-1>=0)
                            {
                                if(matrix[row,col-1]=='.')
                                {
                                    finalMatrix[row, col - 1] = 'B';
                                }
                                else if(matrix[row,col-1]=='P')
                                {
                                    finalMatrix[row, col - 1] = 'B';
                                    playerCol = playerCol - 1;
                                    return;
                                }
                            }

                            if (col + 1<=matrix.GetLength(1)-1)
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    finalMatrix[row, col + 1] = 'B';
                                }
                                else if (matrix[row, col + 1] == 'P')
                                {
                                    finalMatrix[row, col + 1] = 'B';
                                    playerCol = playerCol + 1;
                                    return;
                                }
                            }


                            if (row-1>=0)
                            {
                                if (matrix[row-1, col] == '.')
                                {
                                    finalMatrix[row-1, col] = 'B';
                                }
                                else if (matrix[row-1, col] == 'P')
                                {
                                    finalMatrix[row-1, col] = 'B';
                                    playerRow = playerRow - 1;
                                    return;
                                }
                            }

                            if (row +1<=matrix.GetLength(0)-1)
                            {
                                if (matrix[row + 1, col] == '.')
                                {
                                    finalMatrix[row + 1, col] = 'B';
                                }
                                else if (matrix[row + 1, col] == 'P')
                                {
                                    finalMatrix[row + 1, col] = 'B';
                                    playerRow = playerRow + 1;
                                    return;
                                }
                            }


                        }
                    }
                }
            }

            for(int row=0;row<finalMatrix.GetLength(0);row++)
            {
                for(int col = 0; col < finalMatrix.GetLength(1);col++)
                {
                    Console.Write(finalMatrix[row,col]);
                }

                
            }

        }
    }
}
