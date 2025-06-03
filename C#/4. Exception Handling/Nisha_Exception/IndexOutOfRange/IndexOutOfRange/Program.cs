internal class Program
{
    private static void Main(string[] args)
    {
        int[] i = {1,2};
        Console.WriteLine(i[2]);        //invalid index
        //An IndexOutOfRangeException in C# means that your code is trying to access
        //an element of an array or collection using an index that doesn't exist
        //— i.e., it's outside the valid range of indices.
    }
}