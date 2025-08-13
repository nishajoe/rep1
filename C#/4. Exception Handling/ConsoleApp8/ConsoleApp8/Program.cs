using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2; 
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("System Exception Caught: " + ex.Message);
            }

            try
            {
               
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    
                    throw new InvalidAgeException("Age must be 18 or above to register.");
                }

                Console.WriteLine("You are eligible to register!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }

            Console.WriteLine("Program continues...");
        }
    }


    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
