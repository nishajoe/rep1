using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    public class Pet
    {
        private string name;
        private int age;
        private string breed;

        public Pet(string name, int age, string breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }


        public void displayInfo()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nBreed: {breed}");      

        }
    }
}
