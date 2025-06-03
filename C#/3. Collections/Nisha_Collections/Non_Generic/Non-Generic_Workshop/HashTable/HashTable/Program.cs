using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable hash = new Hashtable();
        hash.Add("1","Parrot");
        hash.Add("2","Pigeon");
        hash.Add("3","Rabbit");
        hash.Add("4","Dog");
        hash.Add("5","Squirrel");
        hash.Add("6","Swan");
        Console.WriteLine("\nElements in the hashtable: ");
        foreach (DictionaryEntry entry in hash)
        {
            Console.WriteLine(entry.Key + ":" +entry.Value);
        }

        hash.Remove(6);
        Console.WriteLine("\nUpdated elements in the hashtable: ");
        foreach (DictionaryEntry entry in hash)
        {
            Console.WriteLine(entry.Key + ":" + entry.Value);
        }

        Console.WriteLine("\nCount of the hashtable: " + hash.Count);

        Console.WriteLine("\nEnter the item to be checked?: ");
        string check = Console.ReadLine();
        if (hash.Contains(check))
        {
            Console.WriteLine("\n Item found");
        }
        else
        {
            Console.WriteLine("\n Item not found");
        }
    }
}