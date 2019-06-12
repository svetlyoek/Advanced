using System;

namespace Symbol_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
           char[,] arr = new char[rowsAndCols, rowsAndCols];
            for (int row = 0; row < rowsAndCols; row++)
            {
                char[] characters = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    arr[row, col] = characters[col];
                 
                }
               
            }

            char symbol = char.Parse(Console.ReadLine());
            
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col <arr.GetLength(1); col++)
                {
                    if (arr[row, col]== symbol)
                    {
                        Console.WriteLine($"{(row, col)}");
                        return;
                    }

                }
            }
         
                Console.WriteLine($"{symbol} does not occur in the matrix");
        
        }
    }
}
