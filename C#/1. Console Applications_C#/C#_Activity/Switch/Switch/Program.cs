internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a day in number: ");
        string str=Console.ReadLine();   //default reading style as string is done
        int day=Convert.ToInt32(str);       //converting to integer type
        
        switch(day)
        {
            case 1:Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            default: Console.WriteLine("Not explained in the code!..");
                break ;
        }
    }
}