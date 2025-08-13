using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
       Cat c = new Cat("Fluffy", 3, "Persian", true);
       Dog d = new Dog("Buddy", 5, "Labrador", "Ball");

        Console.WriteLine("----------Dog Details-----------");
        d.DisplayDog();
        Console.WriteLine("----------Cat Details-----------");
        c.DisplayCat();
    }
}