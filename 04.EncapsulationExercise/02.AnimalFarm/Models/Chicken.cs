namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                CheckIfCorrectName(value);
            }
        }

        private string CheckIfCorrectName(string value)
        {
            if (value.Length == 0 || value.Contains(' ') || value == null)
            {
                throw new System.Exception("Name cannot be empty.");
            }
            return this.name = value;
        }
    

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                CheckIfCorrectInputAge(this.age);
                this.age = value;
                
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            if (this.Age >= 0 && this.Age <= 3)
            {
                return 1.5;
            }
            else if (this.Age >= 4 && this.Age <= 7)
            {
                return 2;
            }
            else if (this.Age >= 8 && this.Age <= 11)
            {
                return 1;
            }

            if (this.Age <=MaxAge && this.Age > 11)
            {
                return 0.75;
            }
            else
            {
                throw new System.Exception($"Age should be between {MinAge} and {MaxAge}.");
            }
            
        }
        private bool CheckIfCorrectInputAge(int age)
        {
            if (this.age < MinAge || this.age > MaxAge)
            {
                throw new System.Exception($"Age should be between {MinAge} and {MaxAge}.");
            }
            else
            {
                return true;
            }
            
        }
    }
}

       
