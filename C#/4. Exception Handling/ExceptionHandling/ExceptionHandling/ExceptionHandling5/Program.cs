using ExceptionHandling5.Category;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ExceptionHandling5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
    
       public static void Menu()
        { 
            Dog dog = new Dog();
            Parrot parrot = new Parrot();
            try
            {
                Console.WriteLine("Select category\n1.Dog\n2.Parrot\n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        dog.DisplayMenu();
                        break;
                    case 2:
                        parrot.DisplayMenu();
                        break;

                    case 3:
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid choice...try again!!!");
                        break;
                }
            }
            catch (FormatException ex) 
            { 
                Console.WriteLine(ex.Message);
                Menu();
            }
            }
            }
        }
   


