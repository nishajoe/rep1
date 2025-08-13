using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Exception_Assessment_Nisha
{
    public class ShoppingCart: Item
    {
        List<string> itemlist= new List<string>();

        public void Add(string item)
        {
            itemlist.Add(item);
        }

        public void Remove(string item)
        {
            if (itemlist.Contains(item))
            {
                itemlist.Remove(item);
            }
            else
            {
                Console.WriteLine("There is no such item exist!");
            }
            
        }
        public int TotalPrice(int q, int p)
        {
            int total = Quantity * Price;
            return total;
        }
    }
}
