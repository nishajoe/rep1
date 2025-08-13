using DFA.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BookContext())
        {
            var newpdt = new Book { BookTitle = "C Programming", BookAuthor = "Balaguruswamy", BookPrice = 350 };
            context.Books.Add(newpdt);
            context.SaveChanges();
            Console.WriteLine("New product added!");

            var list = context.Books.ToList();
            Console.WriteLine("Items in database..");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.BookId} - {item.BookTitle} - {item.BookAuthor} - {item.BookPrice}");
            }
        }


    }
}