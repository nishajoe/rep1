using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_ConstructorChaining
{
    internal class MyClass2 :MyClass
    {
        public MyClass2()
        {
            Console.WriteLine("MyClass2 derived class default constructor");
        }

        public MyClass2(int b) :base(67)  //Constructor chaining
        {
            Console.WriteLine("MyClass2 derived class Parameterised constructor"+b);
        }
    }
}
