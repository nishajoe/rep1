internal class Program
{
    private static void Main(string[] args)
    {
        string[] fruits = { "apple", "orange", "mango", "kiwi" };
        Console.WriteLine("Fruits: ");
        foreach (string x in fruits)
        {
            Console.WriteLine(x);
        }
    }
}