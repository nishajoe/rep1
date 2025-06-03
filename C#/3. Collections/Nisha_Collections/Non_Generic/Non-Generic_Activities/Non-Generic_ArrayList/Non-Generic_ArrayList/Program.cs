using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        ArrayList second_List = new ArrayList();
        arrayList.Add("Renu");              //To add an item in the list
        arrayList.Add("Jim");
        arrayList.Add("Manu");
        arrayList.Add("Teena");
        arrayList.Add("Veena");
        arrayList.Add("Meena");
       
        Console.WriteLine("\nList of items in the array list after 'Add' operation:");
        foreach (string s in arrayList)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("Capacity of arraylist: {0}", arrayList.Capacity);      //To get the capacity that arraylist can hold

        arrayList[1] = "Mangal";        //Replacing an element
        arrayList.Remove("Jim");             //To remove an item in the list
        Console.WriteLine("\nList of items in the array list after removal of 'Jim':");
        foreach (string s in arrayList)
        {
            Console.WriteLine(s);
        }


        arrayList.RemoveAt(4);                //To remove an item in the particular index
        arrayList.Insert(0, "Nisha");       //To insert an item in the particular index
        
        Console.WriteLine("\nList of items in the array list after removal at index position 4 and adding:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

      
        Console.Write("\nIndex of Teena:{0} ", arrayList.IndexOf("Teena"));     //Returns index of particular element

        Console.WriteLine("\nContains Teena?:{0} ", arrayList.Contains("Teena"));  //Returns bool value,whether the given value exist or not & case sensitive while checking

        Console.WriteLine("count:{0} ", arrayList.Count);       //To get the count of elements in the arraylist

        arrayList.Sort();                       //To sort the arraylist
        Console.WriteLine("\nList of items in the array list after sort:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }


        arrayList.Reverse();                        //Reverse order of elements in the arraylist
        Console.WriteLine("\nList of items in the array list after reverse:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        second_List = (ArrayList)arrayList.Clone();     //To make a copy of the arraylist
        Console.WriteLine("\nList of items in the second array by cloning:");
        foreach (var item in second_List)
        {
            Console.WriteLine(item);
        }


        arrayList.RemoveRange(1, 3);                    //To remove a range of elements in the arraylist
        Console.WriteLine("\nList of items in the array list after remove range:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        //arrayList.Clear();                            //To clear the whole list
        //Console.WriteLine("\nList: "); 
        //foreach (var item in arrayList)
        //{
        //    Console.WriteLine(item);
        //}
    }
}