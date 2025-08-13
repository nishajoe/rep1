internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>
        {
           { 1,"John" },
           { 2, "Jane" },
           { 3, "Doe" }
        };

        //var result = from n in dict
        //             where n.Key > 1
        //             select n;
        //foreach (var student in result)
        //{
        //    Console.WriteLine($"{student.Key}: {student.Value}");
        //}

        var result = dict.Where(n=>n.Key > 1);
        foreach (var student in result)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }
    }
}