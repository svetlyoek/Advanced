using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
       public int year;

      public double pressure;


        public int Year
        {
            get
            {
                return this.year;
            }
            private set
            {
                this.year = value;
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            private set
            {
                this.pressure = value;
            }
        }

        public Tire(int year, double pressure)
        {
            this.Year = year;

            this.Pressure = pressure;
        }

    }
}
