//Write a program that calculates the factorial of a number input by the user using a for loop and prints the result.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number to find the factorial: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int num = n;
       
        for(int i=n; i >0; i--)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of the number {0} is {1}",num,fact);
    }
}