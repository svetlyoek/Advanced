using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            int carCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCounter; i++)
            {
                string[] lines = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = lines[0];
                int engineSpeed = int.Parse(lines[1]);
                int enginePower = int.Parse(lines[2]);
                int weight = int.Parse(lines[3]);
                string type = lines[4];

                var currentEngine = new Engine(engineSpeed, enginePower);
                var currentCargo = new Cargo(weight, type);

                var currentTires = new Tire[4]
                {
                     new Tire(double.Parse(lines[5]),int.Parse(lines[6])),
                     new Tire(double.Parse(lines[7]),int.Parse(lines[8])),
                     new Tire(double.Parse(lines[9]),int.Parse(lines[10])),
                     new Tire(double.Parse(lines[11]),int.Parse(lines[12])),

                };

                var currentCar = new Car(model, currentEngine, currentCargo, currentTires);

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragileCars = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(x => x.Tires.Any(t => t.Pressure < 1))
                    .ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine($"{car.Model}");
                }

            }

            else if (command == "flamable")
            {
                var flamableCars = cars
                    .Where(c => c.Cargo.Type == "flamable")
                    .Where(e => e.Engine.EnginePower > 250)
                    .ToList();

                foreach (var car in flamableCars)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }

        }
    }
}
