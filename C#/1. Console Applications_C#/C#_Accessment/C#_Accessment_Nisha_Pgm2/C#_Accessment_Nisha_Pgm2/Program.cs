
//Write a program that accepts the customer name and the number of units consumed.
//Calculate the bill amount using the following rules:
//•	For units ≤ 100: ₹5 / unit
//•	For units > 100 and ≤ 200: ₹7 / unit
//•	For units > 200: ₹10 / unit
//Display the customer name and total bill amount. Ask if the user wants to continue.

using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int billAmount;
        bool chance;
        do
        {
            Console.WriteLine("Name of the customer: ");
            string name = Console.ReadLine();
            Console.WriteLine("Units consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n----------Electricity Bill------------ ");
            if (units <= 100)
            {
                billAmount = units * 5;
            }
            else if (units > 100 && units <= 200)
            {
                billAmount = units * 7;
            }
            else
            {
                billAmount = units * 10;
            }
            Console.WriteLine("Name: {0}\nTotal bill amount: {1}", name, billAmount);
            Console.Write("Do you want to continue? y/n :  ");
            char c = (char)Console.Read();
            if (c == 'y' || c == 'Y')
            {
                chance = true;
            }
            else
            {
                chance = false;
            }
        } while (chance == true);


    }
}