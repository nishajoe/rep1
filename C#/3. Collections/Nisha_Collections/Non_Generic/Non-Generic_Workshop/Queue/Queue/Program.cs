using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue q = new Queue();
        q.Enqueue("Cat");
        q.Enqueue("Rabbit");
        q.Enqueue("Dog");
        q.Enqueue("Pigeon");
        q.Enqueue("Parrot");
        Console.WriteLine("\nElements in the queue are: ");
        foreach (string s in q)
        {
            Console.WriteLine(s);
        }

        q.Dequeue();
        Console.WriteLine("\nUpdated queue: ");
        foreach (string s in q)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine("\nElement at the 1st position: " + q.Peek());
        Console.WriteLine("\nLength of Queue: " + q.Count);
    }
}