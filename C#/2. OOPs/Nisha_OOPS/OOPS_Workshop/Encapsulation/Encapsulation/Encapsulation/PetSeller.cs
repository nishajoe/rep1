using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PetSeller
    {
        private Pet[] sale;

        public PetSeller(Pet[] sale) //constructor creation
        {
            this.sale = sale;
        }

        public void DisplayAvailablePets()
        {
            Console.WriteLine("Available pets for sale: ");
            foreach (Pet p in sale)
            {
                p.displayInfo();
            }

        }
    }
}
