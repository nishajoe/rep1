internal class Program
{
    private static void Main(string[] args)
    {
        string[,] roles = new string[2, 2];
        roles[0, 0] = "Admin";
        roles[0, 1] = "QA";
        roles[1, 0] = "Devops";
        roles[1, 1] = "Developer";
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(roles[i,j]+"   ");
            }
            Console.WriteLine();
        }
    }
}