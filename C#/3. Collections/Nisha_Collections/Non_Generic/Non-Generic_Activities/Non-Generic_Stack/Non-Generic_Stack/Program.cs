using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push("Reena");
        s.Push("Meena");
        s.Push("Veena");
        s.Push("Geetha");
        s.Push("Geena");        //Adding elements in LIFO order

        Console.WriteLine("\nElements in the list are: ");
       foreach(string str in s)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nAfter removal of first element, updated list: ");
        s.Pop();
        foreach (string str in s)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine($"\nElement at the peek position: {s.Peek()}");

        Console.WriteLine($"\nLength/Count of list: " + s.Count);

        Console.WriteLine($"\nWhether name 'Reena' exist or not? " + s.Contains("Reena"));

    }
}