using PetApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet p1 = new Pet("Fluffy", "Cat", 3, 50.00);
        Pet p2 = new Pet("Buddy", "Dog", 2, 100.00);
        Pet p3 = new Pet();

        Console.WriteLine("Pet 1");
        p1.display();

        Console.WriteLine("Pet 2");
        p2.display();

        Console.WriteLine("Pet 3");
        p3.name = "Tomy";
        p3.type = p2.type;
        p3.price = p1.price;
        Console.WriteLine("Enter the age of the pet: ");
        p3.age=Convert.ToInt32(Console.ReadLine());
        p3.display();

        Console.ReadLine();
    }
}