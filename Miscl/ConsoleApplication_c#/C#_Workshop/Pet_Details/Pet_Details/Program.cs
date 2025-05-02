internal class Program
{
    private static void Main(string[] args)
    {
        string petName;
        int petAge;

        Console.Write("Enter the name of the pet: ");
        petName=Console.ReadLine();
        Console.Write("Enter the age of the pet: ");
        petAge=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Name of the pet: {0}\n Age of the pet: {1}",petName,petAge);
    }
}