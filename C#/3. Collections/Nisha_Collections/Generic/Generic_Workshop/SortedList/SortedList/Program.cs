internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, string> pet = new SortedList<string, string>();
        pet.Add("Parrot", "Green");
        pet.Add("Pigeon", "White");
        pet.Add("Rabbit", "Grey");
        pet.Add("Cat", "White");
        pet.Add("Dog", "Black");
        Console.WriteLine("\nElements in the list: ");
        foreach(KeyValuePair<string, string> kvp in pet)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

        pet.Remove("Cat");
        Console.WriteLine("\nEnter the pet to check: ");
        string str = Console.ReadLine();
        if (pet.ContainsKey(str))
        {
            Console.WriteLine(str +" found");
        }
        else
        {
            Console.WriteLine($"{str} not found");
        }
    }
}