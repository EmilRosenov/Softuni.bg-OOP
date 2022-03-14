using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Car : Vehicle,IVehicle
    {
        public const double CarAirConditioner = 0.9;
        public Car(double fuelQuantity, double litersPerKm) 
            : base(fuelQuantity, litersPerKm)
        {
        }

        public double FuelCOnsumption { get; set; }

        public override void Drive(double km)
        {
            if (FuelQuantity - (LitersPerKm + CarAirConditioner) * km<0)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                FuelQuantity -= (LitersPerKm + CarAirConditioner) * km;
                Console.WriteLine($"Car travelled {km} km");
            }
        }
    }
}
