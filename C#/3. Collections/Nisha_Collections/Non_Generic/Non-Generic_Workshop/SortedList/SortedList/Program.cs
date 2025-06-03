using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedList list = new SortedList();
        list.Add("Parrot","p1");
        list.Add("Pigeon", "p2");
        list.Add("Cat", "p3");
        list.Add("Dog", "p4");
        list.Add("Rabbit", "p5");
        Console.WriteLine("\nList of elements: ");
        foreach (var item in list.Keys)
        {
            Console.WriteLine($"{item}:{list[item]}");
        }


        list.Remove("Pigeon");
        Console.WriteLine("\nUpdated list: ");
        foreach (var item in list.Keys)
        {
            Console.WriteLine($"{item}:{list[item]}");
        }

        Console.WriteLine("\nCat found at index: " + list.IndexOfKey("Cat"));
        Console.WriteLine("\nValue 'p5' found at index: " + list.IndexOfValue("p5"));
        Console.WriteLine("\nLength of sorted list: " + list.Count);

    }
}