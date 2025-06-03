internal class Program
{
    private static void Main(string[] args)
    {
        
        List<string> l = new List<string>();
        l.Add("Pigeon");
        l.Add("Cat");
        l.Add("Dog");
        l.Add("Rabbit");
        l.Add("Parrot");
        Console.WriteLine("\nElements in the list: ");
        foreach(string str in l)
        {
            Console.WriteLine(str);
        }

        l.Remove("Dog");
        l.RemoveAt(1);
        Console.WriteLine("\nUpdated list: ");
        foreach (string str in l)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nLength of the list: " + l.Count);

        Console.WriteLine("\nElements in the list: ");
        foreach (string str in l)
        {
            Console.WriteLine(l.IndexOf(str)+" : " + str);
               ;
        }

    }
}