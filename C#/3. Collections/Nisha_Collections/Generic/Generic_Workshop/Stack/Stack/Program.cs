internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> stk = new Stack<string>();
        stk.Push("Meena");
        stk.Push("Reena");
        stk.Push("Teena");
        stk.Push("Veena");
        stk.Push("sani");
        stk.Push("Aishu");
        Console.WriteLine("\nElements in stack: ");
        foreach (string s in stk)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\nElement @ 1st position: " + stk.Peek());

        Console.WriteLine("\nCount: " + stk.Count());

        stk.Pop();
        Console.WriteLine("\nUpdated stack after remove operation: ");
        foreach (string s in stk)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\nElement @ 1st position: " + stk.Peek());

        Console.WriteLine("\nEnter the element to check? ");
        string check = Console.ReadLine();
        if (stk.Contains(check))
        {
            Console.WriteLine("Item found");
        }
        else
        {
            Console.WriteLine("Item not found");
        }
       
    }
}