using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push("Parrot");
        s.Push("Pigeon");
        s.Push("Dog");
        s.Push("Rabbit");
        s.Push("Cat");
        Console.WriteLine("\nElements in the list are: ");
        foreach(string str in s)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nUpdated list after removal: ");
        s.Pop();
        foreach (string str in s)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nLength of stack: " + s.Count);
        Console.WriteLine("\nPet Cat is present or not? " + s.Contains("Cat"));
    }
}