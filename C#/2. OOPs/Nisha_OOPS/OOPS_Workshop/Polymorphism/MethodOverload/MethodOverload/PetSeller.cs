using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class PetSeller
    {
        private string seller_name;
        private Pet p_sell;

        public PetSeller(string seller, Pet pet)
        {
            seller_name = seller;
            p_sell = pet;
        }

        public void SellPet()
        {
            Console.WriteLine("Selling Pet");
            p_sell.DisplayInfo();

        }
    }
}
