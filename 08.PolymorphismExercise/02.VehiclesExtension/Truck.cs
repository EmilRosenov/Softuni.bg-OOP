using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension

{
    public class Truck : Vehicle, IVehicle
    {
        //public const double TruckAriConPerKm = 1.6;

        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public double FuelCOnsumption { get; set; }

        public override void Drive(double km)
        {
            if (FuelQuantity-(LitersPerKm*km)<0)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                FuelQuantity -= LitersPerKm* km;
                Console.WriteLine($"Truck travelled {km} km");
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
