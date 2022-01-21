using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings:Stack<string>
    {
        Stack<string> list;
        public int count;

        public StackOfStrings()
        {
            list = new Stack<string>();
            
    }
        public int Count => this.count;
        public bool IsEmpty()
        {
            if (list.Count==0)
            {
                return true;
            }
            return false;
        }

        public void AddRange(params string[] data)
        {
            foreach (var item in data)
            {
                list.Push(item);
                count++;
            }
        }
    }
}
