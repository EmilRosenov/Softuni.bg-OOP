using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            SportCar sportCar = new SportCar(horsePower,fuel);

            sportCar.Drive(10);
            
            Console.WriteLine(sportCar.Fuel);
            FamilyCar car = new FamilyCar(horsePower, fuel);
            car.Drive(10);
            Console.WriteLine(car.Fuel);
            RaceMotorcycle raceMoto = new RaceMotorcycle(horsePower, fuel);
            raceMoto.Drive(10);
            Console.WriteLine(raceMoto.Fuel);

        }
    }
}
