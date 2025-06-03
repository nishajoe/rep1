internal class Program
{
    private static void Main(string[] args)
    {
        List<string> myList = new List<string>();       //Type is specified
        myList.Add("Arav");
        myList.Add("Reena");
        myList.Add("Megha");
        myList.Add("Jeena");
        myList.Add("Veena");
        Console.WriteLine("\nElements in the list: ");
        foreach(string str in myList)
        {
            Console.WriteLine(str);
        }

        myList.Remove("Veena");         //remove
        Console.WriteLine("\nUpdated elements in the list: ");
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }

        //have same methods of non-generic collections
        Console.WriteLine("\nCount: " + myList.Count);

        myList.RemoveAt(2);     //remove @index 2

        myList.Insert(1, "Rekha");

        Console.WriteLine("\nUpdated elements in the list: ");
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("\nContains 'Reena'?: " + myList.Contains("Reena"));

        Console.WriteLine("\nUpdated elements in the list after sort: ");
        myList.Sort();
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nIndex of 'Reena'?: " + myList.IndexOf("Reena"));
      


    }
}