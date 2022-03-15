using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension

{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
            this.TankCapacity = tankCapacity;
        }

        public abstract void Drive(double km);
        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }
            FuelQuantity += liters;
        }
        public double FuelQuantity { get; set; }
        public double LitersPerKm { get; set; }
        public double TankCapacity { get; set; }
        

    }
}
