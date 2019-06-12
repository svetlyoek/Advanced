
namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1Km { get; set; }

        public int TraveledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1Km = fuelConsumptionFor1Km;
            this.TraveledDistance = 0;
        }

        public void MoveOrNot(int traveledDistance)
        {
            if (this.FuelAmount >= (traveledDistance * this.FuelConsumptionFor1Km))
            {
                this.FuelAmount -= (traveledDistance * this.FuelConsumptionFor1Km);
                this.TraveledDistance += traveledDistance;

            }

            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");

            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }

    }
}
