using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private List<Item> items;
        protected Bag(int capacity = 100)
        {
            this.Capacity = capacity;
            this.items = new List<Item>(); 
        }
        public int Capacity { get; set; }

        public int Load => this.Items.Sum(w => w.Weight);

        public IReadOnlyCollection<Item> Items => items;

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight >= this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Count==0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }
            if (!items.Any(n=>n.GetType().Name == name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag,name));
            }

            Item result = items.FirstOrDefault(n => n.GetType().Name == name);
            items.Remove(result);
            return result;
        }
    }
}
