using _02.Exercise;
using System;

namespace _02.Exrcise
{
    public class Program
    {
        static void Main(string[] args)
        {
            RobotKitchen robotKitchen = new RobotKitchen();
            Kitchen baseKitchen = robotKitchen;
            IRobotCleaner robotCleaner = robotKitchen;

            robotCleaner.RobotClean();
            robotCleaner.GetType();

            baseKitchen.CutVegetables();
            baseKitchen.CookMeat();
            baseKitchen.CookVegetables();

            robotKitchen.RobotWash();
            robotKitchen.CookMeat();
        }
    }
}
