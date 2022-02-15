using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string[] inputNumbers = Console.ReadLine().Split(); 
            string[] inputWebsites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in inputNumbers)
            {
                if (number.Length==10)
                {
                    try
                    {
                        Console.WriteLine(smartphone.Call(number));
                        
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (number.Length==7)
                {
                    try
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var url in inputWebsites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    
}
