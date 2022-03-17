using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());


            if (Math.Sqrt(input) >= 0)
            {
                try
                {
                    Console.WriteLine(Math.Sqrt(input));

                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
                finally
                {
                    Console.WriteLine("Goodbye.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number.");
                Console.WriteLine("Goodbye.");
            }

        }
    }
}
