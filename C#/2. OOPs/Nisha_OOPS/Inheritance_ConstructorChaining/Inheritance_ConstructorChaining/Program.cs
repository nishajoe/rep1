using Inheritance_ConstructorChaining;

internal class Program
{
    private static void Main(string[] args)
    {
        //MyClass2 obj1 = new MyClass2();
        MyClass2 obj2 = new MyClass2(45);  //o/p=> MyClass base class default Constructor
                                           //MyClass2 derived class Parameterised constructor

        //if you want to initialise base class parameterised constructor also, then do constructor chaining
        //in derived class @ required constructor portion.
        //public MyClass2(int b) :base(b)  //b- variable shud be same to get same value of derived

        //o/p=> MyClass base class Parameterised Constructor
        //MyClass2 derived class Parameterised constructor

        //public MyClass2(int b) :base(10)  //if u r givng like this then:
        //o/p=> MyClass base class Parameterised Constructor 10- assigned value 10 to base
        //MyClass2 derived class Parameterised constructor 45
    }
}