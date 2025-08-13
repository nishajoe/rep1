internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Reena", "Alice", "Renu" };

        /*  // Select the lengths of each name
          var nameLengths = names.Select(name => name.Length);
          foreach (var length in nameLengths)
          {
              Console.WriteLine(length);
          }
        This commented portion just prints the length not with names, and the program below this prints name along with length

  */

        //var nameLength = names.Select(n => new
        //{
        //    Name = n,
        //    Length = n.Length
        //});

        //foreach (var l in nameLength) //display
        //{

        //    Console.WriteLine($"Name: {l.Name}, Length: {l.Length}");
        //}

        //Using query syntax
        var resultLength = from name in names
                           select new
                           {
                               Name = name,
                               Length = name.Length
                           };
        foreach (var l in resultLength)
        {
            Console.WriteLine($"Name: {l.Name}, Length: {l.Length}");
        }
    }
}