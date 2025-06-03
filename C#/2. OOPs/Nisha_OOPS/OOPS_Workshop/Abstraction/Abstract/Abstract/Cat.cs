using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Cat : Pet
    {
        public Cat(string name, int age, string breed): base(name, age, breed)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat makes sound Meow!..");
        }
    }
}
