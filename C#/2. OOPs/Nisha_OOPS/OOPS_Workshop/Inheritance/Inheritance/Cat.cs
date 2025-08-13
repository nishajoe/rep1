using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Pet
    {
        private bool IsLongHair;

        public Cat(string name, int age, string breed, bool IsLongHair) : base(name, age, breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.IsLongHair = IsLongHair;
        }

        public void DisplayCat()
        {
            DisplayDetails();
            Console.WriteLine("Long hair: "+ IsLongHair);
        }
    }
}
