class Program
{
    int marks;

    public Program()
    {
        this.marks = 45; //Now after adding this constructor, if we call the display function, it will print
                         //marks as 45 which is initialised at the time of invoke.
    }
    void display()
    {
        Console.WriteLine("Marks: "+marks);
    }
    private static void Main(string[] args)
    {
        Program p = new Program();
        p.display();    //Here marks will be zero, since we haven't given any constructor to set that value.
                        //So it initialise it as zero.

    }
}