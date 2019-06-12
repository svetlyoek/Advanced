
namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private string model;

        private Engine engine;

        private int weight;

        private string color;

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }

            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }

            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }

            set { this.color = value; }
        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
           
            

        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Model}:");
            result.AppendLine($"{this.Engine}");
            if(this.Weight==0)
            {
                result.AppendLine($"  Weight: n/a");
            }
            else
            {
                result.AppendLine($"  Weight: {this.Weight}");
            }
            
            if(this.Color==null)
            {
                result.Append($"  Color: n/a");
            }
            else
            {
                result.Append($"  Color: {this.Color}");
            }
          
            return result.ToString();
        }
    }
}
