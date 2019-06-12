using System;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCows = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[rowsAndCows][];
            pascalTriangle[0]= new long[1];
            pascalTriangle[0][0] = 1;
            for(int row=1;row<rowsAndCows;row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
                for(int col=1;col<pascalTriangle[row].Length-1;col++)
                {
                   
                    pascalTriangle[row][col] +=pascalTriangle[row-1][col]+pascalTriangle[row-1][col-1];
                   
                }
              
            }
            foreach(var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
