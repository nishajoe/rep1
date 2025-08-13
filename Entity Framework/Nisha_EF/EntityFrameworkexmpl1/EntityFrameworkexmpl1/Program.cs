using EntityFrameworkexmpl1.Data;
using EntityFrameworkexmpl1.Models;


internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            // Add a new product
            var newProduct = new Product { Name = "Laptop", Price = 1500.00M };
            context.Products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine("New Product Added!");

            // Fetch and display all products from db to see in the console
            var itemslist = context.Products.ToList();
            Console.WriteLine("Products in Database:");
            foreach (var items in itemslist)
            {
                Console.WriteLine($"{items.Id} - {items.Name} - ${items.Price}");
            }
        }
    }
}