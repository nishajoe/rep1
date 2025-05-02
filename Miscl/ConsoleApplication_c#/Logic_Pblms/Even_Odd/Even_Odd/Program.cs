internal class Program
{
    private static void Main(string[] args)
    {
       Console.Write("Enter a number: ");
       int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }
}