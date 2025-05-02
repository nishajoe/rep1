internal class Program
{
    private static void Main(string[] args)
    {
        string[] roles = new string[4];
        roles[0] = "Admin";
        roles[1] = "Developer";
        roles[2] = "QA";
        roles[3] = "Devops";
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(roles[i]);
        }
    }
}