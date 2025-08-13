internal class Program
{
    private static void Main(string[] args)
    {
        List<int> number = new List<int> { 7, 40, 20, 4, 6 };

        //var result = number.OrderBy(n => n);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        //query syntax
        var result = from n in number
                     orderby n
                     select n;
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}