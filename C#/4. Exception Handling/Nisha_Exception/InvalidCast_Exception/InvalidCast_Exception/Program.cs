internal class Program
{
    private static void Main(string[] args)
    {
        object obj = "hello";
        int i = (int) obj;       // Cannot cast string to int
        Console.WriteLine(i);
        //An InvalidCastException in C# occurs when you try to cast an object to a type
        //it cannot be converted to,even though both types may be reference types or implement
        //the same interface.

        //eg:-object obj = "hello";
       // int number = (int)obj; //invalidcastexception
    }
}