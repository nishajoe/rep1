using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
