using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
{
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age 
        {
            get { return this.age; }
            
            set
            {
                if (this.age < 0)
                {
                    throw new Exception();
                }
                else
                {
                    age = value;
                    //return value;
                        
                }
            }
        }


        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
          
        }
    }
}
