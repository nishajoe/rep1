internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many pets do you want to input: ");
        int a= Convert.ToInt32(Console.ReadLine());
        string[] pets = new string[a];
        for (int i = 0; i < pets.Length; i++)
        {
            Console.Write("Enter the name of {0}th pet: ", i + 1); //0 will be the first index in the placeholder
            pets[i] = Console.ReadLine();
        }
        Console.WriteLine("\nInputted pets are: ");
        foreach(string s in pets)
        {
            Console.WriteLine(s);
        }
    }
}