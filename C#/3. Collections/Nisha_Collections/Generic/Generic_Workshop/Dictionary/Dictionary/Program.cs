internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Java");
        dict.Add(2, "Javascript");
        dict.Add(3, "Python");
        dict.Add(4, "C");
        dict.Add(5, "CPP");
        dict.Add(6, "Linux");

        Console.WriteLine("\nElements in the dictionary: ");
        foreach (KeyValuePair<int, string> kvp in dict)  
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

       
        dict.Remove(2);
        Console.WriteLine("\nUpdated dictionary: ");
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }


    }
}