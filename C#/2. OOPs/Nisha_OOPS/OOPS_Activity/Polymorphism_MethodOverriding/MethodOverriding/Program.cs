using MethodOverriding;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal a = new Dog(); // means 'a' is of Animal type and @ runtime aasigning the value of derived class 'Dog'
                              // ie; passing reference of Dog type

        a.Sound();  //runs the sound method of dog class

        a = new Cat(); //assigning value of the derived class to 'a', to bound the method of derived class
                       //with the object.

        a.Sound();  //runs the sound method of cat class
    }
}