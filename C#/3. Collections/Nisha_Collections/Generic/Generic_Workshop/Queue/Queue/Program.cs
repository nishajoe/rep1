internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("Parrot");
        q.Enqueue("Pigeon");
        q.Enqueue("Cat");
        q.Enqueue("Dog");
        q.Enqueue("Swaan");
        Console.WriteLine("\nElements in the queue: ");
        foreach (string s in q)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("\nCount: " + q.Count);

        Console.WriteLine("\nElement @ peek position: " + q.Peek());

        q.Dequeue();
        Console.WriteLine("\nElement @ peek position after Dequeu operation: " + q.Peek());
        Console.WriteLine("\nUpdated queue: ");
        foreach (string s in q)
        {
            Console.WriteLine(s);
        }
    }
}