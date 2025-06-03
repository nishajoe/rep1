using Abstract;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet dog = new Dog("Buddy", 3, "Labrador"); //reference of child class is passed to parent class
        Pet cat = new Cat("Whiskers", 2, "Siamese");

        Console.WriteLine("-----Dog-----");
        Console.WriteLine($"Name: {dog.Name}\nAge: {dog.Age}\nBreed: {dog.Breed}");
        dog.MakeSound();

        Console.WriteLine("-----Cat-----");
        Console.WriteLine($"Name: {cat.Name}\nAge: {cat.Age}\nBreed: {cat.Breed}");
        cat.MakeSound();
    }
}