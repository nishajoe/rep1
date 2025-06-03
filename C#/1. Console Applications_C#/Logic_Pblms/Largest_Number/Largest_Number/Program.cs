internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
       int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a >= b)
        {
            if (a >= c)
            {
                Console.Write(+a + " is largest among the three.");
            }
            else
            {
                Console.Write(+c + " is largest among the three.");
            }
        }
        else if (b >= c)
        {
            Console.Write(+b + " is largest among the three.");
        }
        else
        {
            Console.Write(+c + " is largest among the three.");
        }
        }
}