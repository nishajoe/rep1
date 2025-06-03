internal class Program
{
    private static void Main(string[] args)
    {
        object[] ob = new string[3];//this is correct because of Array covariance.
        ob[0] = "Hello";
        ob[1] = 1;      // Wrong type: int in string array

        //Array covariance in C# refers to the ability to assign an array of a more
        //specific (derived) type to an array of a more general (base) type.
       //Array covariance allows a string[] to be assigned to an object[], because string derives from object.
        //object[] objects = strings; // This is allowed — this is array covariance
        Console.WriteLine(ob[0]);
    }
}