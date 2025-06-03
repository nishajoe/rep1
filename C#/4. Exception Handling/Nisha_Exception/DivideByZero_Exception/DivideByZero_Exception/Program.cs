internal class Program
{
    private static void Main(string[] args)
    {
        int n = 10;
        int i= 0;
        int result = n / i;     // This will cause DivideByZeroException
        Console.WriteLine(result);
    }
}