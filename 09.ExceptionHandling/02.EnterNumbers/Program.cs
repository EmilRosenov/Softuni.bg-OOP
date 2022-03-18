namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class EnterNumbersClass
    {
        public static void Main()
        {
            int counter = 0;
            int start = 1;
            HashSet<int> numbers = new HashSet<int>();
            while (counter < 10)
            {
                int currentNum = 0;
                try
                {
                    currentNum = ReadNumbers(start, 100);

                    if (currentNum > start)
                    {
                        start = currentNum;
                    }
                    numbers.Add(currentNum);
                    counter++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static int ReadNumbers(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
            {
                throw new ArgumentOutOfRangeException($"Your number is not in range {num} - 100!");
            }

            return num;
        }
    }
}