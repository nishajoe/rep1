using Collection_Exception_Assessment_Nisha;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            ShoppingCart cart= new ShoppingCart();
            Console.WriteLine("Welcome to Shopping Cart\n1) Add an item\n2) Remove an item\n3) Apply discount\n4) Display total price ");
            Console.WriteLine("Choose an option by giving the corresponding number for action: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                         Console.WriteLine("Enter the item to add: ");
                         string add= Console.ReadLine();
                         cart.Add(add);
                         break;

                case 2:  Console.WriteLine("Enter the item to remove: ");
                         string remove = Console.ReadLine();
                         cart.Remove(remove);
                         break;

                case 3:  Console.WriteLine("Enter the discount in percentage: ");
                         int discount= Convert.ToInt32(Console.ReadLine());
                         break;

                case 4: Console.WriteLine("Total: "+ cart.TotalPrice());
                        break;

                default: break;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("");
        }
     
    }
}