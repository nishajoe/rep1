using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class Pet
    {
        public int Age {  get; set; }
        public string Name { get; set; }

        public Pet(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
    }
}
