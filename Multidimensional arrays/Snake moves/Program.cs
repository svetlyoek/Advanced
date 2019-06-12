using System;
using System.Linq;

namespace Snake_moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            string snake = Console.ReadLine();
            char [,] arr = new char[rows, cols];
            int counter = 0;
           
            for(int row=0;row<rows;row++)
            {
                for(int col=0;col<cols;col++)
                {
                    if(counter==snake.Length)
                    {
                        counter = 0;
                    }
                    arr[row, col] = snake[counter];
                    counter++;
                }
            }
          
            for(int row=0;row<rows;row++)
            {
                for(int col=0;col<cols;col++)
                {
                    Console.Write($"{arr[row,col]}");
                }
                Console.WriteLine();
            }
         

        }
    }
}
