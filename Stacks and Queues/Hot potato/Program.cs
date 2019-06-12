using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int passCars = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Queue<string> cars = new Queue<string>();
            int carCounter = 0;
            int passedcarCounter = 0;
            while ((command = Console.ReadLine()) != "end")
            {

                if (command != "green")
                {
                    carCounter++;
                    cars.Enqueue(command);
                }
                else if (command == "green")
                {

                    for (int i = 0; i < passCars; i++)
                    {
                        passedcarCounter++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
            }
            Console.WriteLine($"{passedcarCounter} cars passed the crossroads.");

        }
    }
}
