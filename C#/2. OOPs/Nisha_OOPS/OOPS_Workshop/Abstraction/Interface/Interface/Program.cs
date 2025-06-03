using Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 3, "Labrador", "Golden");
        Console.WriteLine($"My dog's name is {dog.Name} , it's a {dog.Breed} in {dog.Color} and it's {dog.Age} years");

        Cat cat = new Cat("Whiskers", 2, "Persian", "White");
        Console.WriteLine($"My dog's name is {cat.Name} , it's a {cat.Breed} in {cat.Color} and it's {cat.Age} years");
        Console.ReadLine();
    }
}