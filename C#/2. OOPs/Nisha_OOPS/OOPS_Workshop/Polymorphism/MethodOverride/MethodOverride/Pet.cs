using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class Pet
    {
        public int Age {  get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public Pet(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nBreed: {Breed}");
        }
    }
}
