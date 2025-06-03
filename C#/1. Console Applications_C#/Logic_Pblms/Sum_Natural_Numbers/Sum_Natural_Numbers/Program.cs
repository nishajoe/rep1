internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Sum of first 10 natural numbers: ");
        int i = 0, sum=0;
    while(i<=10)
        {
            sum = sum + i;
            i++;
        }
        Console.Write(sum);
    }
}
