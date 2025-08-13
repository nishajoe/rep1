using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_Exercise
{
    public class Pet
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Species { get; private set; }
        public string OwnerName { get; private set; }
       
        public Pet(string name, int age, string species, string owner)
        {
            Name = name;
            Age = age;
            Species = species;
            OwnerName = owner;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nSpecies: {Species}\nOwner Name: {OwnerName}");
        }

    }
}
