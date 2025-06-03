using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Animal
    {
        private int num = 10;
        public void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
            Console.WriteLine(num);
        }
    }
}
