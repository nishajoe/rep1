using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using PetWorkshop_Enum;
using PetWorkshop_Enum.Enum;
internal class Program
{
    struct Pet
    {
        public int id;
        public string petName;
        public petCategory petCat;
    }
    private static void Main(string[] args)
    {

        Pet p = new Pet();
        bool count;   //bool count=true; can also be set. but defaultly it will be true, no need to set it.
        Console.Write("Enter the id of the pet: ");
        p.id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the pet name: ");
        p.petName = Console.ReadLine();
        do
        {
            Console.Write("\r1,Dog\n 2,Cat\n 3,Fish\n 4,Reptiles\n 5,Bird\n 6,Other\nEnter the corresponding id of the pet from the above list: ");
           int choice=Convert.ToInt32(Console.ReadLine());
            count = true;
            switch (choice)
            {
                case 1:
                    p.petCat = petCategory.Dog;
                    break;
                case 2:
                    p.petCat = petCategory.Cat;
                    break;
                case 3:
                    p.petCat = petCategory.Fish;
                    break;
                case 4:
                    p.petCat = petCategory.Reptiles;
                    break;
                case 5:
                    p.petCat = petCategory.Bird;
                    break;
                case 6:
                    p.petCat = petCategory.Other;
                    break;

                default:
                    Console.WriteLine("Invalid choice!\n Please re-enter the choice");
                    count = false;
                    break;
            }
        } while (count == false);
        Console.WriteLine("Pet details are:");
        Console.WriteLine($"Pet ID:{p.id}");
        Console.WriteLine($"Pet Name: {p.petName}");
        Console.WriteLine("Pet category: {0}",p.petCat);


    }
}