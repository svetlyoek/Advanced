﻿
namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tire
    {
       
        public double Pressure { get; set; }
       
        public int Age { get; set; }
      

        public Tire(double pressure,int age)
        {
            this.Pressure = pressure;
            this.Age = age;
          
        }
    }
}
