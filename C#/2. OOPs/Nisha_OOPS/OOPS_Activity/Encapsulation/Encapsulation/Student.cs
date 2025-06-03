using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     class Student
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if(value >= 5 && value <= 100)
                {
                    _age = value;   // in properties values are set into the class members.
                }
                else
                {
                    _age = 0;  // 0 means invalid value
                }
            }
        }

        public void display()
        {
            if (_age < 6)
            {
                Console.WriteLine("Invalid age entered!");
            }
            else
            {
                Console.WriteLine("Age: " + _age);
            }
        }
    }
}
