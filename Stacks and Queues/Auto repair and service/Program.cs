using System;
using System.Collections.Generic;
using System.Linq;

namespace Auto_repair_and_service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split().ToArray();
            string command = string.Empty;
            Queue<string> waitingCars = new Queue<string>(cars);
            Stack<string> servedCars = new Stack<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Service")
                {
                    if(waitingCars.Any())
                    {
                        string carName = waitingCars.Peek();
                        Console.WriteLine($"Vehicle {carName} got served.");

                        waitingCars.Dequeue();

                        servedCars.Push(carName);
                    }
                   
                }
                else if (command.Contains("-"))
                {
                    string[] tokens = command.Split("-").ToArray();
                    string carName = tokens[1];
                    if (waitingCars.Contains(carName))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine($"Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
            }

            if (waitingCars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", waitingCars)}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}
