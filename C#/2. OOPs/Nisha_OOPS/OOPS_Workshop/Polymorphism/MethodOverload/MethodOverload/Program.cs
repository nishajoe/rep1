using MethodOverload;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet mypet = new Pet("Fluffy", 3);
        Dog dog = new Dog("Buddy", 5, "Golden Retriever");

        Console.WriteLine("My Pet");
        mypet.DisplayInfo();

        Console.WriteLine("My Dog");
        dog.DisplayInfo(true);

        PetSeller selling = new PetSeller("Johny",dog);
        selling.SellPet();  //selling pet

        
    }
}