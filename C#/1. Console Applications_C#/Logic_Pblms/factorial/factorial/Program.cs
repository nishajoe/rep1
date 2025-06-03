internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number to find factorial: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int i = a;
        int fact = 1;
        do
        {
            fact = fact * a;
            a--;
        } while (a > 0);
        Console.WriteLine("Factorial of "+i+" is: "+fact);
    }
}