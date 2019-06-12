using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();

            int carCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCounter; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1Km = double.Parse(carInfo[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionFor1Km);
                cars.Add(car);
            }

            string text = string.Empty;
            int traveledDistance = 0;

            while ((text = Console.ReadLine()) != "End")
            {
                string[] carDrive = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = carDrive[1];
                traveledDistance = int.Parse(carDrive[2]);

                var currentCar = cars.Find(x => x.Model == model);
                currentCar.MoveOrNot(traveledDistance);
            }
            
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
