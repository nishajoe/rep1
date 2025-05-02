using System.Diagnostics;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        char choice;
        do
        {
            Console.WriteLine("Name of the student: ");
            String name = Console.ReadLine();
            Console.WriteLine("Mark of 1st subject(out of 100): ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of 2nd subject(out of 100): ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of 3rd subject(out of 100): ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            float avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("Average of {0} is {1} ",name, avg);
            if (avg >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (avg >= 75 && avg < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (avg >= 50 && avg < 75)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
            Console.Write("Do you want to enter another student? (y/n): ");
            choice= (char)Console.Read();
        } while (choice=='y' || choice=='Y');

    }
}

