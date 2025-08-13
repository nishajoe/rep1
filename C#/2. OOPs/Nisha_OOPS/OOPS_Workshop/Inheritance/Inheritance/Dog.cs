using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog :Pet
    {
        private string toy;

        public Dog(string name, int age, string breed, string toy) :base(name, age,breed)
        {
            this.name = name;
            this.age = age;     
            this.breed = breed;
            this.toy = toy;
        }

        public void DisplayDog()
        {
            base.DisplayDetails();
            Console.WriteLine("Toy: " + toy);
        }

    }
}
