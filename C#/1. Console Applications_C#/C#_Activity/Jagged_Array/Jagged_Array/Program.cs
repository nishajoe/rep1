internal class Program
{
    private static void Main(string[] args)
    {
        string[][] roles = new string[2][];         //2 denotes number of arrays in the whole array, roles.
        roles[0] = new string[] { "admin" };
        roles[1] = new string[] { "admin", "qa", "devops", "developer" };

        for (int i = 0; i < roles.Length; i++)
        {
            for(int j = 0; j < roles[i].Length; j++)
            {
                System.Console.Write(roles[i][j] + "    ");
            }
            Console.WriteLine();
        }
    }
}