internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, int> sl = new SortedList<string, int>();
        sl.Add("hai", 1);
        sl.Add("manu", 3);
        sl.Add("neenu", 4);
        sl.Add("vani", 11);
        sl.Add("kamlu", 5);
        Console.WriteLine("\nElements in the list: ");
        foreach(KeyValuePair<string, int> kvp in sl)
        {
            Console.WriteLine($"{ kvp.Key} : {kvp.Value }");
        }

        sl.Remove("neenu");
        Console.WriteLine("\nUpdated list: ");
        foreach (KeyValuePair<string, int> kvp in sl)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

        Console.WriteLine("\nContain key 'kamlu' ? " + sl.ContainsKey("kamlu"));

        Console.WriteLine("\nContain value '1' ? " + sl.ContainsValue(1));

    }
}