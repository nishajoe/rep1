using Encapsulation;
class Program
{
    private static void Main(string[] args)
    {
        Student stud = new Student();

        stud.Age = 20;
        stud.display();

        Console.WriteLine("Next object call!....");
        stud.Age = 2;
        stud.display();
    }
}