using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange("hello", "world", "how", "are", "you");
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Count);
        }
    }
}
