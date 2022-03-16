using _04.WildFarm.Food;

namespace _04.WildFarm.Animal
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name,
                         double weight)
                        
        {
            this.Name = name;
            this.Weight = weight;
            
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract void Eat(IFood food);

        public abstract string ProduceSound();
        
    }
}
