using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());

            char[,] arr = new char[rowsAndCols, rowsAndCols];

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
           
            int coalSum = 0;
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < rowsAndCols; row++)
            {
                char[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < rowsAndCols; col++)
                {
                    arr[row, col] = lines[col];

                    if (arr[row, col] == 's')
                    {
                        currentRow= row;
                        currentCol = col;

                    }
                    if (arr[row, col] == 'c')
                    {
                        coalSum++;

                    }

                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];

                if (currentCommand == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        
                        currentCol = currentCol - 1;

                        if (arr[currentRow, currentCol] == 'c')
                        {
                            coalSum--;
                            arr[currentRow, currentCol] = '*';
                            if (coalSum == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                        else if (arr[currentRow, currentCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                    }
                   
                }

                else if (currentCommand == "right")
                {
                    if (currentCol + 1 <= arr.GetLength(1) - 1)
                    {
                      
                        currentCol = currentCol + 1;

                        if (arr[currentRow, currentCol] == 'c')
                        {
                            coalSum--;
                            arr[currentRow, currentCol] = '*';
                            if (coalSum == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                        else if (arr[currentRow, currentCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                    }
                  
                }

                else if (currentCommand == "up")
                {
                    if (currentRow - 1 >= 0)
                    {
                        currentRow = currentRow - 1;
                       

                        if (arr[currentRow, currentCol] == 'c')
                        {
                            coalSum--;
                            arr[currentRow, currentCol] = '*';
                            if (coalSum == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                        else if (arr[currentRow, currentCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                    }
                  
                }

               else  if (currentCommand == "down")
                {
                    if (currentRow + 1 <= arr.GetLength(0) - 1)
                    {
                        currentRow = currentRow + 1;
                       

                        if (arr[currentRow, currentCol] == 'c')
                        {
                            coalSum--;
                            arr[currentRow, currentCol] = '*';
                            if (coalSum == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                        else if (arr[currentRow, currentCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                    }
                   
                }
            }

            Console.WriteLine($"{coalSum} coals left. ({currentRow}, {currentCol})");
        }
    }
}




            
         




        
    


       

