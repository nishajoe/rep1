internal class Program
{
    private static void Main(string[] args)
    {
        string str = "hai";
        int num=Convert.ToInt32(str);  // Cannot convert "hai" to int
       //A FormatException in C# occurs when a method that expects data in a specific format
       //receives input that doesn't match that format.
        Console.WriteLine(num);
    }
}