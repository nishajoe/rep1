using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ConstructorChaining
{
    internal class MyClass 
    {
        public MyClass() 
        {
            Console.WriteLine("MyClass base class default Constructor");
        }
        public MyClass(int a)
        {
            Console.WriteLine("MyClass base class Parameterised Constructor"+a);
        }
    }
}
