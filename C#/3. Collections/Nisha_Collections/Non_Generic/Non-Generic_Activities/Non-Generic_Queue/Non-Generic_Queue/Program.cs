using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue q = new Queue();
        q.Enqueue("Nisha");
        q.Enqueue("Titto");
        q.Enqueue("Tony");
        q.Enqueue("Stalin");
        q.Enqueue("Nimmy");     //Adding into queue
        Console.WriteLine("\nElements in the queue are: ");
        while(q.Count>0)
        {
            Console.WriteLine(q.Dequeue());     //Remove and print the elements at the begining of queue
        }


        Console.WriteLine("\nUpdated queue: ");
        foreach (string s in q)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine("\nElement at the peek position: " + q.Peek());
        Console.WriteLine("\nLength of Queue: " + q.Count);
            
    }
}