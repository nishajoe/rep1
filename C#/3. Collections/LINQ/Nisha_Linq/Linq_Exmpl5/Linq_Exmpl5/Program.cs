internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Alice", "Bob", "Antony","Charlie" };

        //var result = names.Where(n => n.StartsWith("A"));
        //foreach (var n in result)
        //{
        //    Console.WriteLine(n);
        //}

        var result = from n in names
                     where n.StartsWith("A")
                     select n;
        foreach (var n in result)
        {
            Console.WriteLine(n);
        }

    }
}