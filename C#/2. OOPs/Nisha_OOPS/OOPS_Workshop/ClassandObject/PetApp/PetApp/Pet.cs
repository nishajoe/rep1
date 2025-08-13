using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class Pet
    {
        public string name;
        public string type;
        public int age;
        public double price;

        public Pet(string name, string type, int age, double price)
        {
            this.name = name;
            this.age = age;
            this.type = type;
            this.price = price;
        }

        public  Pet()
        {

        }

        public void display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Price: {price}");
        }

    }
}
