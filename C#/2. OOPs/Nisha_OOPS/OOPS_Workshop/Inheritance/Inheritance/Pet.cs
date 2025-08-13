using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Pet
    {
        protected string name;
        protected int age;
        protected string breed;

        public Pet(string name, int age, string breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nBreed: {breed}");
        }
    }
}
