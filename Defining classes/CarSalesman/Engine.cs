
namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private string model;

        private int power;

        private int displacement;

        private string efficiency;


        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }

            set { this.power = value; }
        }

        public int Displacement
        {
            get { return this.displacement; }

            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }

            set { this.efficiency = value; }
        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model,int power,string efficiency)
            :this(model,power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model,power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
           

            result.AppendLine($"  {this.Model}:");
            result.AppendLine($"    Power: {this.Power}");

            if (this.Displacement == 0)
            {
                result.AppendLine($"    Displacement: n/a");
            }
            else
            {
                result.AppendLine($"    Displacement: {this.Displacement}");
            }

            if (this.Efficiency == null)
            {
                result.Append($"    Efficiency: n/a");
            }
            else
            {
                result.Append($"    Efficiency: {this.Efficiency}");
            }

            return result.ToString();
        }
    }
}
