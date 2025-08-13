using Nisha_Exercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Validation validate = new Validation();

        do
        {
            Console.WriteLine("Choose an option: \n1) Registration\n2) Login \n3) Logout");
            int input=Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Username: ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string pwd = Console.ReadLine();
                    validate.Register(user,pwd);
                    break;

                case 2:
                    Console.WriteLine("Username: ");
                    string u = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string p = Console.ReadLine();
                    validate.Login(u,p);
                    break;

                case 3:
                    validate.Logout();
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            
        } while (true); //or while(input!="exit");
    }
}