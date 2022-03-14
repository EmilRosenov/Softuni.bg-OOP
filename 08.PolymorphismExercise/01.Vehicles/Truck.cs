using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Truck : Vehicle, IVehicle
    {
        public const double TruckAriConPerKm = 1.6;

        public Truck(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm)
        {
        }

        public double FuelCOnsumption { get; set; }

        public override void Drive(double km)
        {
            if (FuelQuantity-(LitersPerKm+TruckAriConPerKm)*km<0)
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                FuelQuantity -= (LitersPerKm + TruckAriConPerKm) * km;
                Console.WriteLine($"Truck travelled {km} km");
            }
            
        }
        public override void Refuel(double liters)
        {
            FuelQuantity += liters *0.95;
          
        }
    }
}
