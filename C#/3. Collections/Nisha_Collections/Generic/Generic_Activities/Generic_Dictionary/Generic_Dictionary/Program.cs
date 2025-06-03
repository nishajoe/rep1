using System.Collections;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Java");
        dict.Add(2, "Javascript");
        dict.Add(3, "Python");
        dict.Add(4, "C");
        dict.Add(5, "CPP");
        dict.Add(6, "Linux");

        foreach(var item in dict.Keys)
        {
            Console.WriteLine($"{item}  :  {dict[item]}");
        }

        Console.WriteLine("\nContains key'4' ? {0}", dict.ContainsKey(4));
        Console.WriteLine("\nContains Value 'CPP' ? {0}", dict.ContainsValue("CPP"));

        dict.Remove(2);
        foreach (var item in dict.Keys)
        {
            Console.WriteLine($"{item}  :  {dict[item]}");
        }


        foreach(KeyValuePair<int, string> kvp in dict)  //correct way of printing
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

    }
}