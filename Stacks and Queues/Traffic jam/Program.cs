using System;
using System.Collections.Generic;

namespace ConsoleApp22
{
    class Program1
    {
        static void Main2(string[] args)
        {

            int passCars = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Queue<string> cars = new Queue<string>();

            int passedcarCounter = 0;
            while ((command = Console.ReadLine()) != "end")
            {

                if (command != "green")
                {

                    cars.Enqueue(command);
                }
                else if (command == "green")
                {

                    for (int i = 0; i < passCars; i++)
                    {

                        if (cars.Count > 0)
                        {
                            passedcarCounter++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }


                    }
                }
            }
            Console.WriteLine($"{passedcarCounter} cars passed the crossroads.");
        }
    }
}


