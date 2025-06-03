using System.Collections;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedList list=new SortedList();
        list.Add(1, "Data");
        list.Add(2, "Job");
        list.Add(3, "Vacancy");
        list.Add(4, "Engineer");
        list.Add(5, "Tailor");
        list.Add(6, "Labour");

        Console.WriteLine("\nList of elements: ");
        foreach(var item in list.Keys)
        {
            //Console.WriteLine(item);
            Console.WriteLine($"{item}:{list[item]}");
        }

        list.Remove(4);         //Remove key-4 entry
        list.RemoveAt(2);       //Element @ index 2 is removed
        Console.WriteLine("\nUpdated list of elements: ");
        foreach (var item in list.Keys)
        {
            Console.WriteLine($"{item}:{list[item]}");
        }

        Console.WriteLine("\nCount of elements: " + list.Count);

        Console.WriteLine("\nContains key '5'? "+list.ContainsKey(5));  //Checking keyexist or not

        Console.WriteLine("\nIndex of key '5': " + list.IndexOfKey(5));  //To find index of key

        Console.WriteLine("\nIndex of Value 'Job'? " + list.IndexOfValue("Job"));  //To find index of value
    }
}