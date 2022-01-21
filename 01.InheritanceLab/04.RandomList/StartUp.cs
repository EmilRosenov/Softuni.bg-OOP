using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList listRandom = new RandomList();
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            string input5 = Console.ReadLine();

            listRandom.Add(input);
            listRandom.Add(input2);
            listRandom.Add(input3);
            listRandom.Add(input4);
            listRandom.Add(input5);
           
            //listRandom.RemoveRandomElement();
            //listRandom.RemoveRandomElement();
            Console.WriteLine(listRandom.RemoveRandomElement());
            Console.WriteLine(listRandom.RemoveRandomElement());
            Console.WriteLine(listRandom.GetRandomElement()); 

            Console.WriteLine(string.Join(", ",listRandom));
            Console.WriteLine(listRandom.Count);
           
        }
    }
}
