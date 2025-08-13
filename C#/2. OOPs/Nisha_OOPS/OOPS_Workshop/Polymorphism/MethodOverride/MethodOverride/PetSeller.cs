using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class PetSeller : Pet
    {
        public decimal Price { get; set; }

        public PetSeller(string name, int age, string breed,decimal price):base(name, age, breed)
        {
            Price = price;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Price: "+ Price);
        }
    }
}
