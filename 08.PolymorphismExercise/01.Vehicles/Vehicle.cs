using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
        }

        public abstract void Drive(double km);
        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }
        

    }
}
