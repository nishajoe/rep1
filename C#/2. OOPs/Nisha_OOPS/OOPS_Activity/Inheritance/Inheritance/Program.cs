namespace Inheritance
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dog d = new Dog();
            d.sound();  //calling method from the parent class
            d.bark();   //calling method from the child class
        }
    }
}
//if anything is protected inside a class, then that class and its child class only can have the access.