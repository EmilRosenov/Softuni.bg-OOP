using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rand;
        
        public RandomList()
        {
            rand = new Random();   
        }
       
        public string GetRandomElement()
        {
            var index = rand.Next(0, Count);
            return this[index];
        }
        public string RemoveRandomElement()
        {
            var index = rand.Next(0, Count);
            string elementToRemove = this[index];
            this.RemoveAt(index);
            return elementToRemove;
        }
    }
}
