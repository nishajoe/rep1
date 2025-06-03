using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog bark");
        }
    }
}
