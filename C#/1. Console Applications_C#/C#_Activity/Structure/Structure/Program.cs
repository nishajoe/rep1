using System.Net;

struct Books
{
   public  string author;
   public  string title;
   public int pages;
}
internal class Program
{
    private static void Main(string[] args)
    {
        Books b;
        b.author = "Balaguruswamy";
        b.title = "C#";
        b.pages = 401;

        Console.WriteLine("Author: " + b.author);
        Console.WriteLine("Title: " + b.title);
        Console.WriteLine("Pages: " + b.pages);
    }
}