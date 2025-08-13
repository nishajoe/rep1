internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //var result = numbers.Where(n => n % 2 == 0);
        //Console.WriteLine("Even numbers:");
        //foreach (int n in result)
        //{
        //    Console.WriteLine(n);
        //}

        //Lambda syntax
        var result = from num in numbers
                     where num % 2 == 0
                     select num;
        Console.WriteLine("Even numbers:");
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}