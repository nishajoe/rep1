using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       ArrayList pet= new ArrayList();
        pet.Add("Dog");
        pet.Add("Parrot");
        pet.Add("Cat");
        pet.Add("Rabbit");
        pet.Add("Pigeon");

        Console.WriteLine("Pet Array: ");
        foreach(String s in pet)
        {
            Console.WriteLine(s);
        }

        Console.Write("Count: "+pet.Count);
        pet.Remove("Dog");
        //pet.Remove(0);
        pet[1] = "Dog";
        Console.WriteLine("\nUpdated arraylist: ");
        foreach (String s in pet)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("Enter the name of the pet you want to check: ");
        string check=Console.ReadLine();
        if (pet.Contains(check))
        {
            Console.WriteLine("pet found");
        }
        else
        {
            Console.WriteLine("Pet not found");
        }
        pet.Sort();
        Console.WriteLine("Sorted arraylist: ");
        foreach (String s in pet)
        {
            Console.WriteLine(s);
        }

        pet.Insert(2, "Rabbit");
        Console.WriteLine("Updated arraylist: ");
        foreach (String s in pet)
        {
            Console.WriteLine(s);
        }
    }
}