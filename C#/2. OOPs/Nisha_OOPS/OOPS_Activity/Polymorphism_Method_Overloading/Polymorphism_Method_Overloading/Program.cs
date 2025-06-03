using Polymorphism_Method_Overloading;
internal class Program
{
    private static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        cal.Compute();
        Console.WriteLine(cal.Compute(2,3));
        Console.WriteLine(cal.Compute(1500.9, 1000.0,450.8));

    }
}