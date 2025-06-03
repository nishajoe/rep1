using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Method_Overloading
{
    
    internal class Calculator
    {
        public void Compute()
        {
            Console.WriteLine("Computing!...");  // not necessary about return type in method overloading
        }

        public int Compute(int a , int b)
        {
            return a + b;
            
            
        }

        public double Compute(double a, double b, double c)
        {
            return a - b - c;
        }

      
    }
}
