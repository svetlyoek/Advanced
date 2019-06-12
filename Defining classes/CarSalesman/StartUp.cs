using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var engines = new List<Engine>();

            int enginesCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCounter; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (engineInfo.Length == 4)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    var currentEngine = new Engine(model, power, displacement, efficiency);

                    engines.Add(currentEngine);

                }

                else if (engineInfo.Length == 3)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int a;

                    bool validation = int.TryParse(engineInfo[2], out a);

                    if (validation)
                    {
                        int displacement = a;

                        var currentEngine = new Engine(model, power, displacement);

                        engines.Add(currentEngine);
                    }

                    else
                    {
                        string efficiency = engineInfo[2];

                        var currentEngine = new Engine(model, power, efficiency);

                        engines.Add(currentEngine);
                    }

                }

                else if (engineInfo.Length == 2)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);

                    var currentEngine = new Engine(model, power);

                    engines.Add(currentEngine);

                }
            }

            int carsCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCounter; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carsInfo[0];
                string engineModel = carsInfo[1];
                Engine engine = null;

                foreach (var item in engines)
                {
                    if (item.Model == engineModel)
                    {
                        engine = item;
                        break;
                    }
                }
                if (carsInfo.Length == 4)
                {
                    int weight = int.Parse(carsInfo[2]);
                    string color = carsInfo[3];

                    var currentCar = new Car(model, engine, weight, color);

                    cars.Add(currentCar);
                }

                else if (carsInfo.Length == 2)
                {
                    var currentCar = new Car(model, engine);

                    cars.Add(currentCar);
                }

                else if (carsInfo.Length == 3)
                {
                    int a;

                    bool isValid = int.TryParse(carsInfo[2], out a);

                    if (isValid)
                    {
                        int weight = a;

                        var currentCar = new Car(model, engine, weight);

                        cars.Add(currentCar);
                    }

                    else
                    {
                        string color = carsInfo[2];

                        var currentCar = new Car(model, engine, color);

                        cars.Add(currentCar);


                    }
                }
            }
           
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
