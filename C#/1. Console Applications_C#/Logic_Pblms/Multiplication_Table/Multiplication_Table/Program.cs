internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Which multiplication table do you need: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication table: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i+" *"+a+" = "+i*a);
        }

    }
}
