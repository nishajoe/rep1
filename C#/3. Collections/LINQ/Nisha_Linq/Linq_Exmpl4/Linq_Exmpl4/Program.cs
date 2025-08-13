internal class Program
{
    private static void Main(string[] args)
    {
        List<int> l = new List<int> { 2, 3, 4, 5 };
        //int result = l.Sum();
        //Console.WriteLine("Sum: "+result);
        

        //query syntax
        var numbers = from n in l
                    select n;

        int result = numbers.Sum();

        Console.WriteLine("Sum: " + result);
    }
}