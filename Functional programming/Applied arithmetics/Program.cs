using System;
using System.Linq;

namespace Applied_arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Func<int[], int[]> adds = n => n.Select(a => a +=1).ToArray();

            Func<int[], int[]> multiplies = n => n.Select(m => m *= 2).ToArray();

            Func<int[], int[]> subtracts = n => n.Select(s => s -= 1).ToArray();

            while(command!="end")
            {
                if(command=="add")
                {
                    numbers=adds(numbers);
                }

                else if(command=="multiply")
                {
                    numbers=multiplies(numbers);
                }

               else if(command=="subtract")
                {
                    numbers=subtracts(numbers);
                }

               else if(command=="print")
                {
                    Action<int[]> result = n => Console.WriteLine(string.Join(" ", numbers));

                    result(numbers);
                }


                command = Console.ReadLine();
            }
        }
    }
}
