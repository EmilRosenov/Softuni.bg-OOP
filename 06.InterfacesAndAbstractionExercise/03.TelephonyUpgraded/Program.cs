using System;

namespace _03.TelephonyUpgraded
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            foreach (var number in phoneNumbers)
            {
                try
                {
                    string result = number.Length == 10
                            ? smartPhone.Call(number)
                            : stationaryPhone.Call(number);
                    Console.WriteLine(result);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                   
                }
            }
            foreach (var site in websites)
            {
                try
                {
                    string result = smartPhone.Browse(site);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}
