using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
      //Key should be in double quotes
        ht.Add("Rekha", 1);
        ht.Add("Meena", 2);     //Add method
        ht.Add("Lekha",3);
        Console.WriteLine("List of elements in the hash table are: ");
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        ht.Remove("Meena");                      //Remove method
        Console.WriteLine("\nUpdated hashtable after remove operation:");
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        ht.Add("Meena", 2); 
        ht.Add("Leena", 4);
        ht.Add("Reena", 5);

        Console.WriteLine("\nCount:"+ht.Count);     //Count property
        Console.WriteLine("\nWhether Leena is in the list? "+ht.Contains("Leena"));     //Contains method can be used only on key checking
        Console.WriteLine("\nWhether key 'Leena' is in the list? " + ht.ContainsKey("Leena"));     //Checking whether a particular key is present or not
        Console.WriteLine("\nWhether value '6' is in the list? " + ht.ContainsValue(6));     //Checking whether a particular value is present or not

        Hashtable ht2 = new Hashtable();
        ht2 = (Hashtable)ht.Clone();                //gets a copy of a hashtable
        Console.WriteLine("\nCloned hashtable:");
        foreach (DictionaryEntry entry in ht2)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        Console.WriteLine("\nCheck whether hashtable ht and hashtable ht2 is equal?" + ht.Equals(ht2)); //Check if a Hashtable is equal to another Hashtable
        Console.WriteLine("\nCheck whether hashtable ht and ht is equal?" + ht.Equals(ht));   //Equals is case sensitive
     

        //ht.Clear();         //clearing the hashtable
        //Console.WriteLine("\nUpdated hashtable after clear operation:");
        //foreach (DictionaryEntry entry in ht)
        //{
        //    Console.WriteLine($"{entry.Key} : {entry.Value}");
        //}

    }
}