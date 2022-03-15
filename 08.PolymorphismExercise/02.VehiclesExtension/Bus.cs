using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension
{
    public class Bus : Vehicle, IVehicle,IBus
    {
        public const double BusAirCon = 1.4;
        public Bus(double fuelQuantity, double litersPerKm,double tankCapacity) 
            : base(fuelQuantity, litersPerKm,tankCapacity)
        {
        }

        public double FuelCOnsumption { get; set; }

        public override void Drive(double km)
        {
            if (FuelQuantity - (LitersPerKm + BusAirCon) * km<0)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                FuelQuantity -= (LitersPerKm + BusAirCon) * km;
                Console.WriteLine($"Bus travelled {km} km");
            }
           
        }
        public void DriveEmpty(double km)
        {
            if (FuelQuantity - (LitersPerKm * km) <= 0)
            {
                Console.WriteLine("Bus needs refueling");
            }
            else
            {
                FuelQuantity -= LitersPerKm * km;
                Console.WriteLine($"Bus travelled {km} km");
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
