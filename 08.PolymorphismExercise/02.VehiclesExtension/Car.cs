using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension

{
    public class Car : Vehicle,IVehicle
    {
        //public const double CarAirConditioner = 0.9;
        public Car(double fuelQuantity, double litersPerKm,double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public double FuelCOnsumption { get; set; }

        public override void Drive(double km)
        {
            if (FuelQuantity - (LitersPerKm * km)<0)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                FuelQuantity -= LitersPerKm* km;
                Console.WriteLine($"Car travelled {km} km");
            }
        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
           
            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
               
            }
            else
            {
                FuelQuantity += liters;
            }
            
        }
    }
}
