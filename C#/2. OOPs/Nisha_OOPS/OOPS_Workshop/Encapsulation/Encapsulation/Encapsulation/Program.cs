using Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet dog = new Pet("Max", 3, "Labrador");
        Pet cat = new Pet("Whiskers", 2, "Persian");

        Pet[] p = { dog, cat }; // Creating an array of pets for sale
        PetSeller sell = new PetSeller(p);  // Creating a pet seller object
        sell.DisplayAvailablePets();
    }
}