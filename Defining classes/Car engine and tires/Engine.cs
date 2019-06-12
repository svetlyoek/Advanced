using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public int horsePower;

        public double cubicCapacity;

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            private set
            {
                this.horsePower = value;
            }
        }

        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            private set
            {
                this.cubicCapacity = value;
            }
        }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;

            this.CubicCapacity = cubicCapacity;
        }
    }
}
