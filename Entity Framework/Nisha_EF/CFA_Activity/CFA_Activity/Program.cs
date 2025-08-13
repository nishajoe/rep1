using CFA_Activity.Data;
using CFA_Activity.Models;

internal class Program
{
    private static void Main(string[] args)
    {
       using(var context = new AppDB_PdtContext())
       {
            Pdt p = new Pdt();
            Console.WriteLine("Enter the name of the product: ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product: ");
            p.Price = Convert.ToInt16(Console.ReadLine());
            context.ProductsTable.Add(p);
            context.SaveChanges();
            Console.WriteLine("New Product Added!");

            //Item in the database is listed just to see in console
            var list = context.ProductsTable.ToList();
            Console.WriteLine("Products in the database:");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price}");
            }
        }
    }
}