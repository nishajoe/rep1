internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
        //Get only short words
        var shortwords = words.Where(words =>words.Length > 0);
        //Print each word out
        foreach (var word in shortwords)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }

}
