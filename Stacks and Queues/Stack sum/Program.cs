using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> result = new Stack<int>(numbers);
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split().ToArray();
                    string comm = tokens[0].ToLower();
                    if (comm == "add")
                    {
                        int firstNumber = int.Parse(tokens[1]);
                        int secondNumber = int.Parse(tokens[2]);
                        result.Push(firstNumber);
                        result.Push(secondNumber);
                    }
                    else if (comm == "remove")
                    {
                        int counter = int.Parse(tokens[1]);


                        if (result.Count < counter)
                        {
                            continue;

                        }
                        else
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                result.Pop();
                            }

                        }



                    }


                }

            }

            int sum = result.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
