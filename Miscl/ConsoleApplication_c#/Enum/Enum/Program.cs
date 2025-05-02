enum Days
{
    Sunday, Monday, Tuesday
}
internal class Program
{
    private static void Main(string[] args)
    {
        Days day = Days.Monday;
        Console.WriteLine("Today is "+day);                  // Output: Today is: Monday
        Console.WriteLine("Today is " + (int)day);         // Output: Value: 1


    }
}